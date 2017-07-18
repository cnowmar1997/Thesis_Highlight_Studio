using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
                using (DB.Con)
                {
                    DB.Con.Close();
                    DB.Con.Open();
                    MySqlCommand cmd = new MySqlCommand(@"SELECT Title,description,date,time FROM tbl_task_todo", DB.Con);
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
            catch (Exception ex)
            {
                CMsgBox.Show(ex.Message);
            }
            return list; ;
        }

        public bool View_Data(ListView Listview_view)
        {
            bool ret = false;

            using (DB.Con)
            {
                DB.Con.Close();
                DB.Con.Open();
                MySqlCommand cmd = new MySqlCommand(@"SELECT `userId`, `fullName`, `nameOfSchool`, `courseTitle`, `mobileNumber`, `landline`, `emailAdd` FROM `tbluser`", DB.Con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["userId"] + "");
                    item.SubItems.Add(reader["fullName"] + "");
                    item.SubItems.Add(reader["nameOfSchool"] + "");
                    item.SubItems.Add(reader["courseTitle"] + "");
                    item.SubItems.Add(reader["mobileNumber"] + "");
                    item.SubItems.Add(reader["landline"] + "");
                    item.SubItems.Add(reader["emailAdd"] + "");
                    Listview_view.Items.Add(item);
                }
            }
            return ret;
        }
    }
}
