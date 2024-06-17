using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyHolder
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

        public static List<MasterPasswordModel> LoadMasterPassword()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<MasterPasswordModel>("select * from MasterPassword", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveMasterPassword(MasterPasswordModel MasterPassword)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var debug = cnn.Execute("insert into MasterPassword (MasterPassword) values (@MasterPassword)", MasterPassword);

                if (debug < 1)
                {
                    Console.WriteLine("SaveMasterPassword failed to write to database with value " + debug);
                }
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
