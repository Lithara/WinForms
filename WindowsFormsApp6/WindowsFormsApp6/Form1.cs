﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 objHome = new Form2();

            string fromUn = textBox1.Text;
            string fromPw = textBox2.Text;

            string un = "Admin";
            string pw = "admin123";

            if (fromUn == un && fromPw == pw)
            {
                objHome.Show();
                this.Hide();
            }
            else
            {
                
                textBox1.Text = "";
                textBox2.Text = "";
            }
            
        }
    }
}
