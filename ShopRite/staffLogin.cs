using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ShopRite
{
    public partial class staffLogin : Form

    {
        private String firstname;
        Connect connect = new Connect();
        public staffLogin()
        {
            InitializeComponent();
        }
        public string getName()
        {
            string connectQuery = "server=localhost;user=root;database=shoprite;password=";
            MySqlConnection connection = new MySqlConnection(connectQuery);
            try
            {
                connection.Open();
                MySqlCommand selectUser1 = new MySqlCommand();
            selectUser1.Connection = connection;
            selectUser1.CommandText = "Select firstname from staff where username ='" + userNamestaff.Text + "' and password= '" + Password.Text + "'";
            selectUser1.Prepare();

            MySqlDataReader readUser1 = selectUser1.ExecuteReader();
            
                while (readUser1.Read())
                {
                    firstname = readUser1.GetString(0);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
            return this.firstname;
        }
        //Exit method to end application
        public void hide()
        {
            this.Hide();
        }
        public void Exit()
        {
            staffLogin staff = new staffLogin();
            staff.Exit();
        }
        private void logInbtn_Click(object sender, EventArgs e)
        {
            //object for staff window below here
            if (connect.connect() == true)
            {
                if (userNamestaff.Text != String.Empty && Password.Text != String.Empty)
                {
                    string connectQuery = "server=localhost;user=root;database=shoprite;password=";
                    MySqlConnection connection = new MySqlConnection(connectQuery);
                    connection.Open();

                    MySqlCommand selectUser = new MySqlCommand();
                    selectUser.Connection = connection;
                    selectUser.CommandText = "Select * from staff where username ='" + userNamestaff.Text + "' and password= '" + Password.Text + "'";
                    selectUser.Prepare();
                    MySqlDataReader readUser = selectUser.ExecuteReader();
                    if (readUser.Read())
                    {
                        firstname = getName();
                        StaffPage staffwin = new StaffPage(firstname);
                        staffwin.Show();
                        hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Credentials");
                        staffLogin staff1 = new staffLogin();
                        staff1.Show();
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
