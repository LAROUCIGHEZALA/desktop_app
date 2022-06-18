using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class userControlClass : UserControl
    {
         
       
        public  userControlClass()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            textBoxName.Clear();
            textBoxNumero1.Clear();
            tabControlClass.SelectedTab = tabPageAddClass;
        }
        private void Clear1()
        {
            textBoxName1.Clear();
           



        }
      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageSearchClass_Click(object sender, EventArgs e)
        {

        }

        private void UserControlClasse_Load(object sender, EventArgs e)
        {

        }

        private void UserControlClasse_Leave(object sender, EventArgs e)
        {

        }

        private void tabPageSearchClass_Leave(object sender, EventArgs e)
        {
            txtSearchClass.Clear();


        }

        private void tabPageSearchClass_Enter(object sender, EventArgs e)
        {
            DbClass.DisplayAndSearchClass("SELECT * FROM class_table", dataGridViewClass);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text.Trim()==String.Empty || textBoxNumero1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Classr clr = new Classr( textBoxNumero1.Text.Trim(), textBoxName.Text.Trim());
                DbClass.AddClass(clr);
                Clear();
            }

        }

        private void tabPageAddClass_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddClass_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageUpdateAndDeleteClass_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageUpdateAndDeleteClass_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void tabPageUpdateAndDeleteClass_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
               
                textBoxNumero1.Text = dataGridViewClass.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxName1.Text = dataGridViewClass.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (textBoxName1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please fill out field.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Classr clr = new Classr(textBoxNumero1.Text, textBoxName1.Text);
                DbClass.DeleteClass(clr);
                Clear1();
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
             
                if (textBoxName1.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Please fill out field.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Classr clr = new Classr( textBoxNumero1.Text, textBoxName1.Text);
                    DbClass.UpdateClass(clr);
                    Clear1();
                }

            }

        private void txtSearchClass_TextChanged(object sender, EventArgs e)
        {
            DbClass.DisplayAndSearchClass("SELECT * FROM class_table WHERE Name LIKE'%" + txtSearchClass.Text + "%'", dataGridViewClass);

        }

        private void dataGridViewClass_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxNumero1_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
    }

