﻿using System;
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
    public partial class ControlsDemoForm : Form
    {
        public ControlsDemoForm()
        {
            InitializeComponent();
        }

        private void ControlsDemoForm_Load(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_Validating(object sender, CancelEventArgs e)
        {
            int n = int.Parse(gunaTextBox1.Text);
            if (n > 100)
            {
                e.Cancel = true;
                errorProvider1.SetError(gunaTextBox1, "Value must be less than 100");
            }
            else
            {
                errorProvider1.SetError(gunaTextBox1, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InsertDummyValidData();
            this.Close();
            //MessageBox.Show("Cancelled");
        }

        private void ControlsDemoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            InsertDummyValidData();
            e.Cancel = false;
        }

        public void InsertDummyValidData()
        {
            gunaTextBox1.Text = "1";

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
