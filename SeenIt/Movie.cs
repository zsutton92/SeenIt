/* Application : SeeIt
 * Class: Movie
 * Developer: Zack Sutton
 * Date: 05/09/17
 * Purpose: This class creates a Movie object. This class also handles logic used to build the Movie object.
 */

using Newtonsoft.Json;
using System;
using System.Net;


namespace SeenIt
{   
    class Movie
    {
        public string Title { get; set; }
        public string Released { get; set; }
        public string Plot{ get; set; }
        public string Actors { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Rated { get; set; }
        public string Comments { get; set; }

        /// <summary>
        /// Gets movie data by searching the omdbapi with a title.
        /// </summary>
        /// <param name="movieTitle">String containing the movie title to search for.</param>        
        /// <returns name = "foundMovie">Resulting Movie object.</returns>
        public Movie GetMovieByTitle(string movieTitle)
        {
            Movie foundMovie = null;

            string strSearchTerm = movieTitle.Replace(" ", "%20");
            string strUrl = @"http://www.omdbapi.com/?t=" + strSearchTerm;

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string jsonMovieResult = webClient.DownloadString(strUrl);
                    foundMovie = JsonConvert.DeserializeObject<Movie>(jsonMovieResult); //Convert JSON result to Movie properties.
                    if (foundMovie.Title == null)
                    {
                        foundMovie = null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return foundMovie;
        }
    }    
}
