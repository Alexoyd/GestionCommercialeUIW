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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSupContact = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lblVille.BackColor = System.Drawing.SystemColors.Control;
            this.lblVille.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(388, 160);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(166, 22);
            this.lblVille.TabIndex = 9;
            this.lblVille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoEllipsis = true;
            this.lblTelephone.BackColor = System.Drawing.SystemColors.Control;
            this.lblTelephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(147, 193);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(166, 22);
            this.lblTelephone.TabIndex = 11;
            this.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTelephone.Click += new System.EventHandler(this.lblTelephone_Click);
            // 
            // lblCP
            // 
            this.lblCP.BackColor = System.Drawing.SystemColors.Control;
            this.lblCP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(147, 160);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(166, 22);
            this.lblCP.TabIndex = 8;
            this.lblCP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCP.Click += new System.EventHandler(this.lblCP_Click);
            // 
            // lblAdresse1
            // 
            this.lblAdresse1.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdresse1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdresse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse1.Location = new System.Drawing.Point(147, 129);
            this.lblAdresse1.Name = "lblAdresse1";
            this.lblAdresse1.Size = new System.Drawing.Size(166, 22);
            this.lblAdresse1.TabIndex = 6;
            this.lblAdresse1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAdresse1.Click += new System.EventHandler(this.lblAdresse1_Click);
            // 
            // lblAdresse
            // 
            this.lblAdresse.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdresse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(147, 95);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(166, 22);
            this.lblAdresse.TabIndex = 5;
            this.lblAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAdresse.Click += new System.EventHandler(this.lblAdresse_Click);
            // 
            // lblRSociale
            // 
            this.lblRSociale.BackColor = System.Drawing.SystemColors.Control;
            this.lblRSociale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRSociale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRSociale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSociale.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblRSociale.Location = new System.Drawing.Point(147, 63);
            this.lblRSociale.Name = "lblRSociale";
            this.lblRSociale.Size = new System.Drawing.Size(166, 22);
            this.lblRSociale.TabIndex = 3;
            this.lblRSociale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRSociale.Click += new System.EventHandler(this.lblRSociale_Click);
            // 
            // lblNumClient
            // 
            this.lblNumClient.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumClient.Location = new System.Drawing.Point(147, 34);
            this.lblNumClient.Name = "lblNumClient";
            this.lblNumClient.Size = new System.Drawing.Size(166, 22);
            this.lblNumClient.TabIndex = 1;
            this.lblNumClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumClient.Click += new System.EventHandler(this.lblNumClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CP et Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Téléphone : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresse : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
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
            this.btnModifClient.Location = new System.Drawing.Point(389, 561);
            this.btnModifClient.Name = "btnModifClient";
            this.btnModifClient.Size = new System.Drawing.Size(96, 23);
            this.btnModifClient.TabIndex = 4;
            this.btnModifClient.Text = "Modifier Client";
            this.btnModifClient.UseVisualStyleBackColor = true;
            this.btnModifClient.Click += new System.EventHandler(this.btnModifClient_Click);
            // 
            // btnNouveauContactModif
            // 
            this.btnNouveauContactModif.Location = new System.Drawing.Point(202, 561);
            this.btnNouveauContactModif.Name = "btnNouveauContactModif";
            this.btnNouveauContactModif.Size = new System.Drawing.Size(100, 23);
            this.btnNouveauContactModif.TabIndex = 5;
            this.btnNouveauContactModif.Text = "Nouveau contact";
            this.btnNouveauContactModif.UseVisualStyleBackColor = true;
            this.btnNouveauContactModif.Click += new System.EventHandler(this.btnNouveauContactModif_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(491, 561);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 6;
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
            this.label11.TabIndex = 2;
            this.label11.Text = "Contacts";
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
            this.Effectif.Location = new System.Drawing.Point(65, 58);
            this.Effectif.Name = "Effectif";
            this.Effectif.Size = new System.Drawing.Size(49, 13);
            this.Effectif.TabIndex = 2;
            this.Effectif.Text = "Effectif : ";
            // 
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.Location = new System.Drawing.Point(326, 58);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(30, 13);
            this.CA.TabIndex = 4;
            this.CA.Text = "CA : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Activité : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Nature
            // 
            this.Nature.AutoSize = true;
            this.Nature.Location = new System.Drawing.Point(308, 96);
            this.Nature.Name = "Nature";
            this.Nature.Size = new System.Drawing.Size(48, 13);
            this.Nature.TabIndex = 8;
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
            this.lblNature.BackColor = System.Drawing.SystemColors.Control;
            this.lblNature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNature.ForeColor = System.Drawing.Color.Black;
            this.lblNature.Location = new System.Drawing.Point(388, 96);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(166, 22);
            this.lblNature.TabIndex = 9;
            this.lblNature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActivite
            // 
            this.lblActivite.BackColor = System.Drawing.SystemColors.Control;
            this.lblActivite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivite.Location = new System.Drawing.Point(147, 96);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(121, 22);
            this.lblActivite.TabIndex = 7;
            this.lblActivite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivite.Click += new System.EventHandler(this.lblActivite_Click);
            // 
            // lblCA
            // 
            this.lblCA.BackColor = System.Drawing.SystemColors.Control;
            this.lblCA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCA.Location = new System.Drawing.Point(388, 58);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(166, 22);
            this.lblCA.TabIndex = 5;
            this.lblCA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEffectif
            // 
            this.lblEffectif.BackColor = System.Drawing.SystemColors.Control;
            this.lblEffectif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEffectif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffectif.Location = new System.Drawing.Point(147, 58);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(121, 22);
            this.lblEffectif.TabIndex = 3;
            this.lblEffectif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEffectif.Click += new System.EventHandler(this.lblEffectif_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 446);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(575, 109);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // BtnSupContact
            // 
            this.BtnSupContact.Location = new System.Drawing.Point(308, 561);
            this.BtnSupContact.Name = "BtnSupContact";
            this.BtnSupContact.Size = new System.Drawing.Size(75, 23);
            this.BtnSupContact.TabIndex = 8;
            this.BtnSupContact.Text = "Supprimer";
            this.BtnSupContact.UseVisualStyleBackColor = true;
            this.BtnSupContact.Click += new System.EventHandler(this.BtnSupContact_Click);
            // 
            // frmConsultClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 612);
            this.Controls.Add(this.BtnSupContact);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnNouveauContactModif);
            this.Controls.Add(this.btnModifClient);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifClient;
        private System.Windows.Forms.Button btnNouveauContactModif;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNumClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Effectif;
        private System.Windows.Forms.Label CA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Nature;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblRSociale;
        internal System.Windows.Forms.Label lblTelephone;
        internal System.Windows.Forms.Label lblCP;
        internal System.Windows.Forms.Label lblAdresse1;
        internal System.Windows.Forms.Label lblAdresse;
        internal System.Windows.Forms.Label lblNature;
        internal System.Windows.Forms.Label lblActivite;
        internal System.Windows.Forms.Label lblCA;
        internal System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.CheckBox checkPrive;
        internal System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Button BtnSupContact;
    }
}