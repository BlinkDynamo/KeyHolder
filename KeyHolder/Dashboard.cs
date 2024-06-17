using EncryptionDecryptionUsingSymmetricKey;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyHolder
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

            FormBorderStyle = FormBorderStyle.FixedSingle; // disable resizing

            LoadEntryList();
        }

        public void EncryptEntry()
        {
            var masterpasswordlist = SqliteDataAccess.LoadMasterPassword();

            var key = masterpasswordlist[0].MasterPassword; //hashed master password

            //Console.WriteLine("Please enter a secret key for the symmetric algorithm.");
            //var key = Console.ReadLine();

            var EntryPasswordToEncrypt = passwordTB.Text;
            var EncryptedEntryPassword = AesOperation.EncryptString(key, EntryPasswordToEncrypt);
            Console.WriteLine($"encrypted string = {EncryptedEntryPassword}");

            // var decryptedString = AesOperation.DecryptString(key, encryptedString);
            // Console.WriteLine($"decrypted string = {decryptedString}");

            Console.ReadKey();
        }

        // -------------------------------------------- CLICK EVENTS -------------------------------------------- //


        private void addEntryB_Click(object sender, EventArgs e)
        {
            EntryModel entry = new EntryModel
            {
                ID = idTB.Text,
                Username = usernameTB.Text,
                Password = passwordTB.Text
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

