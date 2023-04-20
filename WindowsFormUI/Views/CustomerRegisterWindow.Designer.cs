
namespace WindowsFormUI
{
    partial class CustomerRegisterWindow
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
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PhoneNrInput = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.CustomersWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(127, 304);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 16);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(130, 323);
            this.EmailInput.MaxLength = 150;
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(232, 20);
            this.EmailInput.TabIndex = 2;
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(125, 98);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(207, 25);
            this.RegisterLabel.TabIndex = 3;
            this.RegisterLabel.Text = "Register Customer";
            this.RegisterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCustomerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddCustomerButton.Location = new System.Drawing.Point(266, 368);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(96, 31);
            this.AddCustomerButton.TabIndex = 7;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = false;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(130, 158);
            this.FirstNameInput.MaxLength = 100;
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(232, 20);
            this.FirstNameInput.TabIndex = 8;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(127, 139);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(73, 16);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(130, 215);
            this.LastNameInput.MaxLength = 100;
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(232, 20);
            this.LastNameInput.TabIndex = 10;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(127, 196);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(73, 16);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "Last Name";
            // 
            // PhoneNrInput
            // 
            this.PhoneNrInput.Location = new System.Drawing.Point(130, 270);
            this.PhoneNrInput.MaxLength = 10;
            this.PhoneNrInput.Name = "PhoneNrInput";
            this.PhoneNrInput.Size = new System.Drawing.Size(232, 20);
            this.PhoneNrInput.TabIndex = 12;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(127, 251);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(98, 16);
            this.PhoneLabel.TabIndex = 13;
            this.PhoneLabel.Text = "Phone Number";
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
            this.HomeButton.TabIndex = 16;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // CustomersWindowButton
            // 
            this.CustomersWindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersWindowButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CustomersWindowButton.Location = new System.Drawing.Point(12, 57);
            this.CustomersWindowButton.Name = "CustomersWindowButton";
            this.CustomersWindowButton.Size = new System.Drawing.Size(96, 31);
            this.CustomersWindowButton.TabIndex = 17;
            this.CustomersWindowButton.Text = "Customers";
            this.CustomersWindowButton.UseVisualStyleBackColor = false;
            this.CustomersWindowButton.Click += new System.EventHandler(this.CustomersWindowButton_Click);
            // 
            // CustomerRegisterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(509, 461);
            this.Controls.Add(this.CustomersWindowButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PhoneNrInput);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.EmailLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerRegisterWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox PhoneNrInput;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button CustomersWindowButton;
    }
}

