namespace GestionCommercialeUIW
{
    partial class frmConsultClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.textAdresse1 = new System.Windows.Forms.TextBox();
            this.rue = new System.Windows.Forms.TextBox();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.txtNumClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNature = new System.Windows.Forms.TextBox();
            this.txtActivite = new System.Windows.Forms.TextBox();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.txtEffectif = new System.Windows.Forms.TextBox();
            this.Nature = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CA = new System.Windows.Forms.Label();
            this.Effectif = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkPrive = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Fonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Téléphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVille);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtCP);
            this.groupBox1.Controls.Add(this.textAdresse1);
            this.groupBox1.Controls.Add(this.rue);
            this.groupBox1.Controls.Add(this.txtRSocial);
            this.groupBox1.Controls.Add(this.txtNumClient);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identification";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(274, 144);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 11;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(168, 173);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 10;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(168, 144);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 20);
            this.txtCP.TabIndex = 9;
            // 
            // textAdresse1
            // 
            this.textAdresse1.Location = new System.Drawing.Point(168, 118);
            this.textAdresse1.Name = "textAdresse1";
            this.textAdresse1.Size = new System.Drawing.Size(375, 20);
            this.textAdresse1.TabIndex = 7;
            // 
            // rue
            // 
            this.rue.Location = new System.Drawing.Point(168, 86);
            this.rue.Name = "rue";
            this.rue.Size = new System.Drawing.Size(375, 20);
            this.rue.TabIndex = 6;
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(168, 60);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(100, 20);
            this.txtRSocial.TabIndex = 5;
            // 
            // txtNumClient
            // 
            this.txtNumClient.Location = new System.Drawing.Point(168, 34);
            this.txtNumClient.Name = "txtNumClient";
            this.txtNumClient.Size = new System.Drawing.Size(100, 20);
            this.txtNumClient.TabIndex = 4;
            this.txtNumClient.TextChanged += new System.EventHandler(this.txtNumClient_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "CP et Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Téléphone : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raison social :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro client :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNature);
            this.groupBox2.Controls.Add(this.txtActivite);
            this.groupBox2.Controls.Add(this.txtCA);
            this.groupBox2.Controls.Add(this.txtEffectif);
            this.groupBox2.Controls.Add(this.Nature);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CA);
            this.groupBox2.Controls.Add(this.Effectif);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.checkPrive);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caractéristiques";
            // 
            // txtNature
            // 
            this.txtNature.Location = new System.Drawing.Point(310, 98);
            this.txtNature.Name = "txtNature";
            this.txtNature.Size = new System.Drawing.Size(100, 20);
            this.txtNature.TabIndex = 9;
            // 
            // txtActivite
            // 
            this.txtActivite.Location = new System.Drawing.Point(79, 101);
            this.txtActivite.Name = "txtActivite";
            this.txtActivite.Size = new System.Drawing.Size(100, 20);
            this.txtActivite.TabIndex = 8;
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(292, 60);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(100, 20);
            this.txtCA.TabIndex = 7;
            // 
            // txtEffectif
            // 
            this.txtEffectif.Location = new System.Drawing.Point(79, 60);
            this.txtEffectif.Name = "txtEffectif";
            this.txtEffectif.Size = new System.Drawing.Size(100, 20);
            this.txtEffectif.TabIndex = 6;
            // 
            // Nature
            // 
            this.Nature.AutoSize = true;
            this.Nature.Location = new System.Drawing.Point(256, 101);
            this.Nature.Name = "Nature";
            this.Nature.Size = new System.Drawing.Size(48, 13);
            this.Nature.TabIndex = 5;
            this.Nature.Text = "Nature : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Activité : ";
            // 
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.Location = new System.Drawing.Point(256, 63);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(30, 13);
            this.CA.TabIndex = 3;
            this.CA.Text = "CA : ";
            // 
            // Effectif
            // 
            this.Effectif.AutoSize = true;
            this.Effectif.Location = new System.Drawing.Point(24, 63);
            this.Effectif.Name = "Effectif";
            this.Effectif.Size = new System.Drawing.Size(49, 13);
            this.Effectif.TabIndex = 2;
            this.Effectif.Text = "Effectif : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Privé";
            // 
            // checkPrive
            // 
            this.checkPrive.AutoSize = true;
            this.checkPrive.Location = new System.Drawing.Point(27, 32);
            this.checkPrive.Name = "checkPrive";
            this.checkPrive.Size = new System.Drawing.Size(15, 14);
            this.checkPrive.TabIndex = 0;
            this.checkPrive.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Modifier Client";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Nouveau client";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(491, 561);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Fermer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Contacts";
            // 
            // Fonction
            // 
            this.Fonction.Frozen = true;
            this.Fonction.HeaderText = "Fonction";
            this.Fonction.Name = "Fonction";
            // 
            // Email
            // 
            this.Email.Frozen = true;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Téléphone
            // 
            this.Téléphone.Frozen = true;
            this.Téléphone.HeaderText = "Téléphone";
            this.Téléphone.Name = "Téléphone";
            // 
            // Prénom
            // 
            this.Prénom.Frozen = true;
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            // 
            // Nom
            // 
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prénom,
            this.Téléphone,
            this.Email,
            this.Fonction});
            this.dataGridView1.Location = new System.Drawing.Point(23, 446);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 93);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmConsultClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 596);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultClient";
            this.Text = "Consultation Client";
            this.Load += new System.EventHandler(this.frmConsultClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox textAdresse1;
        private System.Windows.Forms.TextBox rue;
        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.TextBox txtNumClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNature;
        private System.Windows.Forms.TextBox txtActivite;
        private System.Windows.Forms.TextBox txtCA;
        private System.Windows.Forms.TextBox txtEffectif;
        private System.Windows.Forms.Label Nature;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CA;
        private System.Windows.Forms.Label Effectif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkPrive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fonction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Téléphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridView dataGridView1;

      
    }
}