/* Application : SeeIt
 * Class: frmMain
 * Developer: Zack Sutton
 * Date: 05/09/17
 * Purpose: This application will allow you to search for movie data via the Open Movie Database. You can add it to your own personal movie database.
 *          This class handles the GUI functions.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SeenIt
{
    public partial class frmMain : Form
    {
        SeenItDB dbSeenIt = new SeenItDB();
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks to see if the Database and Table exists. Then sets the cbSearchBy to Title.
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            dbSeenIt.CreateSeenItDB();
            dbSeenIt.CreateMoviesTable();
            cbSearchBy.SelectedIndex = 0;
        }

        /// <summary>
        /// Searches for a movie. If found, displays results. If not, asks if you would like to add it.
        /// First tries to add via getting data from internet. If successful, displays results.
        /// If not, prompts you to add manually.
        /// </summary>
        private void btnGo_Click(object sender, EventArgs e)
        {
            dgvFoundMovies.DataSource = null;
            dgvFoundMovies.Visible = false;

            if (txtSearchTerms.Text != String.Empty)
            {
                string strSearchTerm = txtSearchTerms.Text;
                string strMovieProperty = cbSearchBy.Text;

                List<Movie> lstFoundMovies = dbSeenIt.FindMovie(strSearchTerm, strMovieProperty);

                if (lstFoundMovies.Count != 0)
                {
                    dgvFoundMovies.DataSource = lstFoundMovies;
                    dgvFoundMovies.Visible = true;

                }
                else
                {
                    DialogResult result = MessageBox.Show("That movie was not found in the database. Would you like to find it and add it?", "SeenIt", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {                       
                        Movie foundMovie = FindMovie(strSearchTerm);
                        if (foundMovie != null)
                        {
                           int nResult =  dbSeenIt.AddMovie(foundMovie);
                           if (nResult > 0)
                            {
                                lstFoundMovies.Add(foundMovie);
                                dgvFoundMovies.DataSource = lstFoundMovies;
                                dgvFoundMovies.Visible = true;
                            }
                        }
                        else
                        {
                            result = MessageBox.Show("Unable to find " + strSearchTerm + " via the internet. Would you like to add it manually?", "SeenIt", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                frmAddMovie addMovieForm = new frmAddMovie();
                                addMovieForm.Show();
                            }
                        }


                    }
                }
            }
        }

        /// <summary>
        /// Finds movie via data from the Internet.
        /// </summary>
        /// <param name="strSearchTerm">String containing the search term.</param>
        /// <returns name = "foundMovie">Movie object</returns>
        private Movie FindMovie(string strSearchTerm)
        {
            Movie foundMovie = new Movie();

            foundMovie = foundMovie.GetMovieByTitle(strSearchTerm);

            return foundMovie;
        }
    }
}

   