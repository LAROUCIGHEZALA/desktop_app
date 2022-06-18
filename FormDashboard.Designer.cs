namespace WindowsFormsApp1
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonClasse = new System.Windows.Forms.Button();
            this.buttonPromotion = new System.Windows.Forms.Button();
            this.buttonAdmins = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userControlDshboard1 = new WindowsFormsApp1.UserControlDshboard();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControlPromotion1 = new WindowsFormsApp1.userControlPromotion();
            this.userControlClass = new WindowsFormsApp1.userControlClass();
            this.userControlDshboard2 = new WindowsFormsApp1.UserControlDshboard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.buttonClasse);
            this.panel1.Controls.Add(this.buttonPromotion);
            this.panel1.Controls.Add(this.buttonAdmins);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 540);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.gf1;
            this.pictureBox5.Location = new System.Drawing.Point(21, 497);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.system_administrator_male;
            this.pictureBox4.Location = new System.Drawing.Point(21, 354);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.dashboard_l;
            this.pictureBox3.Location = new System.Drawing.Point(29, 254);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.classroom__v1;
            this.pictureBox2.Location = new System.Drawing.Point(21, 434);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(3, 247);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 51);
            this.panelSlide.TabIndex = 0;
            // 
            // buttonClasse
            // 
            this.buttonClasse.FlatAppearance.BorderSize = 0;
            this.buttonClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClasse.ForeColor = System.Drawing.Color.White;
            this.buttonClasse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClasse.Location = new System.Drawing.Point(16, 418);
            this.buttonClasse.Name = "buttonClasse";
            this.buttonClasse.Size = new System.Drawing.Size(251, 73);
            this.buttonClasse.TabIndex = 5;
            this.buttonClasse.Text = "   Salle";
            this.buttonClasse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClasse.UseVisualStyleBackColor = true;
            this.buttonClasse.Click += new System.EventHandler(this.buttonClasse_Click);
            // 
            // buttonPromotion
            // 
            this.buttonPromotion.FlatAppearance.BorderSize = 0;
            this.buttonPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromotion.ForeColor = System.Drawing.Color.White;
            this.buttonPromotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPromotion.Location = new System.Drawing.Point(16, 485);
            this.buttonPromotion.Name = "buttonPromotion";
            this.buttonPromotion.Size = new System.Drawing.Size(251, 72);
            this.buttonPromotion.TabIndex = 4;
            this.buttonPromotion.Text = "promotion";
            this.buttonPromotion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPromotion.UseVisualStyleBackColor = true;
            this.buttonPromotion.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonAdmins
            // 
            this.buttonAdmins.FlatAppearance.BorderSize = 0;
            this.buttonAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmins.ForeColor = System.Drawing.Color.White;
            this.buttonAdmins.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdmins.Location = new System.Drawing.Point(16, 338);
            this.buttonAdmins.Name = "buttonAdmins";
            this.buttonAdmins.Size = new System.Drawing.Size(251, 63);
            this.buttonAdmins.TabIndex = 2;
            this.buttonAdmins.Text = "  admins";
            this.buttonAdmins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdmins.UseVisualStyleBackColor = true;
            this.buttonAdmins.Click += new System.EventHandler(this.buttonAdmins_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(19, 247);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(248, 57);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "   dashboard";
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 229);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "System Administrator";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = " Manager";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.concept;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.userControlDshboard1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(273, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(774, 173);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.labelDateTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1136, 97);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelDateTime.Location = new System.Drawing.Point(19, 30);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(19, 20);
            this.labelDateTime.TabIndex = 0;
            this.labelDateTime.Text = "?";
            this.labelDateTime.Click += new System.EventHandler(this.labelDateTime_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelUsername);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1093, 547);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(128, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(26, 29);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "?";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcom:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // userControlDshboard1
            // 
            this.userControlDshboard1.BackColor = System.Drawing.Color.White;
            this.userControlDshboard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDshboard1.Location = new System.Drawing.Point(5, 661);
            this.userControlDshboard1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlDshboard1.Name = "userControlDshboard1";
            this.userControlDshboard1.Size = new System.Drawing.Size(1104, 426);
            this.userControlDshboard1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userControlPromotion1
            // 
            this.userControlPromotion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlPromotion1.Location = new System.Drawing.Point(273, 180);
            this.userControlPromotion1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userControlPromotion1.Name = "userControlPromotion1";
            this.userControlPromotion1.Size = new System.Drawing.Size(1833, 575);
            this.userControlPromotion1.TabIndex = 1;
            this.userControlPromotion1.Visible = false;
            this.userControlPromotion1.Load += new System.EventHandler(this.userControlPromotion1_Load);
            // 
            // userControlClass
            // 
            this.userControlClass.BackColor = System.Drawing.Color.White;
            this.userControlClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlClass.Location = new System.Drawing.Point(280, 173);
            this.userControlClass.Margin = new System.Windows.Forms.Padding(4);
            this.userControlClass.Name = "userControlClass";
            this.userControlClass.Size = new System.Drawing.Size(1109, 449);
            this.userControlClass.TabIndex = 0;
            this.userControlClass.Visible = false;
            this.userControlClass.Load += new System.EventHandler(this.userControlClasse1_Load);
            // 
            // userControlDshboard2
            // 
            this.userControlDshboard2.BackColor = System.Drawing.Color.White;
            this.userControlDshboard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDshboard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDshboard2.Location = new System.Drawing.Point(273, 173);
            this.userControlDshboard2.Margin = new System.Windows.Forms.Padding(5);
            this.userControlDshboard2.Name = "userControlDshboard2";
            this.userControlDshboard2.Size = new System.Drawing.Size(774, 367);
            this.userControlDshboard2.TabIndex = 0;
            this.userControlDshboard2.Load += new System.EventHandler(this.userControlDshboard2_Load);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 540);
            this.Controls.Add(this.userControlDshboard2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.userControlPromotion1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlClass);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonClasse;
        private System.Windows.Forms.Button buttonPromotion;
        private System.Windows.Forms.Button buttonAdmins;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private userControlClass userControlClass;
        private userControlPromotion userControlPromotion1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private UserControlDshboard userControlDshboard1;
        private UserControlDshboard userControlDshboard2;
    }
}