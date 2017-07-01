using System;
using System.IO;
using MySql.Data.MySqlClient;

namespace Thesis_Highlight_Studio
{
    class Dbase
    {
        private static MySqlConnection con;
        public static MySqlConnection Con
        {
            get
            {
                if (con == null)
                {
                    con = new MySqlConnection(ConString());
                    con.Open();
                }
                return con;
            }
        }

        protected static string defaultConnectionString = "server=localhost; User id=root; password=; database=";
        protected static string filepath = AppDomain.CurrentDomain.BaseDirectory.ToString();
        protected static string filename = "dbserver.cfg";
        private static string ConString()
        {
            string file = filepath+filename;
            string ret = null;

            //create dbserver.cfg if it does not exist
            if (!File.Exists(file))
            {
                CMsgBox.Show(filename + " not found! Creating a new configuration file...");
                using (StreamWriter sw = new StreamWriter(file, false))
                {
                    sw.WriteLine();
                    sw.Close();
                }
            }

            using (Stream filestream = File.Open(file, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(filestream))
                {
                    ret = string.IsNullOrEmpty(sr.ReadLine()) ? defaultConnectionString : sr.ReadLine();
                    sr.Close();
                }
                filestream.Close();
            }
            return ret;
        }
    }
}
