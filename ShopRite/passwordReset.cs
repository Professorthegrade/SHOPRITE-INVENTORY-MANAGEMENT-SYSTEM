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
    public partial class passwordReset : Form
    {
        public passwordReset()
        {
            InitializeComponent();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        { 
        string connectQuery = "server=localhost;user=root;database=shoprite;password=";
        MySqlConnection connection = new MySqlConnection(connectQuery);

            string Query = "select * from admin where firstname = '" + this.firstname.Text +
                    "' and username = '" + this.userNamestaff.Text + "'";
       
        MySqlCommand command = new MySqlCommand(Query, connection);
            MySqlDataReader read;
            try
            {
                connection.Open();
                read = command.ExecuteReader();
                if (read.Read())
                {
                    string updateQ = "update admin set password ='" + this.Password.Text + "' where username ='" + this.userNamestaff.Text + "'";
                    MySqlConnection update = new MySqlConnection(connectQuery);
                    MySqlCommand command1 = new MySqlCommand(updateQ, update);

                    try
                    {
                        
                        if(this.Password.Text == this.retype.Text)
                        {
                            update.Open();
                            command1.ExecuteReader();
                            MessageBox.Show("Update Complete");
                            adminLogin log = new adminLogin();
                            log.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Password dont Match");
                            passwordReset passwordReset = new passwordReset();
                            passwordReset.Show();
                            this.Close();
                        }
                        
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);


                    }
                }
            }catch
            {
                MessageBox.Show("check your credentials well");
            }
    }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectQuery = "server=localhost;user=root;database=shoprite;password=";
            MySqlConnection connection = new MySqlConnection(connectQuery);

            string Query = "select * from staff where firstname = '" + this.firstname.Text +
                    "' and username = '" + this.userNamestaff.Text + "'";

            MySqlCommand command = new MySqlCommand(Query, connection);
            MySqlDataReader read;
            try
            {
                connection.Open();
                read = command.ExecuteReader();
                if (read.Read())
                {
                    string updateQ = "update staff set password ='" + this.Password.Text + "' where username ='" + this.userNamestaff.Text + "'";
                    MySqlConnection update = new MySqlConnection(connectQuery);
                    MySqlCommand command1 = new MySqlCommand(updateQ, update);
                    try
                    {

                        if (this.Password.Text == this.retype.Text)
                        {
                            update.Open();
                            command1.ExecuteReader();
                            MessageBox.Show("Update Complete");
                            staffLogin log = new staffLogin();
                            log.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Password dont Match");
                            passwordReset passwordReset = new passwordReset();
                            passwordReset.Show();
                            this.Close();
                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);


                    }
                }
            }
            catch
            {
                MessageBox.Show("check your credentials well");
            }
        }

        private void staffUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
