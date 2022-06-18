using MySqlX.XDevAPI.Relational;
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
    public partial class userControlPromotion : UserControl
    {
        private string ID = "";
        public userControlPromotion()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            
            textBoxNom.Clear();
            tabControlPromotion.SelectedTab = tabPageAddPromotion;
        }
        public void Clear1()
        {
            
            textBoxNom1.Clear();
          
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchPromo_TextChanged(object sender, EventArgs e)
        {
            DbPromo.DisplayAndSearchPromo("SELECT * FROM promo_table WHERE Name LIKE'%" + txtSearchPromo.Text + "%'", dataGridViewPromo);
        }

        private void tabPageAddPromotion_Click(object sender, EventArgs e)
        {

        }

        private void button2_Leave(object sender, EventArgs e)
        {

        }

        private void tabPageAddPromotion_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearchPromotion_Enter(object sender, EventArgs e)
        {

            DbPromo.DisplayAndSearchPromo("SELECT * FROM promo_table", dataGridViewPromo);
        }

        private void tabPageSearchPromotion_Click(object sender, EventArgs e)
        {

        }

        private void tabPageUpdateAnddeletePromotion_Enter(object sender, EventArgs e)
        {
            Clear1();
        }

        private void UserControlPromotion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( textBoxNom.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Promo Pmr = new Promo( textBoxNom.Text.Trim());
                DbPromo.AddPromo(Pmr);
                Clear();
            }
        }

        private void dataGridViewPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                
                ID = dataGridViewPromo.Rows[e.RowIndex].Cells[2].Value.ToString(); 

                textBoxNom1.Text = dataGridViewPromo.Rows[e.RowIndex].Cells[3].Value.ToString();
             

            }
        }

        private void dataGridViewPromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ID !="")
            {

                if ( textBoxNom1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all fields.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Promo Pmr = new Promo( textBoxNom1.Text);
                    DbPromo.UpdatePromo(Pmr, ID);
                    Clear1();
                }
            }
          

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {

                if ( textBoxNom1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all fields.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you want to delete this promo", "Promo delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
               if (DialogResult.Yes == result)
                    {
                        Promo Pmr = new Promo(textBoxNom1.Text);
                        DbPromo.DeletePromo( ID);
                        Clear1();
                    }




                        
                        }


            }
          
        }

        private void dataGridViewPromo_Enter(object sender, EventArgs e)
        {


        }

        private void dataGridViewPromo_Leave(object sender, EventArgs e)
        {

        }

        private void tabPageSearchPromotion_Leave(object sender, EventArgs e)
        {
            txtSearchPromo.Clear();
        }

        private void tabPageUpdateAnddeletePromotion_Click(object sender, EventArgs e)
        {

        }
    }
    }

