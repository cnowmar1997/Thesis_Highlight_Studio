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

        // public List<Item> Notes()
        //{
        //    var list = new List<Item>();
        //    try
        //    {
        //        using (DB.Con)
        //        {
        //            DB.Con.Close();
        //            DB.Con.Open();
        //            MySqlCommand command = new MySqlCommand(@"SELECT Title,description,date,time FROM tbl_task_todo", DB.Con);
        //            MySqlDataReader dr = command.ExecuteReader();
        //            while (dr.Read())
        //            {
        //                list.Add(new Item
        //                {
        //                    WhatToDo = dr["Title"].ToString(),
        //                    description = dr["description"].ToString(),
        //                    time = dr["time"].ToString(),
        //                    date = dr["time"].ToString()

        //                });
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CMsgBox.Show(ex.Message);
        //    }
        //    return list; ;
        //}

        
        #region tbl_User CUSTOMER      
        public List<Client> viewClient()
        {
            var list = new List<Client>();
            string query = "SELECT userId,familyName,givenName,middleName,nameOfSchool,courseTitle,mobileNumber,landline,emailAdd FROM tbluser WHERE status = 'ACTIVE'";

            using (IDbConnection con =  DB.Con)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                list = con.Query<Client>(query, commandType: CommandType.Text).ToList();
            }
            return list;
        }

        public bool addClient(Client clnt)
        {
            try
            {
                string query = "INSERT INTO tblUser(typeOfUser,userName,passWord,familyName,givenName,middleName,nameOfSchool,courseTitle,mobileNumber,landline,emailAdd,status) VALUES (@typeOfUser,@userName,@passWord,@familyName,@givenName,@middleName,@nameOfSchool,@courseTitle,@mobileNumber,@landline,@emailAdd,@status)";



                using (MySqlConnection connect = new MySqlConnection(DB.ConnectionString))
                {
                    if (connect.State == ConnectionState.Closed) connect.Open();
                    using (MySqlCommand command = connect.CreateCommand())
                    {
                        command.CommandText = query;

                        command.Parameters.AddWithValue(@"typeOfUser", clnt.typeOfUser);
                        command.Parameters.AddWithValue(@"userName", clnt.userName);
                        command.Parameters.AddWithValue(@"passWord", clnt.passWord);
                        command.Parameters.AddWithValue(@"familyName", clnt.familyName);
                        command.Parameters.AddWithValue(@"givenName", clnt.givenName);
                        command.Parameters.AddWithValue(@"middleName", clnt.middleName);
                        command.Parameters.AddWithValue(@"nameOfSchool", clnt.nameOfSchool);
                        command.Parameters.AddWithValue(@"courseTitle", clnt.courseTitle);
                        command.Parameters.AddWithValue(@"mobileNumber", clnt.mobileNumber);
                        command.Parameters.AddWithValue(@"landline", clnt.landline);
                        command.Parameters.AddWithValue(@"emailAdd", clnt.emailAdd);
                        command.Parameters.AddWithValue(@"status", clnt.status);


                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public Client getClient(int userId)
        {
            Client clnt = new Client();
            string query = @"SELECT * from tblUser WHERE userId = '" + userId + "';";

            using (MySqlConnection connect = new MySqlConnection(DB.ConnectionString))
            {
                if (connect.State == ConnectionState.Closed) connect.Open();
                using (MySqlCommand command = connect.CreateCommand())
                {
                    command.Connection = connect;
                    command.CommandText = query;
                    command.Parameters.AddWithValue(@"userId", userId);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        clnt.userId = reader.GetInt32(0);
                        clnt.userName = reader.GetString(1).ToString();
                        clnt.passWord = reader.GetString(2).ToString();
                        clnt.familyName = reader.GetString(4).ToString();
                        clnt.givenName = reader.GetString(5).ToString();
                        clnt.middleName = reader.GetString(6).ToString();
                        clnt.nameOfSchool = reader.GetString(8).ToString();
                        clnt.courseTitle = reader.GetString(9).ToString();
                        clnt.mobileNumber = reader.GetString(10).ToString();
                        clnt.landline = reader.GetString(11).ToString();
                        clnt.emailAdd = reader.GetString(12).ToString();
                    }

                }


            }
            return clnt;

        }

        public bool updateClient(string query)
        {            
            bool ret = false;

            using (MySqlConnection connect = new MySqlConnection(DB.ConnectionString))
            {
                if (connect.State == ConnectionState.Closed) connect.Open();
                using (MySqlCommand command = connect.CreateCommand())
                {
                    command.CommandText = query;
                    if (command.ExecuteNonQuery() > 0)
                        ret = true;
                }
                return ret;
            }
        }

        public bool deleteClient(int userId, string status)
        {
            bool ret = false;
            string query = "UPDATE tblUser SET status = '"+status+"' WHERE userId = '"+userId+"' ";

            using (MySqlConnection connect = new MySqlConnection(DB.ConnectionString))
            {
                if (connect.State == ConnectionState.Closed) connect.Open();
                using (MySqlCommand command = connect.CreateCommand())
                {
                    command.CommandText = query;

                    command.ExecuteNonQuery();
                    return ret;
                }
            }
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
                MySqlCommand command = new MySqlCommand(@"SELECT familyName,givenName,middleName,address,mobileNumber,emailAdd FROM tbluser", DB.Con);
                MySqlDataReader reader = command.ExecuteReader();
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
        public List<Itemlist> viewItem()
        {
            var list = new List<Itemlist>();
            string query = "SELECT itemId,name,description,price FROM tblItem";

            using (IDbConnection con = DB.Con)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                list = con.Query<Itemlist>(query, commandType: CommandType.Text).ToList();
            }
            return list;
        }

        public bool insertItem(string name, string description, string price)
        {
            bool ret = false;
            string query = "INSERT INTO tblItem(name,description,price) VALUES (@name,@description,@price)";

            using (DB.Con)
            {
                DB.Con.Close();
                DB.Con.Open();
                MySqlCommand command = new MySqlCommand(query, DB.Con);
                command.Parameters.AddWithValue(@"name",name);
                command.Parameters.AddWithValue(@"description", description);
                command.Parameters.AddWithValue(@"price", price);

                if (command.ExecuteNonQuery() > 0)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public Itemlist getItem(int itemId)
        {
            Itemlist itmList = new Itemlist();
            string query = @"SELECT * from tblItem WHERE itemId = '" + itemId + "';";

            using (MySqlConnection connect = new MySqlConnection(DB.ConnectionString))
            {
                if (connect.State == ConnectionState.Closed) connect.Open();
                using (MySqlCommand command = connect.CreateCommand())
                {
                    command.Connection = connect;
                    command.CommandText = query;
                    command.Parameters.AddWithValue(@"itemId", itemId);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //itmList.itemId = reader.GetInt32(0);
                        itmList.name = reader.GetString(1).ToString();
                        itmList.description = reader.GetString(2).ToString();
                        itmList.price = reader.GetString(3).ToString();                   
                }

            }
            return itmList;

        }

        }

        public bool updateItem(string name, string description, string price, string itemId)
        {
            bool ret = false;
            string query = "UPDATE tblItem SET name=@name,description=@description,price=@Price WHERE itemId = '" + itemId + "'";

             using (DB.Con)
            {
                DB.Con.Close();
                DB.Con.Open();
                MySqlCommand command = new MySqlCommand(query, DB.Con);

                command.Parameters.AddWithValue(@"name", name);
                command.Parameters.AddWithValue(@"description", description);
                command.Parameters.AddWithValue(@"price", price);

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
