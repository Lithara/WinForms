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
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled");
        }
    }
}
