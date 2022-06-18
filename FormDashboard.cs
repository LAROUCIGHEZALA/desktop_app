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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }
        public String Username;

      

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MovePanel(buttonPromotion);
            userControlPromotion1.Clear();
            userControlPromotion1.Show();
            userControlDshboard2.Hide();

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            userControlClass.Hide();
            userControlPromotion1.Hide();
            userControlDshboard2.Admins();
            userControlDshboard2.Salles();
            userControlDshboard2.Promos();
            userControlDshboard2.Show();

            
           
            



        }

        private void buttonAdmins_Click(object sender, EventArgs e)
        {
            MovePanel(buttonAdmins);
            FormAdminInfo fd = new FormAdminInfo();
            fd.ShowDialog();
            userControlClass.Hide();
            userControlPromotion1.Hide();
            userControlDshboard2.Hide();



        }

        private void buttonClasse_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClasse);
            userControlClass.Clear();
            userControlClass.Show();
            userControlPromotion1.Hide();
            userControlDshboard2.Hide();

        }

        

        private void userControlClasse1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void userControlPromotion1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void userControlDshboard2_Load(object sender, EventArgs e)
        {

        }
    }
}
