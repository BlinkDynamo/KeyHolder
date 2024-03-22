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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasswordManager
{
    public partial class Login : Form
    {
        private const string MasterPassword = "password"; // placeholder
        private const string MpasswordHint = "password";
        public Login()
        {
            InitializeComponent();
         
            InitializeHints();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string enteredPassword = MpasswordTB.Text;
            System.Console.WriteLine("DEBUG: user entered " + enteredPassword);

            if (enteredPassword == MasterPassword) //placeholder
            {
                System.Console.WriteLine("DEBUG: the entered password was correct");
                OpenDashboard();
            }
            else
            {
                System.Console.WriteLine("DEBUG: the entered password was not correct");
            }
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {

        }

        public void OpenDashboard() 
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.ShowDialog();
        }

        public void OpenLogin()
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }

        public void CloseLogin()
        {
            Login loginForm = new Login();
            loginForm.Close();  
        }

        // ----------------------------- GREYED OUT HINTS FOR PASSWORD AND USERNAME ----------------------------- //

        private void InitializeHints() 
        {
            MpasswordTB.ForeColor = Color.Gray;
            MpasswordTB.Text = MpasswordHint;
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MpasswordTB.Text))
            {
                MpasswordTB.ForeColor = Color.Gray;
                MpasswordTB.Text = MpasswordHint;
            }
        }

        private void MpasswordTB_TextChanged(object sender, EventArgs e)
        {
            if (MpasswordTB.Text != MpasswordHint)
            {
                MpasswordTB.ForeColor = Color.Black;
            }
        }

        private void MpasswordTB_Enter(object sender, EventArgs e)
        {
            if (MpasswordTB.Text == MpasswordHint)
            {
                MpasswordTB.Text = "";
                MpasswordTB.ForeColor = Color.Black;
            }
        }
    }
}


