namespace gTontine
{
    partial class frmOpération
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpération));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCycle = new System.Windows.Forms.ComboBox();
            this.cboLib = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code_operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomComplet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lib_cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_payer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_effe_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enregistrement = new System.Windows.Forms.GroupBox();
            this.cboAdhe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateEffe = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Enregistrement.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFermer);
            this.groupBox1.Controls.Add(this.btnEnregistrer);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(481, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 171);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(73, 183);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(57, 21);
            this.txtNombre.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 90;
            this.label5.Text = "Nombre :";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(334, 36);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(117, 20);
            this.dtpDate.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Date :";
            // 
            // txtMontant
            // 
            this.txtMontant.BackColor = System.Drawing.Color.Snow;
            this.txtMontant.Location = new System.Drawing.Point(334, 82);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(117, 20);
            this.txtMontant.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.TabIndex = 91;
            this.label1.Text = "Montant \r\n payer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 88;
            this.label4.Text = "Cycle :";
            // 
            // cboCycle
            // 
            this.cboCycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCycle.FormattingEnabled = true;
            this.cboCycle.Location = new System.Drawing.Point(76, 128);
            this.cboCycle.Name = "cboCycle";
            this.cboCycle.Size = new System.Drawing.Size(162, 21);
            this.cboCycle.TabIndex = 87;
            // 
            // cboLib
            // 
            this.cboLib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLib.FormattingEnabled = true;
            this.cboLib.Location = new System.Drawing.Point(76, 79);
            this.cboLib.Name = "cboLib";
            this.cboLib.Size = new System.Drawing.Size(162, 21);
            this.cboLib.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 86;
            this.label2.Text = "Libelle :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code_operation,
            this.NomComplet,
            this.libelle,
            this.lib_cycle,
            this.date_op,
            this.montant_payer,
            this.date_effe_op});
            this.dataGridView1.Location = new System.Drawing.Point(3, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 214);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // code_operation
            // 
            this.code_operation.DataPropertyName = "code_operation";
            this.code_operation.FillWeight = 200F;
            this.code_operation.HeaderText = "code_operation";
            this.code_operation.Name = "code_operation";
            this.code_operation.Visible = false;
            // 
            // NomComplet
            // 
            this.NomComplet.DataPropertyName = "NomComplet";
            this.NomComplet.HeaderText = "Adhérent";
            this.NomComplet.Name = "NomComplet";
            // 
            // libelle
            // 
            this.libelle.DataPropertyName = "libelle";
            this.libelle.HeaderText = "Libelle";
            this.libelle.Name = "libelle";
            // 
            // lib_cycle
            // 
            this.lib_cycle.DataPropertyName = "lib_cycle";
            this.lib_cycle.HeaderText = "Cycle";
            this.lib_cycle.Name = "lib_cycle";
            // 
            // date_op
            // 
            this.date_op.DataPropertyName = "date_op";
            this.date_op.HeaderText = "Date";
            this.date_op.Name = "date_op";
            // 
            // montant_payer
            // 
            this.montant_payer.DataPropertyName = "montant_payer";
            this.montant_payer.HeaderText = "Montant à payer";
            this.montant_payer.Name = "montant_payer";
            // 
            // date_effe_op
            // 
            this.date_effe_op.DataPropertyName = "date_effe_op";
            this.date_effe_op.HeaderText = "Date effective";
            this.date_effe_op.Name = "date_effe_op";
            // 
            // Enregistrement
            // 
            this.Enregistrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Enregistrement.Controls.Add(this.cboAdhe);
            this.Enregistrement.Controls.Add(this.label7);
            this.Enregistrement.Controls.Add(this.dtpDateEffe);
            this.Enregistrement.Controls.Add(this.label6);
            this.Enregistrement.Controls.Add(this.dtpDate);
            this.Enregistrement.Controls.Add(this.label3);
            this.Enregistrement.Controls.Add(this.txtMontant);
            this.Enregistrement.Controls.Add(this.label1);
            this.Enregistrement.Controls.Add(this.label4);
            this.Enregistrement.Controls.Add(this.cboCycle);
            this.Enregistrement.Controls.Add(this.cboLib);
            this.Enregistrement.Controls.Add(this.label2);
            this.Enregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregistrement.Location = new System.Drawing.Point(3, 3);
            this.Enregistrement.Name = "Enregistrement";
            this.Enregistrement.Size = new System.Drawing.Size(472, 171);
            this.Enregistrement.TabIndex = 89;
            this.Enregistrement.TabStop = false;
            this.Enregistrement.Text = "Enregistrements";
            // 
            // cboAdhe
            // 
            this.cboAdhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdhe.FormattingEnabled = true;
            this.cboAdhe.Location = new System.Drawing.Point(76, 30);
            this.cboAdhe.Name = "cboAdhe";
            this.cboAdhe.Size = new System.Drawing.Size(162, 21);
            this.cboAdhe.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 97;
            this.label7.Text = "Adhérent :";
            // 
            // dtpDateEffe
            // 
            this.dtpDateEffe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEffe.Location = new System.Drawing.Point(334, 130);
            this.dtpDateEffe.Name = "dtpDateEffe";
            this.dtpDateEffe.Size = new System.Drawing.Size(117, 20);
            this.dtpDateEffe.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 30);
            this.label6.TabIndex = 94;
            this.label6.Text = "Date\r\neffective :";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.DarkCyan;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(18, 116);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(106, 36);
            this.btnFermer.TabIndex = 131;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click_1);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Image = global::gTontine.Properties.Resources._new;
            this.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnregistrer.Location = new System.Drawing.Point(18, 33);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(106, 36);
            this.btnEnregistrer.TabIndex = 129;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click_1);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Image = global::gTontine.Properties.Resources.delete;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(18, 74);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(106, 36);
            this.btnSupprimer.TabIndex = 130;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // frmOpération
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(624, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Enregistrement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOpération";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOpération";
            this.Load += new System.EventHandler(this.frmOpération_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Enregistrement.ResumeLayout(false);
            this.Enregistrement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCycle;
        private System.Windows.Forms.ComboBox cboLib;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Enregistrement;
        private System.Windows.Forms.DateTimePicker dtpDateEffe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboAdhe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomComplet;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn lib_cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_op;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_payer;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_effe_op;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
    }
}