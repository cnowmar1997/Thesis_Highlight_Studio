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
        #region Getters and Setters
        static string filterFullName = "";



        #endregion
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

        #region tbl_User
        public bool viewClient(ListView listviewClient)
        {
            bool ret = false;

            using (DB.Con)
            {
                DB.Con.Close();
                DB.Con.Open();
                MySqlCommand cmd = new MySqlCommand(@"SELECT fullName, nameOfSchool, courseTitle, mobileNumber, landline, emailAdd FROM tbluser", DB.Con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["fullName"] + "");
                    item.SubItems.Add(reader["nameOfSchool"] + "");
                    item.SubItems.Add(reader["courseTitle"] + "");
                    item.SubItems.Add(reader["mobileNumber"] + "");
                    item.SubItems.Add(reader["landline"] + "");
                    item.SubItems.Add(reader["emailAdd"] + "");
                    listviewClient.Items.Add(item);
                }
            }
            return ret;
        }

        public bool insertClient(string typeOfUser, string userName, string passWord, string fullName, string nameOfSchool, string courseTitle, string mobileNumber, string landline, string emailAdd)
        {
            bool ret = false;            
            string query = "INSERT INTO tblUser(typeOfUser,userName,passWord,fullName,nameOfSchool,courseTitle,mobileNumber,landline,emailAdd) VALUES (@typeOfUser,@userName,@passWord,@fullName,@nameOfSchool,@courseTitle,@mobileNumber,@landline,@emailAdd)";

            using (DB.Con)
            {
                DB.Con.Close();
                DB.Con.Open();
                MySqlCommand command = new MySqlCommand(query, DB.Con);
                command.Parameters.AddWithValue(@"typeOfUser",typeOfUser);
                command.Parameters.AddWithValue(@"userName", userName);
                command.Parameters.AddWithValue(@"passWord", passWord);
                command.Parameters.AddWithValue(@"fullName",fullName);
                command.Parameters.AddWithValue(@"nameOfSchool",nameOfSchool);
                command.Parameters.AddWithValue(@"courseTitle",courseTitle);
                command.Parameters.AddWithValue(@"mobileNumber",mobileNumber);
                command.Parameters.AddWithValue(@"landline",landline);
                command.Parameters.AddWithValue(@"emailAdd",emailAdd);

                if (command.ExecuteNonQuery() > 0)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public bool updateClient( string userName, string passWord, string fullName, string nameOfSchool, string courseTitle, string mobileNumber, string landline, string emailAdd)
        {
            bool ret = false;
            string query = "UPDATE tblUser SET userName=@userName,passWord=@passWord,fullName=@fullName,nameOfSchool=@nameOfSchool,courseTitle=@courseTitle,mobileNumber=@mobileNumber,landline=@landline,emailAdd=@emailAdd WHERE ";

            using (DB.Con)
            {
                DB.Con.Close();
                DB.Con.Open();
                MySqlCommand command = new MySqlCommand(query, DB.Con);

                command.Parameters.AddWithValue(@"userName", userName);
                command.Parameters.AddWithValue(@"passWord", passWord);
                command.Parameters.AddWithValue(@"fullName", fullName);
                command.Parameters.AddWithValue(@"nameOfSchool", nameOfSchool);
                command.Parameters.AddWithValue(@"courseTitle", courseTitle);
                command.Parameters.AddWithValue(@"mobileNumber", mobileNumber);
                command.Parameters.AddWithValue(@"landline", landline);
                command.Parameters.AddWithValue(@"emailAdd", emailAdd);

                if (command.ExecuteNonQuery() > 0)
                {
                    ret = true;
                }
            }
            return ret;
        }
        #endregion

    }
}
