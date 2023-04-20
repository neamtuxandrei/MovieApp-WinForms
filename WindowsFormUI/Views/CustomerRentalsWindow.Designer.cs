
namespace WindowsFormUI.UIWindows.Customer
{
    partial class CustomerRentalsWindow
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
            this.HomeButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.RentalsListBox = new System.Windows.Forms.ListBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ListOfRentalsLabel = new System.Windows.Forms.Label();
            this.AddRentalButton = new System.Windows.Forms.Button();
            this.DeleteRentalButton = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.HomeButton.TabIndex = 59;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CustomersButton.Location = new System.Drawing.Point(12, 58);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(96, 31);
            this.CustomersButton.TabIndex = 60;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = false;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // RentalsListBox
            // 
            this.RentalsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RentalsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalsListBox.FormattingEnabled = true;
            this.RentalsListBox.ItemHeight = 20;
            this.RentalsListBox.Location = new System.Drawing.Point(12, 181);
            this.RentalsListBox.Name = "RentalsListBox";
            this.RentalsListBox.Size = new System.Drawing.Size(470, 224);
            this.RentalsListBox.TabIndex = 61;
            this.RentalsListBox.SelectedValueChanged += new System.EventHandler(this.RentalsListBox_SelectedValueChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(326, 154);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(156, 21);
            this.SearchTextBox.TabIndex = 62;
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
            this.SearchLabel.TabIndex = 63;
            this.SearchLabel.Text = "Search";
            // 
            // ListOfRentalsLabel
            // 
            this.ListOfRentalsLabel.AutoSize = true;
            this.ListOfRentalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfRentalsLabel.Location = new System.Drawing.Point(7, 135);
            this.ListOfRentalsLabel.Name = "ListOfRentalsLabel";
            this.ListOfRentalsLabel.Size = new System.Drawing.Size(99, 25);
            this.ListOfRentalsLabel.TabIndex = 64;
            this.ListOfRentalsLabel.Text = "Rentals:";
            this.ListOfRentalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddRentalButton
            // 
            this.AddRentalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRentalButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddRentalButton.Location = new System.Drawing.Point(650, 306);
            this.AddRentalButton.Name = "AddRentalButton";
            this.AddRentalButton.Size = new System.Drawing.Size(96, 31);
            this.AddRentalButton.TabIndex = 65;
            this.AddRentalButton.Text = "Add Rental";
            this.AddRentalButton.UseVisualStyleBackColor = false;
            this.AddRentalButton.Click += new System.EventHandler(this.AddRentalButton_Click);
            // 
            // DeleteRentalButton
            // 
            this.DeleteRentalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteRentalButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteRentalButton.Location = new System.Drawing.Point(650, 239);
            this.DeleteRentalButton.Name = "DeleteRentalButton";
            this.DeleteRentalButton.Size = new System.Drawing.Size(96, 31);
            this.DeleteRentalButton.TabIndex = 66;
            this.DeleteRentalButton.Text = "Delete";
            this.DeleteRentalButton.UseVisualStyleBackColor = false;
            this.DeleteRentalButton.Click += new System.EventHandler(this.DeleteRentalButton_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(321, 64);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(0, 25);
            this.CustomerName.TabIndex = 72;
            this.CustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerRentalsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.DeleteRentalButton);
            this.Controls.Add(this.AddRentalButton);
            this.Controls.Add(this.ListOfRentalsLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.RentalsListBox);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.HomeButton);
            this.Name = "CustomerRentalsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerRentalWindow";
            this.Load += new System.EventHandler(this.CustomerRentalsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.ListBox RentalsListBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label ListOfRentalsLabel;
        private System.Windows.Forms.Button AddRentalButton;
        private System.Windows.Forms.Button DeleteRentalButton;
        private System.Windows.Forms.Label CustomerName;
    }
}