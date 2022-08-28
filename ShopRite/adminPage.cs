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
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void removeStaff_Click(object sender, EventArgs e)
        {
            DeleteStaff deleteStaff = new DeleteStaff();
            deleteStaff.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectQuery = "server=localhost;user=root;database=shoprite;password=";
            MySqlConnection connection = new MySqlConnection(connectQuery);
            MySqlCommand selectUser1 = new MySqlCommand("Select * from products where instock < 1;", connection);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = selectUser1;
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dataTable;
                this.dataGridView1.DataSource = bsource;
                sda.Update(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addStaff add = new addStaff();
            add.ShowDialog();
        }
    }
}
