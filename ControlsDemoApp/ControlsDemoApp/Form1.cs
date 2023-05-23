using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsDemoApp
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
            gunaTextBox1.AutoCompleteCustomSource = sc;
            gunaTextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
