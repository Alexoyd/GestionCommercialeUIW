namespace GestionCommercialeUIW
{
    partial class AboutBox1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
            this.lblNomProduit = new System.Windows.Forms.Label();
            this.lblversion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblNomSociete = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomProduit
            // 
            this.lblNomProduit.AutoSize = true;
            this.lblNomProduit.Location = new System.Drawing.Point(12, 172);
            this.lblNomProduit.Name = "lblNomProduit";
            this.lblNomProduit.Size = new System.Drawing.Size(85, 13);
            this.lblNomProduit.TabIndex = 0;
            this.lblNomProduit.Text = "Nom du produit :";
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Location = new System.Drawing.Point(12, 200);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(42, 13);
            this.lblversion.TabIndex = 1;
            this.lblversion.Text = "Version";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(12, 230);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(51, 13);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Copyright";
            // 
            // lblNomSociete
            // 
            this.lblNomSociete.AutoSize = true;
            this.lblNomSociete.Location = new System.Drawing.Point(12, 258);
            this.lblNomSociete.Name = "lblNomSociete";
            this.lblNomSociete.Size = new System.Drawing.Size(92, 13);
            this.lblNomSociete.TabIndex = 3;
            this.lblNomSociete.Text = "Nom de la société";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(192, 248);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 143);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(147, 196);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 7;
            // 
            // AboutBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 315);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.lblNomSociete);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.lblNomProduit);
            this.Name = "AboutBox1";
            this.Text = "AboutBox1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomProduit;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblNomSociete;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}