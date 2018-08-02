namespace GestionCommercialeUIW
{
    partial class frmListeClients
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
            this.gxbZoneRecherche = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnTous = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblRechercheRaisonSociale = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnNouveauClient = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.grdClients = new System.Windows.Forms.DataGridView();
            this.gxbZoneRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).BeginInit();
            this.SuspendLayout();
            // 
            // gxbZoneRecherche
            // 
            this.gxbZoneRecherche.Controls.Add(this.btnRechercher);
            this.gxbZoneRecherche.Controls.Add(this.btnTous);
            this.gxbZoneRecherche.Controls.Add(this.txtRecherche);
            this.gxbZoneRecherche.Controls.Add(this.lblRechercheRaisonSociale);
            this.gxbZoneRecherche.Location = new System.Drawing.Point(12, 12);
            this.gxbZoneRecherche.Name = "gxbZoneRecherche";
            this.gxbZoneRecherche.Size = new System.Drawing.Size(568, 57);
            this.gxbZoneRecherche.TabIndex = 0;
            this.gxbZoneRecherche.TabStop = false;
            this.gxbZoneRecherche.Text = "Recherche";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(406, 22);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnTous
            // 
            this.btnTous.Enabled = false;
            this.btnTous.Location = new System.Drawing.Point(487, 22);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(75, 23);
            this.btnTous.TabIndex = 2;
            this.btnTous.Text = "Tous";
            this.btnTous.UseVisualStyleBackColor = true;
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(99, 22);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(301, 20);
            this.txtRecherche.TabIndex = 1;
            // 
            // lblRechercheRaisonSociale
            // 
            this.lblRechercheRaisonSociale.AutoSize = true;
            this.lblRechercheRaisonSociale.Location = new System.Drawing.Point(6, 25);
            this.lblRechercheRaisonSociale.Name = "lblRechercheRaisonSociale";
            this.lblRechercheRaisonSociale.Size = new System.Drawing.Size(87, 13);
            this.lblRechercheRaisonSociale.TabIndex = 0;
            this.lblRechercheRaisonSociale.Text = "Raison Sociale : ";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(713, 415);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnNouveauClient
            // 
            this.btnNouveauClient.Location = new System.Drawing.Point(528, 415);
            this.btnNouveauClient.Name = "btnNouveauClient";
            this.btnNouveauClient.Size = new System.Drawing.Size(98, 23);
            this.btnNouveauClient.TabIndex = 5;
            this.btnNouveauClient.Text = "Nouveau Client";
            this.btnNouveauClient.UseVisualStyleBackColor = true;
            this.btnNouveauClient.Click += new System.EventHandler(this.btnNouveauClient_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(632, 415);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // grdClients
            // 
            this.grdClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClients.Location = new System.Drawing.Point(12, 75);
            this.grdClients.Name = "grdClients";
            this.grdClients.Size = new System.Drawing.Size(776, 334);
            this.grdClients.TabIndex = 7;
            // 
            // frmListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdClients);
            this.Controls.Add(this.btnNouveauClient);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.gxbZoneRecherche);
            this.Controls.Add(this.btnFermer);
            this.Name = "frmListeClients";
            this.Text = "Liste des clients";
            this.gxbZoneRecherche.ResumeLayout(false);
            this.gxbZoneRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gxbZoneRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRechercheRaisonSociale;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnNouveauClient;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridView grdClients;
    }
}