namespace WindowsFormsApp1
{
    partial class frmModifClient
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxIdentif = new System.Windows.Forms.GroupBox();
            this.txtBoxTelephone = new System.Windows.Forms.TextBox();
            this.txtBoxCP = new System.Windows.Forms.TextBox();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.txtBoxRaisonSocial = new System.Windows.Forms.TextBox();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.lblNumClient = new System.Windows.Forms.Label();
            this.lblRaisonSoiale = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblCPVille = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblNUM = new System.Windows.Forms.Label();
            this.grpBoxCaract = new System.Windows.Forms.GroupBox();
            this.cmbBoxNature = new System.Windows.Forms.ComboBox();
            this.cmbBoxActivité = new System.Windows.Forms.ComboBox();
            this.txtBoxCA = new System.Windows.Forms.TextBox();
            this.txtBoxEffectif = new System.Windows.Forms.TextBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblActivite = new System.Windows.Forms.Label();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.chkBoxPrive = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grpBoxIdentif.SuspendLayout();
            this.grpBoxCaract.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxIdentif
            // 
            this.grpBoxIdentif.Controls.Add(this.txtBoxTelephone);
            this.grpBoxIdentif.Controls.Add(this.txtBoxCP);
            this.grpBoxIdentif.Controls.Add(this.txtBoxAdresse);
            this.grpBoxIdentif.Controls.Add(this.txtBoxRaisonSocial);
            this.grpBoxIdentif.Controls.Add(this.txtBoxVille);
            this.grpBoxIdentif.Controls.Add(this.lblNumClient);
            this.grpBoxIdentif.Controls.Add(this.lblRaisonSoiale);
            this.grpBoxIdentif.Controls.Add(this.lblAdresse);
            this.grpBoxIdentif.Controls.Add(this.lblCPVille);
            this.grpBoxIdentif.Controls.Add(this.lblTelephone);
            this.grpBoxIdentif.Controls.Add(this.lblNUM);
            this.grpBoxIdentif.Location = new System.Drawing.Point(12, 12);
            this.grpBoxIdentif.Name = "grpBoxIdentif";
            this.grpBoxIdentif.Size = new System.Drawing.Size(409, 201);
            this.grpBoxIdentif.TabIndex = 0;
            this.grpBoxIdentif.TabStop = false;
            this.grpBoxIdentif.Text = "Identification";
            // 
            // txtBoxTelephone
            // 
            this.txtBoxTelephone.Location = new System.Drawing.Point(148, 169);
            this.txtBoxTelephone.Name = "txtBoxTelephone";
            this.txtBoxTelephone.Size = new System.Drawing.Size(160, 20);
            this.txtBoxTelephone.TabIndex = 11;
            // 
            // txtBoxCP
            // 
            this.txtBoxCP.Location = new System.Drawing.Point(148, 137);
            this.txtBoxCP.Name = "txtBoxCP";
            this.txtBoxCP.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCP.TabIndex = 10;
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Location = new System.Drawing.Point(148, 101);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(255, 20);
            this.txtBoxAdresse.TabIndex = 9;
            // 
            // txtBoxRaisonSocial
            // 
            this.txtBoxRaisonSocial.Location = new System.Drawing.Point(148, 66);
            this.txtBoxRaisonSocial.Name = "txtBoxRaisonSocial";
            this.txtBoxRaisonSocial.Size = new System.Drawing.Size(255, 20);
            this.txtBoxRaisonSocial.TabIndex = 8;
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(254, 137);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(149, 20);
            this.txtBoxVille.TabIndex = 7;
            // 
            // lblNumClient
            // 
            this.lblNumClient.AutoSize = true;
            this.lblNumClient.Location = new System.Drawing.Point(6, 30);
            this.lblNumClient.Name = "lblNumClient";
            this.lblNumClient.Size = new System.Drawing.Size(78, 13);
            this.lblNumClient.TabIndex = 1;
            this.lblNumClient.Text = "Numéro client :";
            // 
            // lblRaisonSoiale
            // 
            this.lblRaisonSoiale.AutoSize = true;
            this.lblRaisonSoiale.Location = new System.Drawing.Point(6, 69);
            this.lblRaisonSoiale.Name = "lblRaisonSoiale";
            this.lblRaisonSoiale.Size = new System.Drawing.Size(84, 13);
            this.lblRaisonSoiale.TabIndex = 2;
            this.lblRaisonSoiale.Text = "Raison Sociale :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(6, 104);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblCPVille
            // 
            this.lblCPVille.AutoSize = true;
            this.lblCPVille.Location = new System.Drawing.Point(6, 140);
            this.lblCPVille.Name = "lblCPVille";
            this.lblCPVille.Size = new System.Drawing.Size(58, 13);
            this.lblCPVille.TabIndex = 4;
            this.lblCPVille.Text = "CP && Ville :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(6, 172);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 5;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblNUM
            // 
            this.lblNUM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNUM.Location = new System.Drawing.Point(148, 29);
            this.lblNUM.Name = "lblNUM";
            this.lblNUM.Size = new System.Drawing.Size(100, 23);
            this.lblNUM.TabIndex = 6;
            // 
            // grpBoxCaract
            // 
            this.grpBoxCaract.Controls.Add(this.cmbBoxNature);
            this.grpBoxCaract.Controls.Add(this.cmbBoxActivité);
            this.grpBoxCaract.Controls.Add(this.txtBoxCA);
            this.grpBoxCaract.Controls.Add(this.txtBoxEffectif);
            this.grpBoxCaract.Controls.Add(this.lblNature);
            this.grpBoxCaract.Controls.Add(this.lblCA);
            this.grpBoxCaract.Controls.Add(this.lblActivite);
            this.grpBoxCaract.Controls.Add(this.lblEffectif);
            this.grpBoxCaract.Controls.Add(this.chkBoxPrive);
            this.grpBoxCaract.Location = new System.Drawing.Point(12, 219);
            this.grpBoxCaract.Name = "grpBoxCaract";
            this.grpBoxCaract.Size = new System.Drawing.Size(435, 149);
            this.grpBoxCaract.TabIndex = 0;
            this.grpBoxCaract.TabStop = false;
            this.grpBoxCaract.Text = "Caractéristiques";
            // 
            // cmbBoxNature
            // 
            this.cmbBoxNature.FormattingEnabled = true;
            this.cmbBoxNature.Location = new System.Drawing.Point(302, 104);
            this.cmbBoxNature.Name = "cmbBoxNature";
            this.cmbBoxNature.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxNature.TabIndex = 8;
            // 
            // cmbBoxActivité
            // 
            this.cmbBoxActivité.FormattingEnabled = true;
            this.cmbBoxActivité.Location = new System.Drawing.Point(82, 104);
            this.cmbBoxActivité.Name = "cmbBoxActivité";
            this.cmbBoxActivité.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxActivité.TabIndex = 7;
            // 
            // txtBoxCA
            // 
            this.txtBoxCA.Location = new System.Drawing.Point(277, 78);
            this.txtBoxCA.Name = "txtBoxCA";
            this.txtBoxCA.Size = new System.Drawing.Size(146, 20);
            this.txtBoxCA.TabIndex = 6;
            // 
            // txtBoxEffectif
            // 
            this.txtBoxEffectif.Location = new System.Drawing.Point(82, 78);
            this.txtBoxEffectif.Name = "txtBoxEffectif";
            this.txtBoxEffectif.Size = new System.Drawing.Size(140, 20);
            this.txtBoxEffectif.TabIndex = 5;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(236, 107);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(48, 13);
            this.lblNature.TabIndex = 4;
            this.lblNature.Text = "Nature : ";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(236, 81);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(27, 13);
            this.lblCA.TabIndex = 3;
            this.lblCA.Text = "CA :";
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Location = new System.Drawing.Point(29, 107);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(48, 13);
            this.lblActivite.TabIndex = 2;
            this.lblActivite.Text = "Activité :";
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(27, 81);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(46, 13);
            this.lblEffectif.TabIndex = 1;
            this.lblEffectif.Text = "Effectif :";
            // 
            // chkBoxPrive
            // 
            this.chkBoxPrive.AutoSize = true;
            this.chkBoxPrive.Location = new System.Drawing.Point(30, 38);
            this.chkBoxPrive.Name = "chkBoxPrive";
            this.chkBoxPrive.Size = new System.Drawing.Size(50, 17);
            this.chkBoxPrive.TabIndex = 0;
            this.chkBoxPrive.Text = "Privé";
            this.chkBoxPrive.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(266, 384);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 32);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(339, 384);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(96, 32);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // frmModifClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 422);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.grpBoxCaract);
            this.Controls.Add(this.grpBoxIdentif);
            this.Name = "frmModifClient";
            this.Text = "Modification Client";
            this.grpBoxIdentif.ResumeLayout(false);
            this.grpBoxIdentif.PerformLayout();
            this.grpBoxCaract.ResumeLayout(false);
            this.grpBoxCaract.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxIdentif;
        private System.Windows.Forms.TextBox txtBoxTelephone;
        private System.Windows.Forms.TextBox txtBoxCP;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.TextBox txtBoxRaisonSocial;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.Label lblNumClient;
        private System.Windows.Forms.Label lblRaisonSoiale;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblCPVille;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblNUM;
        private System.Windows.Forms.GroupBox grpBoxCaract;
        private System.Windows.Forms.ComboBox cmbBoxNature;
        private System.Windows.Forms.ComboBox cmbBoxActivité;
        private System.Windows.Forms.TextBox txtBoxCA;
        private System.Windows.Forms.TextBox txtBoxEffectif;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.CheckBox chkBoxPrive;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}

