using System;
using System.Windows.Forms;

namespace SeenIt
{
    public partial class frmAddMovie : Form
    {
        SeenItDB dbSeenIt = new SeenItDB();
        public frmAddMovie()
        {
            InitializeComponent();
        }

        private void txtPlot_TextChanged(object sender, EventArgs e)
        {
            int nTxtLen = txtPlot.Text.Length;
            int nTxtRemaining = 300 - nTxtLen;
            lblCharRemaining.Text = nTxtRemaining.ToString() + " characters remaining.";
        }

        private void btnAddToDb_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();

            movie.Title = txtMovieTitle.Text;
            movie.Released = txtReleased.Text;
            movie.Plot = txtPlot.Text;
            movie.Actors = txtActors.Text;
            movie.Director = txtDirector.Text;
            movie.Genre = cbGenres.Text;
            movie.Rated = cbRating.Text;
            movie.Comments = txtComments.Text;

           
            int nResult = dbSeenIt.AddMovie(movie);
            if (nResult > 0)
            {
                MessageBox.Show("The movie was successfully added to the database.");
            }
            else
            {
                MessageBox.Show("Unable to add the movie. Please make sure everything is filled in correctly.");
            }
            
        }
    }
}