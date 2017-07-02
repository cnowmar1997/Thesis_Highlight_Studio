using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Thesis_Highlight_Studio
{
    class Provider
    {
        public class Item
        {
            public string WhatToDo { get; set; }
            public string description { get; set; }
            public string time { get; set; }
            public string date { get; set; }
        }
        public List<Item> Notes()
        {
            var list = new List<Item>();
            try
            {
                using (Dbase.Con)
                {
                    Dbase.Con.Close();
                    Dbase.Con.Open();
                    MySqlCommand cmd = new MySqlCommand(@"SELECT Title,description,date,time FROM tbl_task_todo", Dbase.Con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        list.Add(new Item
                        {
                            WhatToDo = dr["Title"].ToString(),
                            description = dr["description"].ToString(),
                            time = dr["time"].ToString(),
                            date = dr["time"].ToString()
                        
                        });
                    }
                }
            }
            catch(Exception ex)
            {
                CMsgBox.Show(ex.Message);
            }
            return list; ;
        }
    }
}
