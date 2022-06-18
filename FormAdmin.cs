using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class FormAdmin : Form
    {

        private readonly FormAdminInfo _parent;
        public string id, nom, prénom, email,password;

       

        public string Save { get; private set; }

        public FormAdmin(FormAdminInfo parent)
        {
            InitializeComponent();
            _parent =  parent;
        }

        public FormAdmin()
        {
        }

        public void UpdateInfo()
        {
            lbltext.Text = "Update Admin";
            btnSave.Text = "Update";
            txtNom.Text = nom;
            txtPrénom.Text = prénom;
            txtemail.Text = email;
            txtPassword.Text = password;








        }
     

        public void Clear()
        {
            txtNom.Text = txtPrénom.Text = txtemail.Text = txtPassword.Text = String.Empty;

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^([a-zA-Z0-9_\.]+)@([a-zA-Z0-9_\-]+)\.([\w]{2,4})$";
            if (Regex.IsMatch(txtemail.Text,pattern))
              { errorProvider1.Clear();
            }else
            {
                errorProvider1.SetError(this.txtemail, "plzzzz provide valid mail address");
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
                string pattern = @"^([a-zA-Z0-9_\.]+)@([a-zA-Z0-9_\-]+)\.([\w]{2,4})$";
                if (Regex.IsMatch(txtemail.Text, pattern))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(this.txtemail, "plzzzz provide valid mail address");
                    return;
                }
            
            if (txtNom.Text.Trim().Length  <3)
            {
                MessageBox.Show("Admin firstname is Empty ( >3).");
                return;
            }
            if (txtPrénom.Text.Trim().Length < 3)
            {
                MessageBox.Show("Admin lastname is Empty ( >3).");
                return;
            }

           
            if (btnSave.Text ==  "save" )
            {
                Admin adm = new Admin(txtNom.Text.Trim(), txtPrénom.Text.Trim(), txtemail.Text.Trim(), txtPassword.Text.Trim());
                DbAdmin.AddAdmin(adm);
                Clear();
            }
            if (btnSave.Text == "Update")
            {
                Admin adm = new Admin(txtNom.Text.Trim(), txtPrénom.Text.Trim(), txtemail.Text.Trim(), txtPassword.Text.Trim());
                DbAdmin.UpdateAdmin(adm, id);
               
            }
            _parent.Display();

        }
    }
}
