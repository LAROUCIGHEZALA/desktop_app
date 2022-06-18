namespace WindowsFormsApp1
{
    partial class userControlClass
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
            this.tabControlClass = new System.Windows.Forms.TabControl();
            this.tabPageAddClass = new System.Windows.Forms.TabPage();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageSearchClass = new System.Windows.Forms.TabPage();
            this.labelSearchClass = new System.Windows.Forms.Label();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.Class_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpdateAndDeleteClass = new System.Windows.Forms.TabPage();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlClass.SuspendLayout();
            this.tabPageAddClass.SuspendLayout();
            this.tabPageSearchClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.tabPageUpdateAndDeleteClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClass
            // 
            this.tabControlClass.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlClass.Controls.Add(this.tabPageAddClass);
            this.tabControlClass.Controls.Add(this.tabPageSearchClass);
            this.tabControlClass.Controls.Add(this.tabPageUpdateAndDeleteClass);
            this.tabControlClass.Location = new System.Drawing.Point(35, 22);
            this.tabControlClass.Name = "tabControlClass";
            this.tabControlClass.SelectedIndex = 0;
            this.tabControlClass.Size = new System.Drawing.Size(1031, 401);
            this.tabControlClass.TabIndex = 0;
            // 
            // tabPageAddClass
            // 
            this.tabPageAddClass.Controls.Add(this.textBoxName);
            this.tabPageAddClass.Controls.Add(this.textBoxNumero1);
            this.tabPageAddClass.Controls.Add(this.button1);
            this.tabPageAddClass.Controls.Add(this.label5);
            this.tabPageAddClass.Controls.Add(this.label6);
            this.tabPageAddClass.Controls.Add(this.label7);
            this.tabPageAddClass.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClass.Name = "tabPageAddClass";
            this.tabPageAddClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClass.Size = new System.Drawing.Size(1023, 372);
            this.tabPageAddClass.TabIndex = 0;
            this.tabPageAddClass.Text = "Add Salle";
            this.tabPageAddClass.UseVisualStyleBackColor = true;
            this.tabPageAddClass.Click += new System.EventHandler(this.tabPageAddClass_Click);
            this.tabPageAddClass.Leave += new System.EventHandler(this.tabPageAddClass_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(228, 169);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(245, 22);
            this.textBoxName.TabIndex = 12;
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.Location = new System.Drawing.Point(659, 158);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(297, 22);
            this.textBoxNumero1.TabIndex = 11;
            this.textBoxNumero1.TextChanged += new System.EventHandler(this.textBoxNumero1_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(219, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = " Add Salle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(654, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = " Number :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(214, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = " Name :";
            // 
            // tabPageSearchClass
            // 
            this.tabPageSearchClass.Controls.Add(this.labelSearchClass);
            this.tabPageSearchClass.Controls.Add(this.dataGridViewClass);
            this.tabPageSearchClass.Controls.Add(this.txtSearchClass);
            this.tabPageSearchClass.Controls.Add(this.label4);
            this.tabPageSearchClass.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClass.Name = "tabPageSearchClass";
            this.tabPageSearchClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchClass.Size = new System.Drawing.Size(1023, 372);
            this.tabPageSearchClass.TabIndex = 1;
            this.tabPageSearchClass.Text = "SearchSalle";
            this.tabPageSearchClass.UseVisualStyleBackColor = true;
            this.tabPageSearchClass.Click += new System.EventHandler(this.tabPageSearchClass_Click);
            this.tabPageSearchClass.Enter += new System.EventHandler(this.tabPageSearchClass_Enter);
            this.tabPageSearchClass.Leave += new System.EventHandler(this.tabPageSearchClass_Leave);
            // 
            // labelSearchClass
            // 
            this.labelSearchClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearchClass.AutoSize = true;
            this.labelSearchClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchClass.ForeColor = System.Drawing.Color.Blue;
            this.labelSearchClass.Location = new System.Drawing.Point(16, 14);
            this.labelSearchClass.Name = "labelSearchClass";
            this.labelSearchClass.Size = new System.Drawing.Size(162, 29);
            this.labelSearchClass.TabIndex = 3;
            this.labelSearchClass.Text = "SearchSalle:";
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.AllowUserToAddRows = false;
            this.dataGridViewClass.AllowUserToDeleteRows = false;
            this.dataGridViewClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Class_Number,
            this.Class_Name});
            this.dataGridViewClass.Location = new System.Drawing.Point(21, 178);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.ReadOnly = true;
            this.dataGridViewClass.Size = new System.Drawing.Size(973, 150);
            this.dataGridViewClass.TabIndex = 0;
            this.dataGridViewClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClass_CellClick);
            this.dataGridViewClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClass_CellContentClick);
            this.dataGridViewClass.Enter += new System.EventHandler(this.dataGridViewClass_Enter);
            // 
            // Class_Number
            // 
            this.Class_Number.HeaderText = "Number";
            this.Class_Number.Name = "Class_Number";
            this.Class_Number.ReadOnly = true;
            // 
            // Class_Name
            // 
            this.Class_Name.HeaderText = "Name";
            this.Class_Name.Name = "Class_Name";
            this.Class_Name.ReadOnly = true;
            // 
            // txtSearchClass
            // 
            this.txtSearchClass.Location = new System.Drawing.Point(224, 119);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.Size = new System.Drawing.Size(289, 22);
            this.txtSearchClass.TabIndex = 1;
            this.txtSearchClass.TextChanged += new System.EventHandler(this.txtSearchClass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sall Name :";
            // 
            // tabPageUpdateAndDeleteClass
            // 
            this.tabPageUpdateAndDeleteClass.Controls.Add(this.textBoxName1);
            this.tabPageUpdateAndDeleteClass.Controls.Add(this.buttonDelete);
            this.tabPageUpdateAndDeleteClass.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateAndDeleteClass.Controls.Add(this.label3);
            this.tabPageUpdateAndDeleteClass.Controls.Add(this.label1);
            this.tabPageUpdateAndDeleteClass.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndDeleteClass.Name = "tabPageUpdateAndDeleteClass";
            this.tabPageUpdateAndDeleteClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAndDeleteClass.Size = new System.Drawing.Size(1023, 372);
            this.tabPageUpdateAndDeleteClass.TabIndex = 2;
            this.tabPageUpdateAndDeleteClass.Text = "Update and deleteSalle";
            this.tabPageUpdateAndDeleteClass.UseVisualStyleBackColor = true;
            this.tabPageUpdateAndDeleteClass.Click += new System.EventHandler(this.tabPageUpdateAndDeleteClass_Click);
            this.tabPageUpdateAndDeleteClass.Enter += new System.EventHandler(this.tabPageUpdateAndDeleteClass_Enter);
            this.tabPageUpdateAndDeleteClass.Leave += new System.EventHandler(this.tabPageUpdateAndDeleteClass_Leave);
            // 
            // textBoxName1
            // 
            this.textBoxName1.Location = new System.Drawing.Point(186, 170);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(218, 22);
            this.textBoxName1.TabIndex = 7;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(352, 281);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 42);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.Blue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(186, 281);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 42);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Update and deleteClass";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(181, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = " Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userControlClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlClass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "userControlClass";
            this.Size = new System.Drawing.Size(1105, 426);
            this.Load += new System.EventHandler(this.UserControlClasse_Load);
            this.Leave += new System.EventHandler(this.UserControlClasse_Leave);
            this.tabControlClass.ResumeLayout(false);
            this.tabPageAddClass.ResumeLayout(false);
            this.tabPageAddClass.PerformLayout();
            this.tabPageSearchClass.ResumeLayout(false);
            this.tabPageSearchClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            this.tabPageUpdateAndDeleteClass.ResumeLayout(false);
            this.tabPageUpdateAndDeleteClass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClass;
        private System.Windows.Forms.TabPage tabPageAddClass;
        private System.Windows.Forms.TabPage tabPageSearchClass;
        private System.Windows.Forms.TabPage tabPageUpdateAndDeleteClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSearchClass;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.TextBox txtSearchClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Name;
        private System.Windows.Forms.TextBox textBoxName1;
    }
}
