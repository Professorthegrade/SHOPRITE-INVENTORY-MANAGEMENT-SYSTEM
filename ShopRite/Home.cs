using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShopRite
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            if(connect.connect() == true)
            {
                Exit();
                adminLogin adminpage = new adminLogin();
                adminpage.Show();
                GetV();
            }
        }

        public void Exit()
        {
            Home home = new Home();
            home.Close();
        }
        private void GetV()
        {
           this.Hide();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            if(connect.connect() == true)
            {
                Exit();
                staffLogin staff = new staffLogin();
                staff.Show();
                GetV();
            }
        }
    }
}
