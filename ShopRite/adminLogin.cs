using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopRite
{
    public partial class adminLogin : Form
    {
        Connect connect = new Connect();

        public adminLogin()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connect.connect() == true)
            {
                if (usernameTextBox.Text != String.Empty && passwordTextBox.Text != String.Empty)
                {
                    string connectQuery = "server=localhost;user=root;database=shoprite;password=";
                    MySqlConnection connection = new MySqlConnection(connectQuery);
                    connection.Open();

                    MySqlCommand selectUser = new MySqlCommand();
                    selectUser.Connection = connection;
                    selectUser.CommandText = "Select * from Admin where username ='" + usernameTextBox.Text +"' and password= '" + passwordTextBox.Text+"'";
                    selectUser.Prepare();
                    MySqlDataReader readUser = selectUser.ExecuteReader();
                    if (readUser.Read())
                    {
                        //change the display message here to load administration page 
                        MessageBox.Show("Admin login successfull");
                        adminPage adminPage = new adminPage();
                        adminPage.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Credentials");
                        adminLogin admin = new adminLogin();
                        admin.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Provide inputs in all fields");
                }
            }
        }

        private void resetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passwordReset passwordReset = new passwordReset();
            passwordReset.Show();
            this.Close();
        }
    }
}
