using System;
using System.IO;
using MySql.Data.MySqlClient;

namespace Thesis_Highlight_Studio
{
    class DB
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

        public static string ConnectionString
        {
            get
            {
                return ConString();
            }
        }

        protected static string defaultConnectionString = "server=localhost; User id=root; password=; database=db_highlight_studio";
        protected static string filepath = AppDomain.CurrentDomain.BaseDirectory.ToString();
        protected static string filename = "db_highlight_studio.ini";
        private static string ConString()
        {
            string file = filepath + filename;
            string ret = string.Empty;

            //create dbserver.cfg if it does not exist
            if (!File.Exists(file))
            {
                CMsgBox.Show(filename + " not found! Creating a new configuration file...");
                using (StreamWriter sw = new StreamWriter(file, false))
                {
                    sw.WriteLine(defaultConnectionString);
                    sw.Close();
                }
            }

            using (Stream filestream = File.Open(file, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(filestream))
                {
                    ret = sr.ReadLine();
                    sr.Close();
                }
                filestream.Close();
            }
            return string.IsNullOrEmpty(ret) ? null : ret;
        }
    }
}
