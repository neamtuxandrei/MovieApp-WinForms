
namespace WindowsFormUI.UIWindows
{
    partial class CustomersListWindow
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
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.ListOfCustomersLabel = new System.Windows.Forms.Label();
            this.EditCustomerButton = new System.Windows.Forms.Button();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.RentalsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 20;
            this.CustomersListBox.Location = new System.Drawing.Point(12, 181);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(470, 224);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedValueChanged += new System.EventHandler(this.CustomersListBox_SelectedValueChanged);
            this.CustomersListBox.DoubleClick += new System.EventHandler(this.CustomersListBox_DoubleClick);
            // 
            // ListOfCustomersLabel
            // 
            this.ListOfCustomersLabel.AutoSize = true;
            this.ListOfCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfCustomersLabel.Location = new System.Drawing.Point(7, 135);
            this.ListOfCustomersLabel.Name = "ListOfCustomersLabel";
            this.ListOfCustomersLabel.Size = new System.Drawing.Size(203, 25);
            this.ListOfCustomersLabel.TabIndex = 14;
            this.ListOfCustomersLabel.Text = "List of Customers:";
            this.ListOfCustomersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditCustomerButton
            // 
            this.EditCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditCustomerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EditCustomerButton.Location = new System.Drawing.Point(528, 239);
            this.EditCustomerButton.Name = "EditCustomerButton";
            this.EditCustomerButton.Size = new System.Drawing.Size(96, 31);
            this.EditCustomerButton.TabIndex = 18;
            this.EditCustomerButton.Text = "Edit";
            this.EditCustomerButton.UseVisualStyleBackColor = false;
            this.EditCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCustomerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteCustomerButton.Location = new System.Drawing.Point(650, 239);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(96, 31);
            this.DeleteCustomerButton.TabIndex = 19;
            this.DeleteCustomerButton.Text = "Delete";
            this.DeleteCustomerButton.UseVisualStyleBackColor = false;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCustomerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddCustomerButton.Location = new System.Drawing.Point(650, 306);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(96, 31);
            this.AddCustomerButton.TabIndex = 20;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = false;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(326, 154);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(156, 21);
            this.SearchTextBox.TabIndex = 48;
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
            this.SearchLabel.TabIndex = 49;
            this.SearchLabel.Text = "Search";
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
            this.HomeButton.TabIndex = 58;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // RentalsButton
            // 
            this.RentalsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RentalsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.RentalsButton.Location = new System.Drawing.Point(528, 306);
            this.RentalsButton.Name = "RentalsButton";
            this.RentalsButton.Size = new System.Drawing.Size(96, 31);
            this.RentalsButton.TabIndex = 59;
            this.RentalsButton.Text = "Rentals";
            this.RentalsButton.UseVisualStyleBackColor = false;
            this.RentalsButton.Click += new System.EventHandler(this.RentalsButton_Click);
            // 
            // CustomersListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RentalsButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.DeleteCustomerButton);
            this.Controls.Add(this.EditCustomerButton);
            this.Controls.Add(this.ListOfCustomersLabel);
            this.Controls.Add(this.CustomersListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomersListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label ListOfCustomersLabel;
        private System.Windows.Forms.Button EditCustomerButton;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button RentalsButton;
    }
}