namespace GestionCommercialeUIW
{
    partial class frmNouveauContact
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
            this.lblClient = new System.Windows.Forms.Label();
            this.lblContactNumClient = new System.Windows.Forms.Label();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.groupBoxIdentification = new System.Windows.Forms.GroupBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.txtBoxPrenomContact = new System.Windows.Forms.TextBox();
            this.txtBoxNomContact = new System.Windows.Forms.TextBox();
            this.picBoxPhotoContact = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOkContact = new System.Windows.Forms.Button();
            this.btnAnnulerContact = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxFonctionMetier = new System.Windows.Forms.ComboBox();
            this.groupBoxIdentification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhotoContact)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(13, 13);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(39, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client :";
            // 
            // lblContactNumClient
            // 
            this.lblContactNumClient.Location = new System.Drawing.Point(58, 13);
            this.lblContactNumClient.Name = "lblContactNumClient";
            this.lblContactNumClient.Size = new System.Drawing.Size(34, 13);
            this.lblContactNumClient.TabIndex = 1;
            this.lblContactNumClient.Text = "label1";
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(115, 13);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(35, 13);
            this.lblNomClient.TabIndex = 2;
            this.lblNomClient.Text = "label1";
            // 
            // groupBoxIdentification
            // 
            this.groupBoxIdentification.Controls.Add(this.txtBoxMail);
            this.groupBoxIdentification.Controls.Add(this.txtBoxTel);
            this.groupBoxIdentification.Controls.Add(this.txtBoxPrenomContact);
            this.groupBoxIdentification.Controls.Add(this.txtBoxNomContact);
            this.groupBoxIdentification.Controls.Add(this.picBoxPhotoContact);
            this.groupBoxIdentification.Controls.Add(this.label4);
            this.groupBoxIdentification.Controls.Add(this.label3);
            this.groupBoxIdentification.Controls.Add(this.label2);
            this.groupBoxIdentification.Controls.Add(this.label1);
            this.groupBoxIdentification.Location = new System.Drawing.Point(13, 46);
            this.groupBoxIdentification.Name = "groupBoxIdentification";
            this.groupBoxIdentification.Size = new System.Drawing.Size(419, 169);
            this.groupBoxIdentification.TabIndex = 3;
            this.groupBoxIdentification.TabStop = false;
            this.groupBoxIdentification.Text = "Identification";
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(72, 126);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(199, 20);
            this.txtBoxMail.TabIndex = 8;
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(72, 97);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(199, 20);
            this.txtBoxTel.TabIndex = 7;
            // 
            // txtBoxPrenomContact
            // 
            this.txtBoxPrenomContact.Location = new System.Drawing.Point(72, 70);
            this.txtBoxPrenomContact.Name = "txtBoxPrenomContact";
            this.txtBoxPrenomContact.Size = new System.Drawing.Size(199, 20);
            this.txtBoxPrenomContact.TabIndex = 6;
            // 
            // txtBoxNomContact
            // 
            this.txtBoxNomContact.Location = new System.Drawing.Point(72, 41);
            this.txtBoxNomContact.Name = "txtBoxNomContact";
            this.txtBoxNomContact.Size = new System.Drawing.Size(199, 20);
            this.txtBoxNomContact.TabIndex = 5;
            this.txtBoxNomContact.TextChanged += new System.EventHandler(this.txtBoxNomContact_TextChanged);
            // 
            // picBoxPhotoContact
            // 
            this.picBoxPhotoContact.Location = new System.Drawing.Point(298, 41);
            this.picBoxPhotoContact.Name = "picBoxPhotoContact";
            this.picBoxPhotoContact.Size = new System.Drawing.Size(106, 94);
            this.picBoxPhotoContact.TabIndex = 4;
            this.picBoxPhotoContact.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Téléphone : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // btnOkContact
            // 
            this.btnOkContact.Location = new System.Drawing.Point(243, 305);
            this.btnOkContact.Name = "btnOkContact";
            this.btnOkContact.Size = new System.Drawing.Size(75, 23);
            this.btnOkContact.TabIndex = 4;
            this.btnOkContact.Text = "OK";
            this.btnOkContact.UseVisualStyleBackColor = true;
            this.btnOkContact.Click += new System.EventHandler(this.btnOkContact_Click);
            // 
            // btnAnnulerContact
            // 
            this.btnAnnulerContact.Location = new System.Drawing.Point(342, 305);
            this.btnAnnulerContact.Name = "btnAnnulerContact";
            this.btnAnnulerContact.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerContact.TabIndex = 5;
            this.btnAnnulerContact.Text = "Annuler";
            this.btnAnnulerContact.UseVisualStyleBackColor = true;
            this.btnAnnulerContact.Click += new System.EventHandler(this.btnAnnulerContact_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fonction :";
            // 
            // cmbBoxFonctionMetier
            // 
            this.cmbBoxFonctionMetier.FormattingEnabled = true;
            this.cmbBoxFonctionMetier.Location = new System.Drawing.Point(85, 252);
            this.cmbBoxFonctionMetier.Name = "cmbBoxFonctionMetier";
            this.cmbBoxFonctionMetier.Size = new System.Drawing.Size(199, 21);
            this.cmbBoxFonctionMetier.TabIndex = 7;
            // 
            // frmNouveauContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 344);
            this.Controls.Add(this.cmbBoxFonctionMetier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAnnulerContact);
            this.Controls.Add(this.btnOkContact);
            this.Controls.Add(this.groupBoxIdentification);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.lblContactNumClient);
            this.Controls.Add(this.lblClient);
            this.Name = "frmNouveauContact";
            this.Text = "Saisie d\'un nouveau Contact";
            this.groupBoxIdentification.ResumeLayout(false);
            this.groupBoxIdentification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhotoContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblContactNumClient;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.GroupBox groupBoxIdentification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxPrenomContact;
        private System.Windows.Forms.TextBox txtBoxNomContact;
        private System.Windows.Forms.PictureBox picBoxPhotoContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOkContact;
        private System.Windows.Forms.Button btnAnnulerContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxFonctionMetier;
    }
}