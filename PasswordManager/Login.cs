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
using System.Security.Cryptography;

namespace PasswordManager
{
    public partial class Login : Form
    {
        private const string MpasswordHint = "password";
        bool account_exists; 
        string enteredPassword;
        
        public Login()
        {
            InitializeComponent();
         
            InitializeHints();

            UserExists();
        }

        public void ReadEnteredPassword()
        {
            enteredPassword = HashPassword(MpasswordTB.Text); // enteredPassword is hashed text entered in 'password' tb
            Console.WriteLine(enteredPassword);
            //System.Console.WriteLine("DEBUG: user entered " + enteredPassword);
        }


        // password hashing

           
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes); // Convert hash to string representation
            }
        }

        public void UserExists()
        {
            var passwordlist = SqliteDataAccess.LoadMasterPassword();

            account_exists = passwordlist.Count > 0; //account does exist

            if (account_exists)
            {
                System.Console.WriteLine("DEBUG: An account already exists on this device."); // make into a popup window
                createAccountButton.Enabled = false;
                createAccountLabel.Enabled = true;
            }
            else
            {
                loginButton.Enabled = false;
                createAccountLabel.Enabled = false;
            }
        }

        public void LoginMethod()
        {

            ReadEnteredPassword();

            var masterpasswordlist = SqliteDataAccess.LoadMasterPassword();

            if (masterpasswordlist[0].MasterPassword == enteredPassword)
            {
                this.Visible = false; // hide login window

                //open Dashboard form
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Entered password and master password do not match. Please try again.");
                System.Console.WriteLine("DEBUG: entered password and master password do not match");
            }
        }

        public void RegisterMethod()
        {          
                ReadEnteredPassword();

                MasterPasswordModel MasterPassword = new MasterPasswordModel
                {
                    MasterPassword = enteredPassword
                };

                SqliteDataAccess.SaveMasterPassword(MasterPassword);

                account_exists = true;

                Dashboard dashboardForm = new Dashboard();
                dashboardForm.ShowDialog();
        }

        //public bool UserExists()
        //{
            //if (MasterPassword == null) 
           // { 
                //return false;
            //}
            //return true;
        //}

        // --------------------------------------------- CLICK EVENTS --------------------------------------------- //

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginMethod();
        }

        private void createAccountButton_Click(object sender, EventArgs e) // placeholder
        {
            RegisterMethod();

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


