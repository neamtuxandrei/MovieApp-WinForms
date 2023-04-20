
namespace WindowsFormUI.UIWindows.Movie
{
    partial class MovieRegisterWindow
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
            this.LogInButton = new System.Windows.Forms.Button();
            this.MoviesWindowButton = new System.Windows.Forms.Button();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.ProducerInput = new System.Windows.Forms.TextBox();
            this.ProductionYearInput = new System.Windows.Forms.TextBox();
            this.DurationInput = new System.Windows.Forms.TextBox();
            this.GenreListBox = new System.Windows.Forms.CheckedListBox();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ProducerLabel = new System.Windows.Forms.Label();
            this.ProductionYear = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LogInButton.Location = new System.Drawing.Point(12, 12);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(96, 31);
            this.LogInButton.TabIndex = 31;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // MoviesWindowButton
            // 
            this.MoviesWindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesWindowButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MoviesWindowButton.Location = new System.Drawing.Point(12, 57);
            this.MoviesWindowButton.Name = "MoviesWindowButton";
            this.MoviesWindowButton.Size = new System.Drawing.Size(96, 31);
            this.MoviesWindowButton.TabIndex = 32;
            this.MoviesWindowButton.Text = "Movies";
            this.MoviesWindowButton.UseVisualStyleBackColor = false;
            this.MoviesWindowButton.Click += new System.EventHandler(this.MoviesWindowButton_Click);
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieLabel.Location = new System.Drawing.Point(125, 98);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(170, 25);
            this.MovieLabel.TabIndex = 37;
            this.MovieLabel.Text = "Register Movie";
            this.MovieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleInput
            // 
            this.TitleInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleInput.Location = new System.Drawing.Point(130, 157);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(232, 20);
            this.TitleInput.TabIndex = 38;
            // 
            // ProducerInput
            // 
            this.ProducerInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProducerInput.Location = new System.Drawing.Point(130, 212);
            this.ProducerInput.Name = "ProducerInput";
            this.ProducerInput.Size = new System.Drawing.Size(232, 20);
            this.ProducerInput.TabIndex = 39;
            // 
            // ProductionYearInput
            // 
            this.ProductionYearInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductionYearInput.Location = new System.Drawing.Point(130, 266);
            this.ProductionYearInput.Name = "ProductionYearInput";
            this.ProductionYearInput.Size = new System.Drawing.Size(232, 20);
            this.ProductionYearInput.TabIndex = 40;
            // 
            // DurationInput
            // 
            this.DurationInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationInput.Location = new System.Drawing.Point(130, 320);
            this.DurationInput.Name = "DurationInput";
            this.DurationInput.Size = new System.Drawing.Size(232, 20);
            this.DurationInput.TabIndex = 41;
            // 
            // GenreListBox
            // 
            this.GenreListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreListBox.FormattingEnabled = true;
            this.GenreListBox.Location = new System.Drawing.Point(130, 346);
            this.GenreListBox.Name = "GenreListBox";
            this.GenreListBox.Size = new System.Drawing.Size(120, 94);
            this.GenreListBox.TabIndex = 42;
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMovieButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddMovieButton.Location = new System.Drawing.Point(266, 368);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(96, 31);
            this.AddMovieButton.TabIndex = 43;
            this.AddMovieButton.Text = "Add";
            this.AddMovieButton.UseVisualStyleBackColor = false;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(127, 138);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(34, 16);
            this.TitleLabel.TabIndex = 44;
            this.TitleLabel.Text = "Title";
            // 
            // ProducerLabel
            // 
            this.ProducerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProducerLabel.AutoSize = true;
            this.ProducerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProducerLabel.Location = new System.Drawing.Point(127, 193);
            this.ProducerLabel.Name = "ProducerLabel";
            this.ProducerLabel.Size = new System.Drawing.Size(66, 16);
            this.ProducerLabel.TabIndex = 45;
            this.ProducerLabel.Text = "Producer ";
            // 
            // ProductionYear
            // 
            this.ProductionYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductionYear.AutoSize = true;
            this.ProductionYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductionYear.Location = new System.Drawing.Point(127, 247);
            this.ProductionYear.Name = "ProductionYear";
            this.ProductionYear.Size = new System.Drawing.Size(104, 16);
            this.ProductionYear.TabIndex = 46;
            this.ProductionYear.Text = "Production Year";
            // 
            // DurationLabel
            // 
            this.DurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.Location = new System.Drawing.Point(127, 301);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(58, 16);
            this.DurationLabel.TabIndex = 47;
            this.DurationLabel.Text = "Duration";
            // 
            // MovieRegisterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 461);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.ProductionYear);
            this.Controls.Add(this.ProducerLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AddMovieButton);
            this.Controls.Add(this.GenreListBox);
            this.Controls.Add(this.DurationInput);
            this.Controls.Add(this.ProductionYearInput);
            this.Controls.Add(this.ProducerInput);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.MoviesWindowButton);
            this.Controls.Add(this.LogInButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieRegisterWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button MoviesWindowButton;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.TextBox ProducerInput;
        private System.Windows.Forms.TextBox ProductionYearInput;
        private System.Windows.Forms.TextBox DurationInput;
        private System.Windows.Forms.CheckedListBox GenreListBox;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ProducerLabel;
        private System.Windows.Forms.Label ProductionYear;
        private System.Windows.Forms.Label DurationLabel;
    }
}