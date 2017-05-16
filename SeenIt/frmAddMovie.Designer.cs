namespace SeenIt
{
    partial class frmAddMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAddMovie = new System.Windows.Forms.Panel();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.btnAddToDb = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.cbGenres = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtActors = new System.Windows.Forms.TextBox();
            this.lblActors = new System.Windows.Forms.Label();
            this.lblCharRemaining = new System.Windows.Forms.Label();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.lblPlot = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.txtReleased = new System.Windows.Forms.TextBox();
            this.pnlAddMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddMovie
            // 
            this.pnlAddMovie.Controls.Add(this.txtReleased);
            this.pnlAddMovie.Controls.Add(this.lblDirector);
            this.pnlAddMovie.Controls.Add(this.txtDirector);
            this.pnlAddMovie.Controls.Add(this.btnAddToDb);
            this.pnlAddMovie.Controls.Add(this.txtComments);
            this.pnlAddMovie.Controls.Add(this.lblComments);
            this.pnlAddMovie.Controls.Add(this.cbRating);
            this.pnlAddMovie.Controls.Add(this.lblRating);
            this.pnlAddMovie.Controls.Add(this.cbGenres);
            this.pnlAddMovie.Controls.Add(this.lblGenre);
            this.pnlAddMovie.Controls.Add(this.txtActors);
            this.pnlAddMovie.Controls.Add(this.lblActors);
            this.pnlAddMovie.Controls.Add(this.lblCharRemaining);
            this.pnlAddMovie.Controls.Add(this.txtPlot);
            this.pnlAddMovie.Controls.Add(this.lblPlot);
            this.pnlAddMovie.Controls.Add(this.lblReleaseDate);
            this.pnlAddMovie.Controls.Add(this.lblTitle);
            this.pnlAddMovie.Controls.Add(this.txtMovieTitle);
            this.pnlAddMovie.Location = new System.Drawing.Point(45, -17);
            this.pnlAddMovie.Name = "pnlAddMovie";
            this.pnlAddMovie.Size = new System.Drawing.Size(480, 537);
            this.pnlAddMovie.TabIndex = 2;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(44, 298);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 18;
            this.lblDirector.Text = "Director";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(126, 295);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(204, 20);
            this.txtDirector.TabIndex = 17;
            // 
            // btnAddToDb
            // 
            this.btnAddToDb.Location = new System.Drawing.Point(146, 494);
            this.btnAddToDb.Name = "btnAddToDb";
            this.btnAddToDb.Size = new System.Drawing.Size(147, 36);
            this.btnAddToDb.TabIndex = 16;
            this.btnAddToDb.Text = "Add";
            this.btnAddToDb.UseVisualStyleBackColor = true;
            this.btnAddToDb.Click += new System.EventHandler(this.btnAddToDb_Click);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(126, 426);
            this.txtComments.MaxLength = 200;
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(204, 57);
            this.txtComments.TabIndex = 15;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(44, 429);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 14;
            this.lblComments.Text = "Comments";
            // 
            // cbRating
            // 
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R",
            "NC-17"});
            this.cbRating.Location = new System.Drawing.Point(126, 379);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(204, 21);
            this.cbRating.TabIndex = 13;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(44, 387);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 12;
            this.lblRating.Text = "Rating";
            // 
            // cbGenres
            // 
            this.cbGenres.FormattingEnabled = true;
            this.cbGenres.Items.AddRange(new object[] {
            "Action/Adventure",
            "Comedy",
            "Sci-Fi",
            "Documentary",
            "Horror",
            "Thriller",
            "Western",
            "Animation",
            "Romantic Comedy",
            "War",
            "Film Noi",
            "Romance",
            "Fantasy"});
            this.cbGenres.Location = new System.Drawing.Point(126, 332);
            this.cbGenres.Name = "cbGenres";
            this.cbGenres.Size = new System.Drawing.Size(204, 21);
            this.cbGenres.TabIndex = 11;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(44, 340);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 10;
            this.lblGenre.Text = "Genre";
            // 
            // txtActors
            // 
            this.txtActors.Location = new System.Drawing.Point(126, 215);
            this.txtActors.MaxLength = 200;
            this.txtActors.Multiline = true;
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(204, 57);
            this.txtActors.TabIndex = 9;
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Location = new System.Drawing.Point(44, 218);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(37, 13);
            this.lblActors.TabIndex = 8;
            this.lblActors.Text = "Actors";
            // 
            // lblCharRemaining
            // 
            this.lblCharRemaining.AutoSize = true;
            this.lblCharRemaining.Location = new System.Drawing.Point(337, 177);
            this.lblCharRemaining.Name = "lblCharRemaining";
            this.lblCharRemaining.Size = new System.Drawing.Size(0, 13);
            this.lblCharRemaining.TabIndex = 7;
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(126, 134);
            this.txtPlot.MaxLength = 300;
            this.txtPlot.Multiline = true;
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(204, 57);
            this.txtPlot.TabIndex = 6;
            this.txtPlot.TextChanged += new System.EventHandler(this.txtPlot_TextChanged);
            // 
            // lblPlot
            // 
            this.lblPlot.AutoSize = true;
            this.lblPlot.Location = new System.Drawing.Point(44, 134);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(25, 13);
            this.lblPlot.TabIndex = 5;
            this.lblPlot.Text = "Plot";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(44, 86);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(72, 13);
            this.lblReleaseDate.TabIndex = 3;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(44, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(126, 38);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(204, 20);
            this.txtMovieTitle.TabIndex = 0;
            // 
            // txtReleased
            // 
            this.txtReleased.Location = new System.Drawing.Point(122, 86);
            this.txtReleased.Name = "txtReleased";
            this.txtReleased.Size = new System.Drawing.Size(204, 20);
            this.txtReleased.TabIndex = 19;
            // 
            // frmAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 530);
            this.Controls.Add(this.pnlAddMovie);
            this.Name = "frmAddMovie";
            this.Text = "Add a Movie";
            this.pnlAddMovie.ResumeLayout(false);
            this.pnlAddMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddMovie;
        private System.Windows.Forms.Button btnAddToDb;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.ComboBox cbGenres;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtActors;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.Label lblCharRemaining;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtReleased;
    }
}