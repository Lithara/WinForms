using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InClassTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ValidateForm();
        }

        public void ValidateForm()
        {
            bool isValid = true;
            string errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(txtUName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                isValid = false;
                errorMessage = "Please fill in all the fields.";
            }
            else
            {
                string username = txtUName.Text;
                if (username.Length < 10 || !username.All(char.IsLower))
                {
                    isValid = false;
                    errorMessage += "Username should be at least 10 characters long and contain only lowercase letters.\n";
                }

                if (!int.TryParse(txtAge.Text, out int age) || age < 18)
                {
                    isValid = false;
                    errorMessage += "You must be at least 18 years old to sign up.\n";
                }

                string email = txtEmail.Text;
                if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
                {
                    isValid = false;
                    errorMessage += "Invalid email format.\n";
                }

                string password = txtPassword.Text;
                if (password.Length < 6)
                {
                    isValid = false;
                    errorMessage += "Password should be at least 6 characters long.\n";
                }

                string confirmPassword = txtConfirm.Text;
                if (password != confirmPassword)
                {
                    isValid = false;
                    errorMessage += "Passwords do not match.\n";
                }
            }

            if (isValid)
            {
                MessageBox.Show("Sign-up successful!");
            }
            else
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
