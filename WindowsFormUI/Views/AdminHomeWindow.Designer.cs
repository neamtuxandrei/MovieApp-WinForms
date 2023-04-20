
namespace WindowsFormUI.UIWindows
{
    partial class AdminHomeWindow
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
            this.MoviesButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.RentalsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoviesButton
            // 
            this.MoviesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MoviesButton.Location = new System.Drawing.Point(194, 165);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.Size = new System.Drawing.Size(96, 31);
            this.MoviesButton.TabIndex = 28;
            this.MoviesButton.Text = "Movies";
            this.MoviesButton.UseVisualStyleBackColor = false;
            this.MoviesButton.Click += new System.EventHandler(this.MoviesButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CustomersButton.Location = new System.Drawing.Point(194, 225);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(96, 31);
            this.CustomersButton.TabIndex = 29;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = false;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
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
            // RentalsButton
            // 
            this.RentalsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RentalsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.RentalsButton.Location = new System.Drawing.Point(194, 284);
            this.RentalsButton.Name = "RentalsButton";
            this.RentalsButton.Size = new System.Drawing.Size(96, 31);
            this.RentalsButton.TabIndex = 31;
            this.RentalsButton.Text = "Rentals";
            this.RentalsButton.UseVisualStyleBackColor = false;
            this.RentalsButton.Click += new System.EventHandler(this.RentalsButton_Click);
            // 
            // AdminHomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 461);
            this.Controls.Add(this.RentalsButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.MoviesButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminHomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHomeWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MoviesButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button RentalsButton;
    }
}