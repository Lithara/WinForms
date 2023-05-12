using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox3.Text);

            int sum = n1 + n2;
            
            
           

            label5.Text = "Summation : " + sum; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
                    }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox3.Text);

            int sub = n1 - n2;

            label5.Text = "Substraction : " + sub;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox3.Text);

            int mul = n1 * n2;

            label5.Text = "Multiplication : " + mul;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox3.Text);

            double div = n1 / n2;

            label5.Text = "Division : " + div;
        }
    }
}
