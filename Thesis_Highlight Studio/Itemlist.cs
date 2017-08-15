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
    public class Itemlist
    {
        public int itemId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string price { get; set; }

        
    }
}
