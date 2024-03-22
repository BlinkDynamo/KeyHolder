using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public class SqliteDataAccess
    {
        public static List<EntryModel> LoadEntry()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<EntryModel>("select * from Entries", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveEntry(EntryModel entry)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Entries (ID, Username, Password) values (@ID, @Username, @Password)", entry);
            }
        }

        public static void DeleteEntry(EntryModel entry)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Entries where ID = @ID", entry);
            }
        }

        private static string LoadConnectionString(string ID = "Default")
        {
            return ConfigurationManager.ConnectionStrings[ID].ConnectionString;
        }
    }

    
}
