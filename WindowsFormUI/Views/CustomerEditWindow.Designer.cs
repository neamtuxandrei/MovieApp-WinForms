
namespace WindowsFormUI.UIWindows
{
    partial class CustomerEditWindow
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
            this.LockUnlockInfo = new System.Windows.Forms.Button();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneNrInput = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.SaveCustomerButton = new System.Windows.Forms.Button();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CustomersWindowButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.LockUnlockInfo.TabIndex = 28;
            this.LockUnlockInfo.Text = "Lock/Unlock";
            this.LockUnlockInfo.UseVisualStyleBackColor = false;
            this.LockUnlockInfo.Click += new System.EventHandler(this.LockUnlockInfo_Click);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(127, 250);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(98, 16);
            this.PhoneLabel.TabIndex = 27;
            this.PhoneLabel.Text = "Phone Number";
            // 
            // PhoneNrInput
            // 
            this.PhoneNrInput.Enabled = false;
            this.PhoneNrInput.Location = new System.Drawing.Point(130, 269);
            this.PhoneNrInput.Name = "PhoneNrInput";
            this.PhoneNrInput.Size = new System.Drawing.Size(232, 20);
            this.PhoneNrInput.TabIndex = 26;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(127, 195);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(73, 16);
            this.LastNameLabel.TabIndex = 25;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameInput
            // 
            this.LastNameInput.Enabled = false;
            this.LastNameInput.Location = new System.Drawing.Point(130, 214);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(232, 20);
            this.LastNameInput.TabIndex = 24;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(127, 138);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(73, 16);
            this.FirstNameLabel.TabIndex = 23;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameInput.Enabled = false;
            this.FirstNameInput.Location = new System.Drawing.Point(130, 157);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(232, 20);
            this.FirstNameInput.TabIndex = 22;
            // 
            // SaveCustomerButton
            // 
            this.SaveCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCustomerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveCustomerButton.Location = new System.Drawing.Point(266, 410);
            this.SaveCustomerButton.Name = "SaveCustomerButton";
            this.SaveCustomerButton.Size = new System.Drawing.Size(96, 31);
            this.SaveCustomerButton.TabIndex = 21;
            this.SaveCustomerButton.Text = "Save Changes";
            this.SaveCustomerButton.UseVisualStyleBackColor = false;
            this.SaveCustomerButton.Click += new System.EventHandler(this.SaveCustomerButton_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(125, 98);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(158, 25);
            this.RegisterLabel.TabIndex = 20;
            this.RegisterLabel.Text = "Customer Info";
            this.RegisterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailInput
            // 
            this.EmailInput.Enabled = false;
            this.EmailInput.Location = new System.Drawing.Point(130, 322);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(232, 20);
            this.EmailInput.TabIndex = 19;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(127, 303);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 16);
            this.EmailLabel.TabIndex = 18;
            this.EmailLabel.Text = "Email";
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
            this.CustomersWindowButton.TabIndex = 30;
            this.CustomersWindowButton.Text = "Customers";
            this.CustomersWindowButton.UseVisualStyleBackColor = false;
            this.CustomersWindowButton.Click += new System.EventHandler(this.CustomersWindowButton_Click);
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
            this.LogInButton.TabIndex = 29;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // CustomerEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 461);
            this.Controls.Add(this.CustomersWindowButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.LockUnlockInfo);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PhoneNrInput);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.SaveCustomerButton);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.EmailLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerEditWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.CustomerEditWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LockUnlockInfo;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneNrInput;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.Button SaveCustomerButton;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button CustomersWindowButton;
        private System.Windows.Forms.Button LogInButton;
    }
}