using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Operatiions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);

            //creating sql connection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\LastDB.mdf;Integrated Security=True;Connect Timeout=30");

            //creating the SQL query
            string qry = "INSERT INTO Info VALUES('"+ID+"') ";

            //creating the command
            SqlCommand cmd = new SqlCommand(qry, con);

            MessageBox.Show("Your ID has submitted.");
            this.Close();
            
        }
    }
}
