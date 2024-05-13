using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
   public class EntryModel
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string FullEntry // only displayed, not ever stored to database
        {
            get
            {
                // fetches the AES key from the Dashboard class, then uses it to decrypt the password and display a full entry in the listbox.
                var key = Dashboard.key;
                return $"[ { ID } ]   { Username } -- { AesOperation.DecryptString(key, Password) }";
            }
        }
    }

    public class MasterPasswordModel
    {
        public string MasterPassword { get; set; }
    }

    public class Notes
    {
        public string NotesText { get; set; }
    }

    public class SettingsModel
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }
}
