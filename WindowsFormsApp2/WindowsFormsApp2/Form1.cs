using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
            sc.AddRange(new string[] { "One", "One Hundred", "Two", "Two demos" });
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource; 
            textBox1.AutoCompleteCustomSource = sc;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            if (n < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Value must be less than 100");
            }
            else
                errorProvider1.SetError(textBox1, "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cancelled");
            InsertDummyValidData();
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Text = "1";
            e.Cancel = false;
        }

        public void InsertDummyValidData()
        {
            textBox1.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
