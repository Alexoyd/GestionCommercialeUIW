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
            this.okButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.lblNomSociete = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblversion = new System.Windows.Forms.Label();
            this.lblNomProduit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // textBoxDescription
            // 
            resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            // 
            // lblNomSociete
            // 
            resources.ApplyResources(this.lblNomSociete, "lblNomSociete");
            this.lblNomSociete.Name = "lblNomSociete";
            // 
            // lblCopyright
            // 
            resources.ApplyResources(this.lblCopyright, "lblCopyright");
            this.lblCopyright.Name = "lblCopyright";
            // 
            // lblversion
            // 
            resources.ApplyResources(this.lblversion, "lblversion");
            this.lblversion.Name = "lblversion";
            // 
            // lblNomProduit
            // 
            resources.ApplyResources(this.lblNomProduit, "lblNomProduit");
            this.lblNomProduit.Name = "lblNomProduit";
            // 
            // AboutBox1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNomSociete);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.lblNomProduit);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.okButton);
            this.Name = "AboutBox1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label lblNomSociete;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label lblNomProduit;
    }
}