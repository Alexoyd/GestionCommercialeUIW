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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxNomContact = new System.Windows.Forms.TextBox();
            this.textBoxPrenomContact = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFonctionMetier = new System.Windows.Forms.ComboBox();
            this.groupBoxIdentification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupBoxIdentification.Controls.Add(this.textBoxMail);
            this.groupBoxIdentification.Controls.Add(this.textBoxTel);
            this.groupBoxIdentification.Controls.Add(this.textBoxPrenomContact);
            this.groupBoxIdentification.Controls.Add(this.textBoxNomContact);
            this.groupBoxIdentification.Controls.Add(this.pictureBox1);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(298, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 94);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxNomContact
            // 
            this.textBoxNomContact.Location = new System.Drawing.Point(72, 41);
            this.textBoxNomContact.Name = "textBoxNomContact";
            this.textBoxNomContact.Size = new System.Drawing.Size(199, 20);
            this.textBoxNomContact.TabIndex = 5;
            // 
            // textBoxPrenomContact
            // 
            this.textBoxPrenomContact.Location = new System.Drawing.Point(72, 70);
            this.textBoxPrenomContact.Name = "textBoxPrenomContact";
            this.textBoxPrenomContact.Size = new System.Drawing.Size(199, 20);
            this.textBoxPrenomContact.TabIndex = 6;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(72, 97);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(199, 20);
            this.textBoxTel.TabIndex = 7;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(72, 126);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(199, 20);
            this.textBoxMail.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // comboBoxFonctionMetier
            // 
            this.comboBoxFonctionMetier.FormattingEnabled = true;
            this.comboBoxFonctionMetier.Location = new System.Drawing.Point(85, 252);
            this.comboBoxFonctionMetier.Name = "comboBoxFonctionMetier";
            this.comboBoxFonctionMetier.Size = new System.Drawing.Size(199, 21);
            this.comboBoxFonctionMetier.TabIndex = 7;
            // 
            // frmNouveauContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 344);
            this.Controls.Add(this.comboBoxFonctionMetier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxIdentification);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.lblContactNumClient);
            this.Controls.Add(this.lblClient);
            this.Name = "frmNouveauContact";
            this.Text = "Saisie d\'un nouveau Contact";
            this.groupBoxIdentification.ResumeLayout(false);
            this.groupBoxIdentification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxPrenomContact;
        private System.Windows.Forms.TextBox textBoxNomContact;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFonctionMetier;
    }
}