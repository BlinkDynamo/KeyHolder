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

        /* constructor */
        public Dashboard()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle; // disable resizing

            this.FormClosing += new FormClosingEventHandler(Dashboard_FormClosing); // close application when form is closed

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

        // adds entry to database from input in ID, Username, and Password
        private void addEntryB_Click(object sender, EventArgs e)
        {
            EntryModel entry = new EntryModel
            {
                ID = idTB.Text,
                Username = usernameTB.Text,
                Password = passwordTB.Text
            };

            System.Console.WriteLine("DEBUG: entry information (EntryModel entry) attempting to be saved is " + entry.ID + " " + entry.Username + " " + entry.Password); // DEBUG

            // content to database here
            SqliteDataAccess.SaveEntry(entry);
            
            ClearTextBoxes();

            LoadEntryList(); // refreshes entries after adding a new entry to display in list box
        } 

        private void refreshB_Click(object sender, EventArgs e)
        {
            // Refreshes list box. Mostly redundant as currently there are no actions that change data and also do not refresh the list box as well.
            LoadEntryList();
        } 

        private void removeEntryB_Click(object sender, EventArgs e)
        {
            if (entriesLB.SelectedIndex != -1) // if an item is selected
            {
                System.Console.WriteLine("DEBUG: entry to be removed is " + entriesLB.SelectedIndex.ToString()); // DEBUG

                // Retrieve the selected entry
                EntryModel selectedEntry = (EntryModel)entriesLB.SelectedItem;

                // Remove the entry from the ListBox
                entries.Remove(selectedEntry);

                // Remove the entry from the database
                SqliteDataAccess.DeleteEntry(selectedEntry); 

                WireUpEntryList();
            }
        } // Removes a selected entry from the list box and the database.

        private void clearEntryB_Click(object sender, EventArgs e)
        {
            // Clears textboxes of text in entry section.
            idTB.Text = "";
            usernameTB.Text = "";
            passwordTB.Text = "";

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the application when form is closed
            Application.Exit();
        }
    }
}

