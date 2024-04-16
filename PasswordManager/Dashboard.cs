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
        List<EntryModel> entries = new List<EntryModel>();

        private void ClearTextBoxes()
        {
            usernameTB.Text = "";
            passwordTB.Text = "";
            idTB.Text = "";
        }

        private void LoadEntryList()
        {
            entries = SqliteDataAccess.LoadEntry();

            WireUpEntryList();
        }

        private void WireUpEntryList()
        {
            entriesLB.DataSource = null;
            entriesLB.DataSource = entries;
            entriesLB.DisplayMember = "FullEntry";
        }

        public Dashboard()
        {
            InitializeComponent();

            LoadEntryList();
        }

            // var masterpasswordlist = SqliteDataAccess.LoadMasterPassword();

           //  var key = masterpasswordlist[0].MasterPassword; // the key is the hashed master password

           //  var DecryptedEntryPassword = AesOperation.DecryptString(key, encryptedString);

           // Console.WriteLine($"DEBUG: decrypted string = {decryptedString}");
        

        // -------------------------------------------- CLICK EVENTS -------------------------------------------- //


        private void addEntryB_Click(object sender, EventArgs e)
        {
            //encrypts the password entered in the textbox

            var masterpasswordlist = SqliteDataAccess.LoadMasterPassword();

            var key = masterpasswordlist[0].MasterPassword; // the key is the hashed master password

            System.Console.WriteLine("DEBUG: encryption key is " + key); // DEBUG

            var EntryPasswordToEncrypt = passwordTB.Text;
            var EncryptedEntryPassword = AesOperation.EncryptAES(key, EntryPasswordToEncrypt);
            Console.WriteLine($"DEBUG: encrypted string = {EncryptedEntryPassword}");

            //makes an new entry of EntryModel with the encrypted version of the password you entered

            EntryModel entry = new EntryModel
            {
                ID = idTB.Text,
                Username = usernameTB.Text,
                Password = EncryptedEntryPassword.ToString(), // convert from byte array to string
            };
            
            System.Console.WriteLine("DEBUG: entry information (EntryModel entry) attempting to be saved is " + entry.ID + " " + entry.Username + " " + entry.Password); // DEBUG

            SqliteDataAccess.SaveEntry(entry);
            // content to database here

            ClearTextBoxes();

            LoadEntryList(); // refreshes entries after adding a new entry to display in list box
        } // adds entry to database from input in ID, Username, and Password

        private void refreshB_Click(object sender, EventArgs e)
        {
            LoadEntryList();
        } // Refreshes list box. Mostly redundant as currently there are no actions that change data and also do not refresh the list box as well.

        private void removeEntryB_Click(object sender, EventArgs e)
        {
            if (entriesLB.SelectedIndex != -1) // if an item is selected
            {
                 System.Console.WriteLine("DEBUG: entry to be removed is " + entriesLB.SelectedIndex.ToString()); // DEBUG

                // Retrieve the selected entry
                EntryModel selectedEntry = (EntryModel)entriesLB.SelectedItem;
                   
                // Remove the entry from the ListBox
                entries.Remove(selectedEntry);

                // Remove the entry from the SQLite database
                SqliteDataAccess.DeleteEntry(selectedEntry); // Assuming there's a method in SqliteDataAccess to delete an entry by ID

                WireUpEntryList();
            }
        } // Removes a selected entry from the list box and the database.

        private void clearEntryB_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            usernameTB.Text = "";
            passwordTB.Text = "";

        } // Clears textboxes of text in entry section.
    }
}
