/* Application : SeenIt
 * Class: SeenItDB
 * Developer: Zack Sutton
 * Date: 05/09/17
 * Purpose: This class handles all of the database functions for the SeenIt database.
 */
using System;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;

namespace SeenIt
{
    class SeenItDB
    {
        /// <summary>
        /// Creates the Seen_Movies database if it does not already exist..
        /// </summary>        
        /// </param>
        public void CreateSeenItDB()
        {
            string strSqlCmd, strSqlConn, sqlFileLocation;
            bool dbExists;
            strSqlConn = ("Server = localhost\\SEENITDB;Integrated security = SSPI;database = master");

            dbExists = DatabaseExists(strSqlConn, "SeenMovies");
            if (!dbExists)
            {
                sqlFileLocation = Directory.GetCurrentDirectory() + "\\seen_movies.mdf";

                strSqlCmd = "CREATE DATABASE SeenMovies ON PRIMARY " +
                             "(NAME = SeenMovies_Data," +
                             "FILENAME = '" + sqlFileLocation + "'," +
                             "SIZE = 3MB, MAXSIZE = 100MB, FILEGROWTH = 10%)";
                using (SqlConnection sqlConn = new SqlConnection(strSqlConn))
                {
                    using (SqlCommand sqlCmd = new SqlCommand(strSqlCmd, sqlConn))
                    {
                        try
                        {
                            sqlConn.Open();
                            sqlCmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Creates the Movies table, if it does not already exist.
        /// </summary>
        /// </param>        
        public void CreateMoviesTable()
        {
            string strSqlCmd, strSqlConn;
            bool tblExists;

            strSqlConn = ("Server = localhost\\SEENITDB;Integrated security = SSPI;database = SeenMovies");

            tblExists = TableExists(strSqlConn, "Movies");
            if (!tblExists)
            {
                strSqlCmd = "CREATE TABLE Movies(Title char(100),Released char(12), Plot char(300), Actors char(200), Director char(20),Genre char(20),Rating char(5), Comments char(250));";
                using (SqlConnection sqlConn = new SqlConnection(strSqlConn))
                {
                    using (SqlCommand sqlCmd = new SqlCommand(strSqlCmd, sqlConn))
                    {
                        try
                        {
                            sqlConn.Open();
                            sqlCmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Checks to see if a database exists
        /// </summary>
        /// <param name="connectionString">String containing the SQL connection.</param>
        /// <param name="dbName">String  that contains the database name to check./param>
        /// <returns name = "dbExists">Boolean value based on if the database exists.</returns>
        private static bool DatabaseExists(string connectionString, string dbName)
        {
            bool dbExists = false;

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCmd = new SqlCommand($"SELECT db_ID('{dbName}')", sqlConn)) 
                {
                    try
                    {
                        sqlConn.Open();
                        dbExists = (sqlCmd.ExecuteScalar() != DBNull.Value);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return dbExists;
        }

        /// <summary>
        /// Checks to see if a database exists
        /// </summary>
        /// <param name="connectionString">String containing the SQL connection.</param>
        /// <param name="tblName">String  that contains the table name to check./param>
        /// <returns name = "tblExists">Boolean value based on if the table exists.</returns>
        private static bool TableExists(string connectionString, string tblName)
        {
            bool tblExists = false;

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCmd = new SqlCommand($"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tblName}'", sqlConn))
                {
                    try
                    {
                        sqlConn.Open();
                        int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        tblExists = (count > 0);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }            
            return tblExists;
        }

        /// <summary>
        /// Add a movie to the database
        /// </summary>
        /// <param name="Movie">The Movie object to add.</param>
        /// <returns name = "nResult">Integer containing number of rows affected.</returns>
        public int AddMovie(Movie movie)
        {
            string strSqlCmd, strSqlConn;
            int nResult = 0;
            strSqlConn = "Server = localhost\\SEENITDB;Integrated security = SSPI;database = SeenMovies";
            strSqlCmd = "INSERT INTO Movies (Title, Released, Plot, Actors, Director, Genre, Rating, Comments) VALUES (@valTitle, @valRelease_Date," +
                        "@valSynopsis, @valStars, @valDirector, @valGenre, @valRating, @valComments)";
            if (movie.Title != String.Empty)
            {
                using (SqlConnection sqlConn = new SqlConnection(strSqlConn))
                {
                    using (SqlCommand sqlCmd = new SqlCommand(strSqlCmd, sqlConn))
                    {
                        sqlCmd.Parameters.AddWithValue("@valTitle", movie.Title);
                        sqlCmd.Parameters.AddWithValue("@valRelease_Date", movie.Released);
                        sqlCmd.Parameters.AddWithValue("@valSynopsis", movie.Plot);
                        sqlCmd.Parameters.AddWithValue("@valStars", movie.Actors);
                        sqlCmd.Parameters.AddWithValue("@valDirector", movie.Director);
                        if (movie.Genre.Contains(","))
                        {
                            movie.Genre = movie.Genre.Substring(0, movie.Genre.IndexOf(','));
                        }
                        sqlCmd.Parameters.AddWithValue("@valGenre", movie.Genre);
                        sqlCmd.Parameters.AddWithValue("@valRating", movie.Rated);
                        if (movie.Comments == null)
                        {
                            movie.Comments = "Data provided by the Open Movie Database";
                        }
                        sqlCmd.Parameters.AddWithValue("@valComments", movie.Comments);

                        try
                        {
                            sqlConn.Open();
                            nResult = sqlCmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            return nResult;
        }

        /// <summary>
        /// Checks to see if a movie exists in the database.
        /// </summary>
        /// <param name="searchTerm">String containing the search term.</param>
        /// <param name="movieProperty">String that contains property to search on (EX: Title, Genre, Rating)./param>
        /// <returns name = "lstFoundMovies">A list containing movie objects.</returns>
        public List<Movie> FindMovie(string searchTerm, string movieProperty)
        {
            Movie foundMovie = null;
            List<Movie> lstFoundMovies = new List<Movie>();
            SqlDataReader sqlDataReader = null;
            string strSqlConn, strSqlcmd;
            strSqlConn = "Server = localhost\\SEENITDB;Integrated security = SSPI;database = SeenMovies";
            strSqlcmd = $"SELECT * FROM Movies WHERE {movieProperty} LIKE '%{searchTerm}%'";
            using (SqlConnection sqlConn = new SqlConnection(strSqlConn))
            {
                using (SqlCommand sqlCmd = new SqlCommand(strSqlcmd, sqlConn))
                {
                    try
                    {
                        sqlConn.Open();
                        sqlDataReader = sqlCmd.ExecuteReader();
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                foundMovie = new Movie();
                                foundMovie.Title = sqlDataReader.GetString(0).Trim();
                                foundMovie.Released = sqlDataReader.GetString(1);
                                foundMovie.Plot = sqlDataReader.GetString(2).Trim();
                                foundMovie.Actors = sqlDataReader.GetString(3).Trim();
                                foundMovie.Director = sqlDataReader.GetString(4).Trim();
                                foundMovie.Genre = sqlDataReader.GetString(5).Trim();
                                foundMovie.Rated = sqlDataReader.GetString(6).Trim();
                                foundMovie.Comments = sqlDataReader.GetString(7).Trim();
                                lstFoundMovies.Add(foundMovie);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return lstFoundMovies;
        }
    }
}
