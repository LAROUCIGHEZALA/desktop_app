using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class DbPromo
    {
        public static MySqlConnection GetConnection()
        {



            string sql = "Server=localhost;database=admin;UID=root;Password=;Port=3307";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }
        public static void AddPromo(Promo Prm)
        {
            string sql = "INSERT INTO promo_table VALUES (Null,@PromoName)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@PromoName", MySqlDbType.VarChar).Value = Prm.Name;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Promo not insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            con.Close();
        }
        public static void UpdatePromo(Promo Pmr, string ID)
        {
            string sql = "UPDATE   promo_table SET  Name=@PromoName WHERE ID=@PromoID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@PromoID", MySqlDbType.VarChar).Value = ID;

            
            cmd.Parameters.Add("@PromoName", MySqlDbType.VarChar).Value = Pmr.Name;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Promo not Update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            con.Close();
        }
        public static void DeletePromo(string ID)
        {
            string sql = "DELETE FROM promo_table WHERE ID=@PromoID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@PromoID", MySqlDbType.VarChar).Value = ID;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Promotion not delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            con.Close();
        }
        public static void DisplayAndSearchPromo(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            DataTable tbl = dataTable;
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();

        }
    }
}
