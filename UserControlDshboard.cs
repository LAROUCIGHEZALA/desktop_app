using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControlDshboard : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;database=admin;UID=root;Password=;Port=3307");
        public UserControlDshboard()
        {
            InitializeComponent();
        }

        private void labelAdminCount_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDshboard_Load(object sender, EventArgs e)
        {
            Admins();
            Salles();
            Promos();
        }
        public void Admins()
        {
            con.Open();
            String sql = "SELECT COUNT(*) FROM admin_table; ";
            MySqlCommand count_cmd = new MySqlCommand(sql, con);
           

            labelAdminCount.Text = count_cmd.ExecuteScalar().ToString();
            con.Close();
            return;
        }
        public void Salles()
        {
            String sql = "SELECT COUNT(*) FROM class_table;";

            MySqlCommand count_cmd = new MySqlCommand( sql,con);
            con.Open();
            labelSallCount.Text = count_cmd.ExecuteScalar().ToString();
            con.Close();

        }
        public void Promos()
        {
            String sql = "SELECT COUNT(*) FROM promo_table;";
            MySqlCommand count_cmd = new MySqlCommand(sql, con);
            con.Open();
            labelPromoCount.Text = count_cmd.ExecuteScalar().ToString();
            con.Close();
        }

        private void labelSallCount_Click(object sender, EventArgs e)
        {

        }
    }
}
