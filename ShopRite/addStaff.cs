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
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace ShopRite
{
    public partial class addStaff : Form
    {
        Connect connect = new Connect();
        public void add()
        {
            string connectQuery = "server=localhost;user=root;database=shoprite;password=";
            MySqlConnection connection = new MySqlConnection(connectQuery);
            string addQ = "INSERT INTO `staff` (`firstname`, `surname`, `username`, `password`) VALUES('"+this.firstname.Text+"' , '"+this.surname.Text+"','"+
                this.usernamee.Text+"', '"+this.defaultpassword.Text+"')";
            MySqlConnection update = new MySqlConnection(connectQuery);
            MySqlCommand command1 = new MySqlCommand(addQ, update);
            try
            {
                MySqlDataReader read1;
                update.Open();
                read1 = command1.ExecuteReader();
                while (read1.Read())
                {
                }
                MessageBox.Show("Add complete");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);


            }
        }
        public addStaff()
        {
            InitializeComponent();
        }

        private void removeStaff_Click(object sender, EventArgs e)
        {
            if (connect.connect() == true)
            {
                if (Adminuser.Text != String.Empty && Adminpass.Text != String.Empty && usernamee.Text != String.Empty && firstname.Text != String.Empty && surname.Text != String.Empty && defaultpassword.Text != String.Empty)
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
                        MessageBox.Show("Adding in progress");
                        add();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
