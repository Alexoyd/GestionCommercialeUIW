namespace GestionCommercialeUIW
{
    partial class frmModifContact
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
            this.cmbBoxFonctionMetier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnnulerContact = new System.Windows.Forms.Button();
            this.btnOkContact = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.txtBoxPrenomContact = new System.Windows.Forms.TextBox();
            this.txtBoxNomContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxIdentification = new System.Windows.Forms.GroupBox();
            this.picBoxPhotoContact = new System.Windows.Forms.PictureBox();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblContactNumClient = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.groupBoxIdentification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhotoContact)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxFonctionMetier
            // 
            this.cmbBoxFonctionMetier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFonctionMetier.FormattingEnabled = true;
            this.cmbBoxFonctionMetier.Location = new System.Drawing.Point(84, 247);
            this.cmbBoxFonctionMetier.Name = "cmbBoxFonctionMetier";
            this.cmbBoxFonctionMetier.Size = new System.Drawing.Size(199, 21);
            this.cmbBoxFonctionMetier.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fonction :";
            // 
            // btnAnnulerContact
            // 
            this.btnAnnulerContact.Location = new System.Drawing.Point(341, 300);
            this.btnAnnulerContact.Name = "btnAnnulerContact";
            this.btnAnnulerContact.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerContact.TabIndex = 14;
            this.btnAnnulerContact.Text = "Annuler";
            this.btnAnnulerContact.UseVisualStyleBackColor = true;
            this.btnAnnulerContact.Click += new System.EventHandler(this.btnAnnulerContact_Click);
            // 
            // btnOkContact
            // 
            this.btnOkContact.Location = new System.Drawing.Point(242, 300);
            this.btnOkContact.Name = "btnOkContact";
            this.btnOkContact.Size = new System.Drawing.Size(75, 23);
            this.btnOkContact.TabIndex = 13;
            this.btnOkContact.Text = "OK";
            this.btnOkContact.UseVisualStyleBackColor = true;
            this.btnOkContact.Click += new System.EventHandler(this.btnOkContact_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(298, 129);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(106, 23);
            this.btnImage.TabIndex = 8;
            this.btnImage.Text = "Choisir une image..";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(72, 126);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(199, 20);
            this.txtBoxMail.TabIndex = 7;
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(72, 97);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(199, 20);
            this.txtBoxTel.TabIndex = 5;
            // 
            // txtBoxPrenomContact
            // 
            this.txtBoxPrenomContact.Location = new System.Drawing.Point(72, 70);
            this.txtBoxPrenomContact.Name = "txtBoxPrenomContact";
            this.txtBoxPrenomContact.Size = new System.Drawing.Size(199, 20);
            this.txtBoxPrenomContact.TabIndex = 3;
            // 
            // txtBoxNomContact
            // 
            this.txtBoxNomContact.Location = new System.Drawing.Point(72, 41);
            this.txtBoxNomContact.Name = "txtBoxNomContact";
            this.txtBoxNomContact.Size = new System.Drawing.Size(199, 20);
            this.txtBoxNomContact.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Téléphone : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
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
            // groupBoxIdentification
            // 
            this.groupBoxIdentification.Controls.Add(this.btnImage);
            this.groupBoxIdentification.Controls.Add(this.txtBoxMail);
            this.groupBoxIdentification.Controls.Add(this.txtBoxTel);
            this.groupBoxIdentification.Controls.Add(this.txtBoxPrenomContact);
            this.groupBoxIdentification.Controls.Add(this.txtBoxNomContact);
            this.groupBoxIdentification.Controls.Add(this.picBoxPhotoContact);
            this.groupBoxIdentification.Controls.Add(this.label4);
            this.groupBoxIdentification.Controls.Add(this.label3);
            this.groupBoxIdentification.Controls.Add(this.label2);
            this.groupBoxIdentification.Controls.Add(this.label1);
            this.groupBoxIdentification.Location = new System.Drawing.Point(12, 41);
            this.groupBoxIdentification.Name = "groupBoxIdentification";
            this.groupBoxIdentification.Size = new System.Drawing.Size(419, 169);
            this.groupBoxIdentification.TabIndex = 10;
            this.groupBoxIdentification.TabStop = false;
            this.groupBoxIdentification.Text = "Identification";
            // 
            // picBoxPhotoContact
            // 
            this.picBoxPhotoContact.Image = global::GestionCommercialeUIW.Properties.Resources.c160d49f7a842f408051bbada040b7d154bbcaf5_full;
            this.picBoxPhotoContact.Location = new System.Drawing.Point(298, 23);
            this.picBoxPhotoContact.Name = "picBoxPhotoContact";
            this.picBoxPhotoContact.Size = new System.Drawing.Size(106, 94);
            this.picBoxPhotoContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPhotoContact.TabIndex = 4;
            this.picBoxPhotoContact.TabStop = false;
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(131, 8);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(35, 13);
            this.lblNomClient.TabIndex = 9;
            this.lblNomClient.Text = "label1";
            // 
            // lblContactNumClient
            // 
            this.lblContactNumClient.AutoSize = true;
            this.lblContactNumClient.Location = new System.Drawing.Point(57, 8);
            this.lblContactNumClient.Name = "lblContactNumClient";
            this.lblContactNumClient.Size = new System.Drawing.Size(35, 13);
            this.lblContactNumClient.TabIndex = 8;
            this.lblContactNumClient.Text = "label1";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(12, 8);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(39, 13);
            this.lblClient.TabIndex = 7;
            this.lblClient.Text = "Client :";
            // 
            // frmModifContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 353);
            this.Controls.Add(this.cmbBoxFonctionMetier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAnnulerContact);
            this.Controls.Add(this.btnOkContact);
            this.Controls.Add(this.groupBoxIdentification);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.lblContactNumClient);
            this.Controls.Add(this.lblClient);
            this.Name = "frmModifContact";
            this.Text = "frmModifContact";
            this.Load += new System.EventHandler(this.frmModifContact_Load);
            this.groupBoxIdentification.ResumeLayout(false);
            this.groupBoxIdentification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhotoContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxFonctionMetier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnnulerContact;
        private System.Windows.Forms.Button btnOkContact;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxPrenomContact;
        private System.Windows.Forms.TextBox txtBoxNomContact;
        private System.Windows.Forms.PictureBox picBoxPhotoContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxIdentification;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Label lblContactNumClient;
        private System.Windows.Forms.Label lblClient;
    }
}