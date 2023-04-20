
namespace WindowsFormUI.UIWindows.Movie
{
    partial class MovieEditWindow
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
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.ProducerInput = new System.Windows.Forms.TextBox();
            this.ProductionYearInput = new System.Windows.Forms.TextBox();
            this.DurationInput = new System.Windows.Forms.TextBox();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ProducerLabel = new System.Windows.Forms.Label();
            this.ProductionYear = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.GenreListBox = new System.Windows.Forms.CheckedListBox();
            this.LockUnlockInfo = new System.Windows.Forms.Button();
            this.SaveMovieButton = new System.Windows.Forms.Button();
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
            this.LogInButton.TabIndex = 30;
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
            this.MoviesWindowButton.TabIndex = 31;
            this.MoviesWindowButton.Text = "Movies";
            this.MoviesWindowButton.UseVisualStyleBackColor = false;
            this.MoviesWindowButton.Click += new System.EventHandler(this.MoviesWindowButton_Click);
            // 
            // TitleInput
            // 
            this.TitleInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleInput.Enabled = false;
            this.TitleInput.Location = new System.Drawing.Point(130, 157);
            this.TitleInput.MaxLength = 100;
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(232, 20);
            this.TitleInput.TabIndex = 32;
            // 
            // ProducerInput
            // 
            this.ProducerInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProducerInput.Enabled = false;
            this.ProducerInput.Location = new System.Drawing.Point(130, 212);
            this.ProducerInput.MaxLength = 100;
            this.ProducerInput.Name = "ProducerInput";
            this.ProducerInput.Size = new System.Drawing.Size(232, 20);
            this.ProducerInput.TabIndex = 33;
            // 
            // ProductionYearInput
            // 
            this.ProductionYearInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductionYearInput.Enabled = false;
            this.ProductionYearInput.Location = new System.Drawing.Point(130, 266);
            this.ProductionYearInput.MaxLength = 4;
            this.ProductionYearInput.Name = "ProductionYearInput";
            this.ProductionYearInput.Size = new System.Drawing.Size(232, 20);
            this.ProductionYearInput.TabIndex = 34;
            // 
            // DurationInput
            // 
            this.DurationInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationInput.Enabled = false;
            this.DurationInput.Location = new System.Drawing.Point(130, 320);
            this.DurationInput.MaxLength = 50;
            this.DurationInput.Name = "DurationInput";
            this.DurationInput.Size = new System.Drawing.Size(232, 20);
            this.DurationInput.TabIndex = 35;
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieLabel.Location = new System.Drawing.Point(125, 98);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(121, 25);
            this.MovieLabel.TabIndex = 36;
            this.MovieLabel.Text = "Movie Info";
            this.MovieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.TitleLabel.TabIndex = 37;
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
            this.ProducerLabel.TabIndex = 38;
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
            this.ProductionYear.TabIndex = 39;
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
            this.DurationLabel.TabIndex = 40;
            this.DurationLabel.Text = "Duration";
            // 
            // GenreListBox
            // 
            this.GenreListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreListBox.FormattingEnabled = true;
            this.GenreListBox.Location = new System.Drawing.Point(130, 347);
            this.GenreListBox.Name = "GenreListBox";
            this.GenreListBox.Size = new System.Drawing.Size(120, 94);
            this.GenreListBox.TabIndex = 41;
            // 
            // LockUnlockInfo
            // 
            this.LockUnlockInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LockUnlockInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LockUnlockInfo.Location = new System.Drawing.Point(266, 362);
            this.LockUnlockInfo.Name = "LockUnlockInfo";
            this.LockUnlockInfo.Size = new System.Drawing.Size(96, 31);
            this.LockUnlockInfo.TabIndex = 42;
            this.LockUnlockInfo.Text = "Lock/Unlock";
            this.LockUnlockInfo.UseVisualStyleBackColor = false;
            this.LockUnlockInfo.Click += new System.EventHandler(this.LockUnlockInfo_Click);
            // 
            // SaveMovieButton
            // 
            this.SaveMovieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveMovieButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveMovieButton.Location = new System.Drawing.Point(266, 410);
            this.SaveMovieButton.Name = "SaveMovieButton";
            this.SaveMovieButton.Size = new System.Drawing.Size(96, 31);
            this.SaveMovieButton.TabIndex = 43;
            this.SaveMovieButton.Text = "Save Changes";
            this.SaveMovieButton.UseVisualStyleBackColor = false;
            this.SaveMovieButton.Click += new System.EventHandler(this.SaveMovieButton_Click);
            // 
            // MovieEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 461);
            this.Controls.Add(this.SaveMovieButton);
            this.Controls.Add(this.LockUnlockInfo);
            this.Controls.Add(this.GenreListBox);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.ProductionYear);
            this.Controls.Add(this.ProducerLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.DurationInput);
            this.Controls.Add(this.ProductionYearInput);
            this.Controls.Add(this.ProducerInput);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.MoviesWindowButton);
            this.Controls.Add(this.LogInButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieEditWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Movie";
            this.Load += new System.EventHandler(this.MovieEditWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button MoviesWindowButton;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.TextBox ProducerInput;
        private System.Windows.Forms.TextBox ProductionYearInput;
        private System.Windows.Forms.TextBox DurationInput;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ProducerLabel;
        private System.Windows.Forms.Label ProductionYear;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.CheckedListBox GenreListBox;
        private System.Windows.Forms.Button LockUnlockInfo;
        private System.Windows.Forms.Button SaveMovieButton;
    }
}