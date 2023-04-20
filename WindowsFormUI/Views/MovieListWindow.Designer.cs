
namespace WindowsFormUI.UIWindows
{
    partial class MovieListWindow
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
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.DeleteMovieButton = new System.Windows.Forms.Button();
            this.EditMovieButton = new System.Windows.Forms.Button();
            this.ListOfMoviesLabel = new System.Windows.Forms.Label();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(323, 135);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(51, 16);
            this.SearchLabel.TabIndex = 56;
            this.SearchLabel.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(326, 154);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(156, 21);
            this.SearchTextBox.TabIndex = 55;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMovieButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddMovieButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddMovieButton.Location = new System.Drawing.Point(650, 306);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(96, 31);
            this.AddMovieButton.TabIndex = 54;
            this.AddMovieButton.Text = "Add";
            this.AddMovieButton.UseVisualStyleBackColor = false;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // DeleteMovieButton
            // 
            this.DeleteMovieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteMovieButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteMovieButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteMovieButton.Location = new System.Drawing.Point(650, 239);
            this.DeleteMovieButton.Name = "DeleteMovieButton";
            this.DeleteMovieButton.Size = new System.Drawing.Size(96, 31);
            this.DeleteMovieButton.TabIndex = 53;
            this.DeleteMovieButton.Text = "Delete";
            this.DeleteMovieButton.UseVisualStyleBackColor = false;
            this.DeleteMovieButton.Click += new System.EventHandler(this.DeleteMovieButton_Click);
            // 
            // EditMovieButton
            // 
            this.EditMovieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditMovieButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditMovieButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EditMovieButton.Location = new System.Drawing.Point(528, 239);
            this.EditMovieButton.Name = "EditMovieButton";
            this.EditMovieButton.Size = new System.Drawing.Size(96, 31);
            this.EditMovieButton.TabIndex = 52;
            this.EditMovieButton.Text = "Edit";
            this.EditMovieButton.UseVisualStyleBackColor = false;
            this.EditMovieButton.Click += new System.EventHandler(this.EditMovieButton_Click);
            // 
            // ListOfMoviesLabel
            // 
            this.ListOfMoviesLabel.AutoSize = true;
            this.ListOfMoviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfMoviesLabel.Location = new System.Drawing.Point(7, 135);
            this.ListOfMoviesLabel.Name = "ListOfMoviesLabel";
            this.ListOfMoviesLabel.Size = new System.Drawing.Size(166, 25);
            this.ListOfMoviesLabel.TabIndex = 51;
            this.ListOfMoviesLabel.Text = "List of Movies:";
            this.ListOfMoviesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 20;
            this.MoviesListBox.Location = new System.Drawing.Point(12, 181);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(470, 224);
            this.MoviesListBox.TabIndex = 50;
            this.MoviesListBox.SelectedValueChanged += new System.EventHandler(this.MoviesListBox_SelectedValueChanged);
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(96, 31);
            this.HomeButton.TabIndex = 57;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MovieListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.AddMovieButton);
            this.Controls.Add(this.DeleteMovieButton);
            this.Controls.Add(this.EditMovieButton);
            this.Controls.Add(this.ListOfMoviesLabel);
            this.Controls.Add(this.MoviesListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieListWindow";
            this.Load += new System.EventHandler(this.MovieListWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.Button DeleteMovieButton;
        private System.Windows.Forms.Button EditMovieButton;
        private System.Windows.Forms.Label ListOfMoviesLabel;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Button HomeButton;
    }
}