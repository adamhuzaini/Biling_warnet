using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percobaan2.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // This is where you would handle the login logic
            string username = richTextBox3.Text;
            string password = richTextBox1.Text;

            // Example: Check if the username and password are valid
            if (IsValidUser(username, password))
            {
                MessageBox.Show("Login successful!");
                // Optionally, you can navigate to another form or perform additional actions here
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

             bool IsValidUser(string username, string password)
            {
                // Example: Check against a hardcoded username and password
                return username == "admin" && password == "password";
                // In a real application, you would typically check against a database or authentication service
            }

        }
    }
}
