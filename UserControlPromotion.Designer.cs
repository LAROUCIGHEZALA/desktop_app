namespace WindowsFormsApp1
{
    partial class userControlPromotion
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlPromotion = new System.Windows.Forms.TabControl();
            this.tabPageAddPromotion = new System.Windows.Forms.TabPage();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageSearchPromotion = new System.Windows.Forms.TabPage();
            this.labelSearchClass = new System.Windows.Forms.Label();
            this.dataGridViewPromo = new System.Windows.Forms.DataGridView();
            this.txtSearchPromo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpdateAnddeletePromotion = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxNom1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlPromotion.SuspendLayout();
            this.tabPageAddPromotion.SuspendLayout();
            this.tabPageSearchPromotion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromo)).BeginInit();
            this.tabPageUpdateAnddeletePromotion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPromotion
            // 
            this.tabControlPromotion.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlPromotion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlPromotion.Controls.Add(this.tabPageAddPromotion);
            this.tabControlPromotion.Controls.Add(this.tabPageSearchPromotion);
            this.tabControlPromotion.Controls.Add(this.tabPageUpdateAnddeletePromotion);
            this.tabControlPromotion.Location = new System.Drawing.Point(65, 40);
            this.tabControlPromotion.Multiline = true;
            this.tabControlPromotion.Name = "tabControlPromotion";
            this.tabControlPromotion.SelectedIndex = 0;
            this.tabControlPromotion.Size = new System.Drawing.Size(1105, 426);
            this.tabControlPromotion.TabIndex = 0;
            // 
            // tabPageAddPromotion
            // 
            this.tabPageAddPromotion.Controls.Add(this.textBoxNom);
            this.tabPageAddPromotion.Controls.Add(this.button2);
            this.tabPageAddPromotion.Controls.Add(this.label1);
            this.tabPageAddPromotion.Controls.Add(this.label2);
            this.tabPageAddPromotion.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddPromotion.Name = "tabPageAddPromotion";
            this.tabPageAddPromotion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddPromotion.Size = new System.Drawing.Size(1097, 395);
            this.tabPageAddPromotion.TabIndex = 0;
            this.tabPageAddPromotion.Text = "AddPromotion";
            this.tabPageAddPromotion.UseVisualStyleBackColor = true;
            this.tabPageAddPromotion.Click += new System.EventHandler(this.tabPageAddPromotion_Click);
            this.tabPageAddPromotion.Leave += new System.EventHandler(this.tabPageAddPromotion_Leave);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(39, 140);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(297, 24);
            this.textBoxNom.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(80, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Leave += new System.EventHandler(this.button2_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = " Add Promotion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = " Nom :";
            // 
            // tabPageSearchPromotion
            // 
            this.tabPageSearchPromotion.Controls.Add(this.labelSearchClass);
            this.tabPageSearchPromotion.Controls.Add(this.dataGridViewPromo);
            this.tabPageSearchPromotion.Controls.Add(this.txtSearchPromo);
            this.tabPageSearchPromotion.Controls.Add(this.label4);
            this.tabPageSearchPromotion.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchPromotion.Name = "tabPageSearchPromotion";
            this.tabPageSearchPromotion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchPromotion.Size = new System.Drawing.Size(1097, 395);
            this.tabPageSearchPromotion.TabIndex = 1;
            this.tabPageSearchPromotion.Text = "SearchPromotion";
            this.tabPageSearchPromotion.UseVisualStyleBackColor = true;
            this.tabPageSearchPromotion.Click += new System.EventHandler(this.tabPageSearchPromotion_Click);
            this.tabPageSearchPromotion.Enter += new System.EventHandler(this.tabPageSearchPromotion_Enter);
            this.tabPageSearchPromotion.Leave += new System.EventHandler(this.tabPageSearchPromotion_Leave);
            // 
            // labelSearchClass
            // 
            this.labelSearchClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearchClass.AutoSize = true;
            this.labelSearchClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchClass.ForeColor = System.Drawing.Color.Blue;
            this.labelSearchClass.Location = new System.Drawing.Point(394, 12);
            this.labelSearchClass.Name = "labelSearchClass";
            this.labelSearchClass.Size = new System.Drawing.Size(222, 29);
            this.labelSearchClass.TabIndex = 7;
            this.labelSearchClass.Text = "SearchPromotion:";
            // 
            // dataGridViewPromo
            // 
            this.dataGridViewPromo.AllowUserToAddRows = false;
            this.dataGridViewPromo.AllowUserToDeleteRows = false;
            this.dataGridViewPromo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPromo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPromo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPromo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            this.dataGridViewPromo.Location = new System.Drawing.Point(20, 169);
            this.dataGridViewPromo.Name = "dataGridViewPromo";
            this.dataGridViewPromo.ReadOnly = true;
            this.dataGridViewPromo.Size = new System.Drawing.Size(973, 150);
            this.dataGridViewPromo.TabIndex = 4;
            this.dataGridViewPromo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPromo_CellClick);
            this.dataGridViewPromo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPromo_CellContentClick);
            this.dataGridViewPromo.Enter += new System.EventHandler(this.dataGridViewPromo_Enter);
            this.dataGridViewPromo.Leave += new System.EventHandler(this.dataGridViewPromo_Leave);
            // 
            // txtSearchPromo
            // 
            this.txtSearchPromo.Location = new System.Drawing.Point(42, 109);
            this.txtSearchPromo.Name = "txtSearchPromo";
            this.txtSearchPromo.Size = new System.Drawing.Size(289, 24);
            this.txtSearchPromo.TabIndex = 6;
            this.txtSearchPromo.TextChanged += new System.EventHandler(this.txtSearchPromo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name Promotion :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabPageUpdateAnddeletePromotion
            // 
            this.tabPageUpdateAnddeletePromotion.Controls.Add(this.buttonDelete);
            this.tabPageUpdateAnddeletePromotion.Controls.Add(this.textBoxNom1);
            this.tabPageUpdateAnddeletePromotion.Controls.Add(this.button1);
            this.tabPageUpdateAnddeletePromotion.Controls.Add(this.label6);
            this.tabPageUpdateAnddeletePromotion.Controls.Add(this.label7);
            this.tabPageUpdateAnddeletePromotion.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAnddeletePromotion.Name = "tabPageUpdateAnddeletePromotion";
            this.tabPageUpdateAnddeletePromotion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAnddeletePromotion.Size = new System.Drawing.Size(1097, 395);
            this.tabPageUpdateAnddeletePromotion.TabIndex = 2;
            this.tabPageUpdateAnddeletePromotion.Text = "Update And DeletePromotion";
            this.tabPageUpdateAnddeletePromotion.UseVisualStyleBackColor = true;
            this.tabPageUpdateAnddeletePromotion.Click += new System.EventHandler(this.tabPageUpdateAnddeletePromotion_Click);
            this.tabPageUpdateAnddeletePromotion.Enter += new System.EventHandler(this.tabPageUpdateAnddeletePromotion_Enter);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(417, 273);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 42);
            this.buttonDelete.TabIndex = 30;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxNom1
            // 
            this.textBoxNom1.Location = new System.Drawing.Point(175, 141);
            this.textBoxNom1.Name = "textBoxNom1";
            this.textBoxNom1.Size = new System.Drawing.Size(297, 24);
            this.textBoxNom1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(248, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 26;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(328, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = " Update And Delete Promotion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(180, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = " Nom :";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // userControlPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlPromotion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "userControlPromotion";
            this.Size = new System.Drawing.Size(1842, 590);
            this.Load += new System.EventHandler(this.UserControlPromotion_Load);
            this.tabControlPromotion.ResumeLayout(false);
            this.tabPageAddPromotion.ResumeLayout(false);
            this.tabPageAddPromotion.PerformLayout();
            this.tabPageSearchPromotion.ResumeLayout(false);
            this.tabPageSearchPromotion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromo)).EndInit();
            this.tabPageUpdateAnddeletePromotion.ResumeLayout(false);
            this.tabPageUpdateAnddeletePromotion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPromotion;
        private System.Windows.Forms.TabPage tabPageAddPromotion;
        private System.Windows.Forms.TabPage tabPageSearchPromotion;
        private System.Windows.Forms.TabPage tabPageUpdateAnddeletePromotion;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSearchClass;
        private System.Windows.Forms.DataGridView dataGridViewPromo;
        private System.Windows.Forms.TextBox txtSearchPromo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNom1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
