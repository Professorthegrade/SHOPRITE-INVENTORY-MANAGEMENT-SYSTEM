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
    public partial class DeleteStaff : Form {
        Connect connect = new Connect();
        public DeleteStaff()
        {
            InitializeComponent();
        }

        public void del()
        {
            string connectQuery = "server=localhost;user=root;database=shoprite;password=";
            MySqlConnection connection = new MySqlConnection(connectQuery);
            string deleteQ = "delete from staff where firstname ='" + this.firstname.Text + "'and surname ='" + this.surname.Text +
                "' and username ='" + this.username.Text + "'";
            MySqlConnection update = new MySqlConnection(connectQuery);
            MySqlCommand command1 = new MySqlCommand(deleteQ, update);
            try
            {
                MySqlDataReader read1;
                update.Open();
                read1 = command1.ExecuteReader();
                while (read1.Read())
                {
                }
                MessageBox.Show("Deletion complete");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void removeStaff_Click(object sender, EventArgs e)
        {
            if (connect.connect() == true)
            {
                if (Adminuser.Text != String.Empty && Adminpass.Text != String.Empty)
                {
                    string connectQuery = "server=localhost;user=root;database=shoprite;password=";
                    MySqlConnection connection = new MySqlConnection(connectQuery);
                    connection.Open();

                    MySqlCommand selectUser = new MySqlCommand();
                    selectUser.Connection = connection;
                    selectUser.CommandText = "Select * from Admin where username ='" + Adminuser.Text + "' and password= '" + Adminpass.Text + "'";
                    selectUser.Prepare();
                    MySqlDataReader readUser = selectUser.ExecuteReader();
                    if (readUser.Read())
                    {
                        //change the display message here to load administration page 
                        MessageBox.Show("Deletion in progress");
                        del();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Credentials");
                    }
                }
                else
                {
                    MessageBox.Show("Please Provide inputs in all fields");
                }
            }
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
