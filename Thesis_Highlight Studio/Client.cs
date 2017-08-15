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
    public class Client
    {

        public int userId { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string typeOfUser { get; set; }
        public string familyName { get; set; }
        public string givenName { get; set; }
        public string middleName { get; set; }
        public string address { get; set; }
        public string nameOfSchool { get; set; }
        public string courseTitle { get; set; }
        public string mobileNumber { get; set; }
        public string landline { get; set; }
        public string emailAdd { get; set; }
        public string status { get; set; }
         
    }
}
