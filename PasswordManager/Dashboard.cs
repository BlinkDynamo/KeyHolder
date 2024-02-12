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
    public partial class Dashboard : Form
    {
        public class UserEntry
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private List<UserEntry> userEntries = new List<UserEntry>();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void enterPasswordB_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text;
            string password = passwordTB.Text;

            userEntries.Add(new UserEntry { Username = username, Password = password });
            MessageBox.Show("User entry added successfully!");

            ClearTextBoxes();
        }

        private void displayEntriesB_Click(object sender, EventArgs e)
        {
            DisplayUserEntries();
        }

        private void DisplayUserEntries()
        {
            entriesLB.Items.Clear();

            foreach (var userEntry in userEntries)
            {
                entriesLB.Items.Add($"Username: {userEntry.Username}, Password: {userEntry.Password}");
            }
        }

        private void ClearTextBoxes()
        {
            usernameTB.Text = "";
            passwordTB.Text = "";
        }
    }
}
