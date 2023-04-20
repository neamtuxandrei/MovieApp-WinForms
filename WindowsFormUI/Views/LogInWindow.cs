using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormUI.UIWindows
{
    public partial class LogInWindow : Form
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void LogInBttn_Click(object sender, EventArgs e)
        {
            if (EmailInput.Text == "admin" && PasswordInput.Text == "admin")
            {
                this.Hide();
                AdminHomeWindow adminWindow = new AdminHomeWindow();
                adminWindow.Show();
            }
            else MessageBox.Show("You don't have the permission");


        }

    }
}
