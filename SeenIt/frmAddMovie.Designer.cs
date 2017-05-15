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
            this.btnAddToDb = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.cbGenres = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtStars = new System.Windows.Forms.TextBox();
            this.lblStars = new System.Windows.Forms.Label();
            this.lblCharRemaining = new System.Windows.Forms.Label();
            this.txtSynopsis = new System.Windows.Forms.TextBox();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.dtReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.cbUseIMDB = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.pnlAddMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddMovie
            // 
            this.pnlAddMovie.Controls.Add(this.lblDirector);
            this.pnlAddMovie.Controls.Add(this.txtDirector);
            this.pnlAddMovie.Controls.Add(this.btnAddToDb);
            this.pnlAddMovie.Controls.Add(this.txtComments);
            this.pnlAddMovie.Controls.Add(this.lblComments);
            this.pnlAddMovie.Controls.Add(this.cbRating);
            this.pnlAddMovie.Controls.Add(this.lblRating);
            this.pnlAddMovie.Controls.Add(this.cbGenres);
            this.pnlAddMovie.Controls.Add(this.lblGenre);
            this.pnlAddMovie.Controls.Add(this.txtStars);
            this.pnlAddMovie.Controls.Add(this.lblStars);
            this.pnlAddMovie.Controls.Add(this.lblCharRemaining);
            this.pnlAddMovie.Controls.Add(this.txtSynopsis);
            this.pnlAddMovie.Controls.Add(this.lblSynopsis);
            this.pnlAddMovie.Controls.Add(this.dtReleaseDate);
            this.pnlAddMovie.Controls.Add(this.lblReleaseDate);
            this.pnlAddMovie.Controls.Add(this.cbUseIMDB);
            this.pnlAddMovie.Controls.Add(this.lblTitle);
            this.pnlAddMovie.Controls.Add(this.txtMovieTitle);
            this.pnlAddMovie.Location = new System.Drawing.Point(45, -17);
            this.pnlAddMovie.Name = "pnlAddMovie";
            this.pnlAddMovie.Size = new System.Drawing.Size(480, 537);
            this.pnlAddMovie.TabIndex = 2;
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
            // txtStars
            // 
            this.txtStars.Location = new System.Drawing.Point(126, 215);
            this.txtStars.MaxLength = 200;
            this.txtStars.Multiline = true;
            this.txtStars.Name = "txtStars";
            this.txtStars.Size = new System.Drawing.Size(204, 57);
            this.txtStars.TabIndex = 9;
            // 
            // lblStars
            // 
            this.lblStars.AutoSize = true;
            this.lblStars.Location = new System.Drawing.Point(44, 218);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(31, 13);
            this.lblStars.TabIndex = 8;
            this.lblStars.Text = "Stars";
            // 
            // lblCharRemaining
            // 
            this.lblCharRemaining.AutoSize = true;
            this.lblCharRemaining.Location = new System.Drawing.Point(337, 177);
            this.lblCharRemaining.Name = "lblCharRemaining";
            this.lblCharRemaining.Size = new System.Drawing.Size(0, 13);
            this.lblCharRemaining.TabIndex = 7;
            // 
            // txtSynopsis
            // 
            this.txtSynopsis.Location = new System.Drawing.Point(126, 134);
            this.txtSynopsis.MaxLength = 300;
            this.txtSynopsis.Multiline = true;
            this.txtSynopsis.Name = "txtSynopsis";
            this.txtSynopsis.Size = new System.Drawing.Size(204, 57);
            this.txtSynopsis.TabIndex = 6;
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Location = new System.Drawing.Point(44, 134);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(49, 13);
            this.lblSynopsis.TabIndex = 5;
            this.lblSynopsis.Text = "Synopsis";
            // 
            // dtReleaseDate
            // 
            this.dtReleaseDate.Location = new System.Drawing.Point(146, 80);
            this.dtReleaseDate.Name = "dtReleaseDate";
            this.dtReleaseDate.Size = new System.Drawing.Size(184, 20);
            this.dtReleaseDate.TabIndex = 4;
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
            // cbUseIMDB
            // 
            this.cbUseIMDB.AutoSize = true;
            this.cbUseIMDB.Location = new System.Drawing.Point(345, 38);
            this.cbUseIMDB.Name = "cbUseIMDB";
            this.cbUseIMDB.Size = new System.Drawing.Size(117, 17);
            this.cbUseIMDB.TabIndex = 2;
            this.cbUseIMDB.Text = "Get Info from IMDB";
            this.cbUseIMDB.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TextBox txtStars;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.Label lblCharRemaining;
        private System.Windows.Forms.TextBox txtSynopsis;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.DateTimePicker dtReleaseDate;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.CheckBox cbUseIMDB;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.TextBox txtDirector;
    }
}