using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using BrightIdeasSoftware.Design;
using BrightIdeasSoftware;

namespace Thesis_Highlight_Studio
{
    public partial class Form1 : MaterialForm
    {
        Provider provide = new Provider();
        ObjectListView clientInfo;
        public Form1()
        {
            InitializeComponent();
            // List<User> use = new List<User>();
            //use.Add(new User();
            //use.Add(new FileInfo("file2", "doc", 5678, new DateTime(2014, 04, 14)));
            //dataListView1.SetObjects(use);
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            DB database = new DB();
            database.ToString();
            clientInfo = new ObjectListView();

        }
    }
}
