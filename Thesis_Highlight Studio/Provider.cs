using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;
using Dapper;

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

        #region Tempo Data
         static string filterUserId = "";

         public static string filter_ID
         {
             get { return filterUserId; }
             set { filterUserId = value; }
         }
        #endregion

         #region filteringMethod
         public List<User> retrieveUser(string userId)
         {
             var list = new List<User>();
             string query = @"SELECT * from tblUser WHERE userId = '"+userId+"';";

             using (IDbConnection con = DB.Con)
             {
                 if(con.State == ConnectionState.Closed)con.Open();
                 list = con.Query<User>(query, commandType: CommandType.Text).ToList();

             }
             return list;
         }
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

        
        #region tbl_User CUSTOMER      
        public List<User> viewClient()
        {
            var list = new List<User>();
            string query = "SELECT userId,familyName,givenName,middleName,nameOfSchool,courseTitle,mobileNumber,landline,emailAdd FROM tbluser";

            using (IDbConnection con =  DB.Con)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                list = con.Query<User>(query, commandType: CommandType.Text).ToList();
            }
            return list;
        }

        public bool insertClient(string typeOfUser, string userName, string passWord, string familyName, string givenName, string middleName, string nameOfSchool, string courseTitle, string mobileNumber, string landline, string emailAdd)
        {
            bool ret = false;            
            string query = "INSERT INTO tblUser(typeOfUser,userName,passWord,familyName,givenName,middleName,nameOfSchool,courseTitle,mobileNumber,landline,emailAdd) VALUES (@typeOfUser,@userName,@passWord,@familyName,@givenName,@middleName,@nameOfSchool,@courseTitle,@mobileNumber,@landline,@emailAdd)";

            using (DB.Con)
            {
                DB.Con.Close();
                DB.Con.Open();
                MySqlCommand command = new MySqlCommand(query, DB.Con);
                command.Parameters.AddWithValue(@"typeOfUser",typeOfUser);
                command.Parameters.AddWithValue(@"userName", userName);
                command.Parameters.AddWithValue(@"passWord", passWord);
                command.Parameters.AddWithValue(@"familyName", familyName);
                command.Parameters.AddWithValue(@"givenName", givenName);
                command.Parameters.AddWithValue(@"middleName", middleName);
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



        public bool updateClient( string userName, string passWord, string familyName, string givenName, string middleName, string nameOfSchool, string courseTitle, string mobileNumber, string landline, string emailAdd, string userId)
        {
            bool ret = false;
            string query = "UPDATE tblUser SET userName=@userName,passWord=@passWord,familyName=@familyName,givenName=@givenName,middleName=@middleName,nameOfSchool=@nameOfSchool,courseTitle=@courseTitle,mobileNumber=@mobileNumber,landline=@landline,emailAdd=@emailAdd WHERE userId = '"+userId+"' ";

            using (DB.Con)
            {
                DB.Con.Close();
                DB.Con.Open();
                MySqlCommand command = new MySqlCommand(query, DB.Con);

                command.Parameters.AddWithValue(@"userName", userName);
                command.Parameters.AddWithValue(@"passWord", passWord);
                command.Parameters.AddWithValue(@"familyName", familyName);
                command.Parameters.AddWithValue(@"givenName", givenName);
                command.Parameters.AddWithValue(@"middleName", middleName);
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

        #region tbl_User STAFF
        public bool viewStaff(ListView listviewStaff)
        {
            bool ret = false;

            using (DB.Con)
            {
                DB.Con.Close();
                DB.Con.Open();
                MySqlCommand cmd = new MySqlCommand(@"SELECT familyName,givenName,middleName,address,mobileNumber,emailAdd FROM tbluser", DB.Con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["familyName"] + ", " + reader["givenName"] + " " + reader["middleName"] + "");
                    item.SubItems.Add(reader["address"] + "");
                    item.SubItems.Add(reader["mobileNumber"] + "");
                    item.SubItems.Add(reader["emailAdd"] + "");
                    listviewStaff.Items.Add(item);
                }
            }
            return ret;
        }

        public bool insertStaff(string typeOfUser, string userName, string passWord, string familyName, string givenName, string middleName, string address, string mobileNumber, string landline, string emailAdd)
        {
            bool ret = false;
            string query = "INSERT INTO tblUser(typeOfUser,userName,passWord,familyname,givenName,middleName,address,mobileNumber,landline,emailAdd) VALUES (@typeOfUser,@userName,@passWord,@familyName,@givenName,@middleName,@address,@mobileNumber,@landline,@emailAdd)";

            using (DB.Con)
            {
                DB.Con.Close();
                DB.Con.Open();
                MySqlCommand command = new MySqlCommand(query, DB.Con);
                command.Parameters.AddWithValue(@"typeOfUser", typeOfUser);
                command.Parameters.AddWithValue(@"userName", userName);
                command.Parameters.AddWithValue(@"passWord", passWord);
                command.Parameters.AddWithValue(@"familyName", familyName);
                command.Parameters.AddWithValue(@"givenName", givenName);
                command.Parameters.AddWithValue(@"middleName", middleName);
                command.Parameters.AddWithValue(@"address", address);
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

        public bool updateStaff(string typeOfUser, string userName, string passWord, string familyName, string givenName, string middleName, string address, string mobileNumber, string landline, string emailAdd)
        {
            bool ret = false;
            string query = "UPDATE tblUser SET typeOfUser=@typeOfUser=@typeOfUser,userName=@userName,passWord=@passWord,familyname=@familyName,givenName=@givenName,middleName=@middleName,address=@address,mobileNumber=@mobileNumber,landline=@landline,emailAdd=@emailAdd";

            using (DB.Con)
            {
                DB.Con.Close();
                DB.Con.Open();
                MySqlCommand command = new MySqlCommand(query, DB.Con);
                command.Parameters.AddWithValue(@"typeOfUser", typeOfUser);
                command.Parameters.AddWithValue(@"userName", userName);
                command.Parameters.AddWithValue(@"passWord", passWord);
                command.Parameters.AddWithValue(@"familyName", familyName);
                command.Parameters.AddWithValue(@"givenName", givenName);
                command.Parameters.AddWithValue(@"middleName", middleName);
                command.Parameters.AddWithValue(@"address", address);
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

        #region tblItem
        public bool insertItem(string itemName, string itemDescription, string itemPrice)
        {
            bool ret = false;
            string query = "INSERT INTO tblItem(itemName,itemDescription,itemPrice) VALUES (@itemName,@itemDescription,@itemPrice)";

            using (DB.Con)
            {
                DB.Con.Close();
                DB.Con.Open();
                MySqlCommand command = new MySqlCommand(query, DB.Con);
                command.Parameters.AddWithValue(@"itemName",itemName);
                command.Parameters.AddWithValue(@"itemDescription", itemDescription);
                command.Parameters.AddWithValue(@"itemPrice", itemPrice);

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
