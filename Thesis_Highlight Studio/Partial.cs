using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Thesis_Highlight_Studio
{
    public partial class Partial : MaterialForm
    {
        public Partial()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string lastName = materialSingleLineTextField1.Text;
            string firstName = materialSingleLineTextField2.Text;
            string middleName = materialSingleLineTextField3.Text;

            string fullName = lastName + "," + " " + firstName + " " + middleName;
            MessageBox.Show(fullName);
        }

        private void Partial_Load(object sender, EventArgs e)
        {
            
        }
    }
}
