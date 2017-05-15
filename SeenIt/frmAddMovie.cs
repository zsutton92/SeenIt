using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void txtSynopsis_TextChanged(object sender, EventArgs e)
        {
            int nTxtLen = txtSynopsis.Text.Length;
            int nTxtRemaining = 300 - nTxtLen;
            lblCharRemaining.Text = nTxtRemaining.ToString() + " characters remaining.";
        }

        private void cbUseIMDB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseIMDB.Checked)
            {
                lblGenre.Visible = false;
                cbGenres.Visible = false;
                lblReleaseDate.Visible = false;
                dtReleaseDate.Visible = false;
                lblSynopsis.Visible = false;
                txtSynopsis.Visible = false;
                lblStars.Visible = false;
                txtStars.Visible = false;
                lblRating.Visible = false;
                cbRating.Visible = false;
                lblDirector.Visible = false;
                txtDirector.Visible = false;
            }
            else
            {
                lblGenre.Visible = true;
                cbGenres.Visible = true;
                lblReleaseDate.Visible = true;
                dtReleaseDate.Visible = true;
                lblSynopsis.Visible = true;
                txtSynopsis.Visible = true;
                lblStars.Visible = true;
                txtStars.Visible = true;
                lblRating.Visible = true;
                cbRating.Visible = true;
                lblDirector.Visible = true;
                txtDirector.Visible = true;
            }
        }

        private void btnAddToDb_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            if (!cbUseIMDB.Checked)
            {             
                movie.Title = txtMovieTitle.Text;
                movie.ReleaseDate = dtReleaseDate.Value;
                movie.Synopsis = txtSynopsis.Text;
                movie.Stars = txtStars.Text;
                movie.Director = txtDirector.Text;
                movie.Genre = cbGenres.SelectedItem.ToString();
                movie.Rating = cbRating.SelectedItem.ToString();
                movie.Comments = txtComments.Text;
            }
            dbSeenIt.AddMovie(movie);   
        }
    }
}
