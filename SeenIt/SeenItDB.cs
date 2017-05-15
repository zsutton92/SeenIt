using System;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;

namespace SeenIt
{
    class SeenItDB
    {
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

        public void CreateMoviesTable()
        {
            string strSqlCmd, strSqlConn;
            bool tblExists;

            strSqlConn = ("Server = localhost\\SEENITDB;Integrated security = SSPI;database = SeenMovies");

            tblExists = TableExists(strSqlConn, "Movies");
            if (!tblExists)
            {
                strSqlCmd = "CREATE TABLE Movies(Title char(100),Release_Date datetime, Synopsis char(300), Stars char(200), Director char(20),Genre char(20),Rating char(3), Comments char(250));";
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
    
        public void AddMovie(Movie movie)
        {
            string strSqlCmd, strSqlConn;

            strSqlConn = "Server = localhost\\SEENITDB;Integrated security = SSPI;database = SeenMovies";
            strSqlCmd = "INSERT INTO Movies (Title, Release_Date, Synopsis, Stars, Director, Genre, Rating, Comments) VALUES (@valTitle, @valRelease_Date," +
                        "@valSynopsis, @valStars, @valDirector, @valGenre, @valRating, @valComments)";
            using (SqlConnection sqlConn = new SqlConnection(strSqlConn))
            {
                using (SqlCommand sqlCmd = new SqlCommand(strSqlCmd, sqlConn))
                {
                    sqlCmd.Parameters.AddWithValue("@valTitle", movie.Title);
                    sqlCmd.Parameters.AddWithValue("@valRelease_Date", movie.ReleaseDate);
                    sqlCmd.Parameters.AddWithValue("@valSynopsis", movie.Synopsis);
                    sqlCmd.Parameters.AddWithValue("@valStars", movie.Stars);
                    sqlCmd.Parameters.AddWithValue("@valDirector", movie.Director);
                    sqlCmd.Parameters.AddWithValue("@valGenre", movie.Genre);
                    sqlCmd.Parameters.AddWithValue("@valRating", movie.Rating);
                    sqlCmd.Parameters.AddWithValue("@valComments", movie.Comments);

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

        public List<Movie> FindMovie(string searchTerm, string movieProperty)
        {
            Movie foundMovie = null;
            List<Movie> lstFoundMovies = new List<Movie>();
            SqlDataReader sqlDataReader = null;
            string strSqlConn, strSqlcmd;
            strSqlConn = "Server = localhost\\SEENITDB;Integrated security = SSPI;database = SeenMovies";
            strSqlcmd = $"SELECT * FROM Movies WHERE {movieProperty} = '{searchTerm}'";
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
                                foundMovie.ReleaseDate = sqlDataReader.GetDateTime(1);
                                foundMovie.Synopsis = sqlDataReader.GetString(2).Trim();
                                foundMovie.Stars = sqlDataReader.GetString(3).Trim();
                                foundMovie.Director = sqlDataReader.GetString(4).Trim();
                                foundMovie.Genre = sqlDataReader.GetString(5).Trim();
                                foundMovie.Rating = sqlDataReader.GetString(6).Trim();
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
