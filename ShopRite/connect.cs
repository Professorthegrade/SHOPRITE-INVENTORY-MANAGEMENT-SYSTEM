using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopRite
{
    internal class Connect
    {
        private bool isAdmin;
        private static string connectQuery = "server=localhost;user=root;database=shoprite;password=";
        MySqlConnection connection = new MySqlConnection(connectQuery);

        public bool connect()
        {
            
            try
            {
                connection.Open();
                this.isAdmin = true;
            }
            catch
            {
                MessageBox.Show("Check Database Connection");
                this.isAdmin = false;
            }
            
            if(isAdmin == true)
            {
                return this.isAdmin;
            }
            else
            {
                return this.isAdmin;
            }
        }

        public void disconnect()
        {
            connection.Close();
        }
    }

}
