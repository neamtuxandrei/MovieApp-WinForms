
namespace WindowsFormUI.UIWindows.Customer
{
    partial class CustomerAddRentalWindow
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
            this.BackButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.ListOfMoviesLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.RentDateTime = new System.Windows.Forms.DateTimePicker();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.AddRentalButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(96, 31);
            this.BackButton.TabIndex = 60;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CustomersButton.Location = new System.Drawing.Point(12, 59);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(96, 31);
            this.CustomersButton.TabIndex = 61;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = false;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
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
            this.MoviesListBox.TabIndex = 62;
            this.MoviesListBox.SelectedValueChanged += new System.EventHandler(this.MoviesListBox_SelectedValueChanged);
            // 
            // ListOfMoviesLabel
            // 
            this.ListOfMoviesLabel.AutoSize = true;
            this.ListOfMoviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfMoviesLabel.Location = new System.Drawing.Point(7, 135);
            this.ListOfMoviesLabel.Name = "ListOfMoviesLabel";
            this.ListOfMoviesLabel.Size = new System.Drawing.Size(166, 25);
            this.ListOfMoviesLabel.TabIndex = 63;
            this.ListOfMoviesLabel.Text = "List of Movies:";
            this.ListOfMoviesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(326, 154);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(156, 21);
            this.SearchTextBox.TabIndex = 64;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
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
            this.SearchLabel.TabIndex = 65;
            this.SearchLabel.Text = "Search";
            // 
            // RentDateTime
            // 
            this.RentDateTime.CustomFormat = "dd.MM.yyyy hh.mm";
            this.RentDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RentDateTime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.RentDateTime.Location = new System.Drawing.Point(541, 283);
            this.RentDateTime.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.RentDateTime.MinDate = new System.DateTime(2022, 9, 4, 0, 0, 0, 0);
            this.RentDateTime.Name = "RentDateTime";
            this.RentDateTime.Size = new System.Drawing.Size(200, 20);
            this.RentDateTime.TabIndex = 66;
            this.RentDateTime.Value = new System.DateTime(2022, 9, 4, 0, 0, 0, 0);
            // 
            // PriceInput
            // 
            this.PriceInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceInput.Location = new System.Drawing.Point(541, 202);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(200, 20);
            this.PriceInput.TabIndex = 67;
            // 
            // AddRentalButton
            // 
            this.AddRentalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRentalButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddRentalButton.Location = new System.Drawing.Point(645, 374);
            this.AddRentalButton.Name = "AddRentalButton";
            this.AddRentalButton.Size = new System.Drawing.Size(96, 31);
            this.AddRentalButton.TabIndex = 68;
            this.AddRentalButton.Text = "Add Rental";
            this.AddRentalButton.UseVisualStyleBackColor = false;
            this.AddRentalButton.Click += new System.EventHandler(this.AddRentalButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(538, 183);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(66, 16);
            this.FirstNameLabel.TabIndex = 69;
            this.FirstNameLabel.Text = "Price(LEI)";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Rent Date";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(321, 65);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(0, 25);
            this.CustomerName.TabIndex = 71;
            this.CustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerAddRentalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.AddRentalButton);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this.RentDateTime);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ListOfMoviesLabel);
            this.Controls.Add(this.MoviesListBox);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.BackButton);
            this.Name = "CustomerAddRentalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerAddRentalMovie";
            this.Load += new System.EventHandler(this.CustomerAddRentalMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Label ListOfMoviesLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.DateTimePicker RentDateTime;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.Button AddRentalButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomerName;
    }
}