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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxIdentification.SuspendLayout();
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
            this.lblContactNumClient.Size = new System.Drawing.Size(100, 13);
            this.lblContactNumClient.TabIndex = 1;
            this.lblContactNumClient.Text = "label1";
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(98, 13);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(35, 13);
            this.lblNomClient.TabIndex = 2;
            this.lblNomClient.Text = "label1";
            // 
            // groupBoxIdentification
            // 
            this.groupBoxIdentification.Controls.Add(this.label3);
            this.groupBoxIdentification.Controls.Add(this.label2);
            this.groupBoxIdentification.Controls.Add(this.label1);
            this.groupBoxIdentification.Location = new System.Drawing.Point(13, 46);
            this.groupBoxIdentification.Name = "groupBoxIdentification";
            this.groupBoxIdentification.Size = new System.Drawing.Size(775, 265);
            this.groupBoxIdentification.TabIndex = 3;
            this.groupBoxIdentification.TabStop = false;
            this.groupBoxIdentification.Text = "Identification";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // NouveauContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxIdentification);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.lblContactNumClient);
            this.Controls.Add(this.lblClient);
            this.Name = "NouveauContact";
            this.Text = "Saisie d\'un nouveau Contact";
            this.groupBoxIdentification.ResumeLayout(false);
            this.groupBoxIdentification.PerformLayout();
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
    }
}