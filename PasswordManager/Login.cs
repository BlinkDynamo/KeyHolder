using PasswordManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Login : Form
    {
        private const string MasterPassword = "password"; // I know very creative
        public Login()
        {
            InitializeComponent();
        }
        private void loginB_Click(object sender, EventArgs e)
        {
            string enteredPassword = masterPasswordTB.Text;

            if (enteredPassword == MasterPassword)
            {
                MessageBox.Show("Login successful!");
                OpenDashboard();
            }
            else
            {
                MessageBox.Show("Incorrect master password.");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string enteredPassword = masterPasswordTB.Text;

            if (enteredPassword == MasterPassword)
            {
                MessageBox.Show("Login successful!");
                OpenDashboard();
            }
            else
            {
                MessageBox.Show("Incorrect master password.");
            }
        }

        private void OpenDashboard()
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.ShowDialog();
        }
    }
}


