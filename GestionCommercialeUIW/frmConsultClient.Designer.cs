﻿namespace GestionCommercialeUIW
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
            this.lblVille = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblAdresse1 = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblRSociale = new System.Windows.Forms.Label();
            this.lblNumClient = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifClient = new System.Windows.Forms.Button();
            this.btnNouveauContactModif = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Fonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Téléphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGContacts = new System.Windows.Forms.DataGridView();
            this.checkPrive = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Effectif = new System.Windows.Forms.Label();
            this.CA = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Nature = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblActivite = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGContacts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVille);
            this.groupBox1.Controls.Add(this.lblTelephone);
            this.groupBox1.Controls.Add(this.lblCP);
            this.groupBox1.Controls.Add(this.lblAdresse1);
            this.groupBox1.Controls.Add(this.lblAdresse);
            this.groupBox1.Controls.Add(this.lblRSociale);
            this.groupBox1.Controls.Add(this.lblNumClient);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identification";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(206, 147);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(0, 13);
            this.lblVille.TabIndex = 10;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(147, 173);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(0, 13);
            this.lblTelephone.TabIndex = 9;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(147, 147);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(0, 13);
            this.lblCP.TabIndex = 8;
            // 
            // lblAdresse1
            // 
            this.lblAdresse1.AutoSize = true;
            this.lblAdresse1.Location = new System.Drawing.Point(147, 116);
            this.lblAdresse1.Name = "lblAdresse1";
            this.lblAdresse1.Size = new System.Drawing.Size(0, 13);
            this.lblAdresse1.TabIndex = 7;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(147, 93);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(0, 13);
            this.lblAdresse.TabIndex = 6;
            // 
            // lblRSociale
            // 
            this.lblRSociale.AutoSize = true;
            this.lblRSociale.Location = new System.Drawing.Point(147, 63);
            this.lblRSociale.Name = "lblRSociale";
            this.lblRSociale.Size = new System.Drawing.Size(0, 13);
            this.lblRSociale.TabIndex = 5;
            // 
            // lblNumClient
            // 
            this.lblNumClient.AutoSize = true;
            this.lblNumClient.Location = new System.Drawing.Point(147, 34);
            this.lblNumClient.Name = "lblNumClient";
            this.lblNumClient.Size = new System.Drawing.Size(0, 13);
            this.lblNumClient.TabIndex = 4;
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
            // btnModifClient
            // 
            this.btnModifClient.Location = new System.Drawing.Point(283, 561);
            this.btnModifClient.Name = "btnModifClient";
            this.btnModifClient.Size = new System.Drawing.Size(96, 23);
            this.btnModifClient.TabIndex = 3;
            this.btnModifClient.Text = "Modifier Client";
            this.btnModifClient.UseVisualStyleBackColor = true;
            this.btnModifClient.Click += new System.EventHandler(this.btnModifClient_Click);
            // 
            // btnNouveauContactModif
            // 
            this.btnNouveauContactModif.Location = new System.Drawing.Point(385, 561);
            this.btnNouveauContactModif.Name = "btnNouveauContactModif";
            this.btnNouveauContactModif.Size = new System.Drawing.Size(100, 23);
            this.btnNouveauContactModif.TabIndex = 4;
            this.btnNouveauContactModif.Text = "Nouveau contact";
            this.btnNouveauContactModif.UseVisualStyleBackColor = true;
            this.btnNouveauContactModif.Click += new System.EventHandler(this.btnNouveauContactModif_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(491, 561);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
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
            // dGContacts
            // 
            this.dGContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prénom,
            this.Téléphone,
            this.Email,
            this.Fonction});
            this.dGContacts.Location = new System.Drawing.Point(23, 446);
            this.dGContacts.Name = "dGContacts";
            this.dGContacts.Size = new System.Drawing.Size(543, 93);
            this.dGContacts.TabIndex = 2;
            this.dGContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Privé";
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
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.Location = new System.Drawing.Point(256, 63);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(30, 13);
            this.CA.TabIndex = 3;
            this.CA.Text = "CA : ";
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
            // Nature
            // 
            this.Nature.AutoSize = true;
            this.Nature.Location = new System.Drawing.Point(256, 101);
            this.Nature.Name = "Nature";
            this.Nature.Size = new System.Drawing.Size(48, 13);
            this.Nature.TabIndex = 5;
            this.Nature.Text = "Nature : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNature);
            this.groupBox2.Controls.Add(this.lblActivite);
            this.groupBox2.Controls.Add(this.lblCA);
            this.groupBox2.Controls.Add(this.lblEffectif);
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
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(311, 101);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(0, 13);
            this.lblNature.TabIndex = 9;
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Location = new System.Drawing.Point(74, 101);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(0, 13);
            this.lblActivite.TabIndex = 8;
            this.lblActivite.Click += new System.EventHandler(this.lblActivite_Click);
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(293, 62);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(0, 13);
            this.lblCA.TabIndex = 7;
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(71, 63);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(0, 13);
            this.lblEffectif.TabIndex = 6;
            this.lblEffectif.Click += new System.EventHandler(this.lblEffectif_Click);
            // 
            // frmConsultClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 596);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnNouveauContactModif);
            this.Controls.Add(this.btnModifClient);
            this.Controls.Add(this.dGContacts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultClient";
            this.Text = "Consultation Client";
            this.Load += new System.EventHandler(this.frmConsultClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGContacts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifClient;
        private System.Windows.Forms.Button btnNouveauContactModif;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fonction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Téléphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridView dGContacts;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblAdresse1;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblRSociale;
        private System.Windows.Forms.Label lblNumClient;
        private System.Windows.Forms.CheckBox checkPrive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Effectif;
        private System.Windows.Forms.Label CA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Nature;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblEffectif;
    }
}