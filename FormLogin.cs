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
    public partial class Formlogin : Form


        

    {
   
        MySqlConnection con = new MySqlConnection("Server=localhost;database=admin;UID=root;Password=;Port=3307");
        readonly ToolTip toolTip1 = new ToolTip();
       

        public Formlogin()
        {
            InitializeComponent();
           
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


           int i=0;
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM login WHERE username='"+ textBoxUsername.Text+ "' and password='" + textBoxPassword.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable td = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(td);
            i = Convert.ToInt32(td.Rows.Count.ToString());
            if (i== 0) 
                {
                MessageBox.Show("you have  entered invalid username or password");
            } 
                else {
                AdminInfo();
              

            }con.Close();














        }
        private void AdminInfo()
        {
            this.Hide();
            FormDashboard fd = new FormDashboard();
           fd.Username = textBoxUsername.Text;
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            fd.ShowDialog();

            this.Close();
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxHide.Show();
            
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxHide.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
