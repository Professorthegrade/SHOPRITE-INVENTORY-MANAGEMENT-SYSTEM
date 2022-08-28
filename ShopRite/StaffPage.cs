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
    public partial class StaffPage : Form
    {
        public StaffPage(String name)
        {
            
            InitializeComponent();
            this.name.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectQuery = "server=localhost;user=root;database=shoprite;password=";
            MySqlConnection connection = new MySqlConnection(connectQuery);
            MySqlCommand selectUser1 = new MySqlCommand("Select * from products where barcode ='" + this.barcodeText.Text + "' or name='" + this.namee.Text + "';", connection);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();  
                sda.SelectCommand = selectUser1;
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dataTable;
                this.search.DataSource = bsource;
                sda.Update(dataTable);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
