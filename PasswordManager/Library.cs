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
                var key = Dashboard.key;
                return $"{ ID } { Username } { AesOperation.DecryptString(key, Password) }";
            }
        }
    }

    public class MasterPasswordModel
    {
        public string MasterPassword { get; set; }
    }
}
