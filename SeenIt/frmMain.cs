using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            dbSeenIt.CreateSeenItDB();
            dbSeenIt.CreateMoviesTable();
            cbSearchBy.SelectedIndex = 0;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
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
                    DialogResult result = MessageBox.Show("That movie was not found. Would you like to add it?", "SeenIt", MessageBoxButtons.YesNo);
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
