using KeyHolder;
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

namespace KeyHolder
{
    public partial class Login : Form
    {
        private const string MpasswordHint = "password";
        bool accountExists; 
        string enteredPassword;
        
        public Login()
        {
            InitializeComponent();
         
            FormBorderStyle = FormBorderStyle.FixedSingle; // disable resizing

            InitializeHints();

            UserExists();
        }

        public void ReadEnteredPassword()
        {
            enteredPassword = HashPassword(MpasswordTB.Text); // enteredPassword is hashed text entered in 'password' tb
            Console.WriteLine(enteredPassword);
        }


        // password hashing     
        public string HashPassword(string password)
        {
            SHA256 hash = SHA256.Create();

            var passwordBytes = Encoding.Default.GetBytes(password);

            var hashedPassword = hash.ComputeHash(passwordBytes);

            var hexString = BitConverter.ToString(hashedPassword);

            hexString = hexString.Replace("-", "");

            return hexString;
        }

        public void UserExists()
        {
            var passwordlist = SqliteDataAccess.LoadMasterPassword();

            accountExists = passwordlist.Count > 0; //account does exist

            if (accountExists)
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

                accountExists = true;

                Dashboard dashboardForm = new Dashboard();
                dashboardForm.ShowDialog();
        }

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


