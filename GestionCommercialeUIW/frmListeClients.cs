using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommercialeUIW
{
    public partial class frmListeClients : Form
    {
        BindingSource bs = new BindingSource();

        private static frmListeClients singleton = null;

        private frmListeClients()
        {
            InitializeComponent();
        }
        public static frmListeClients CreateFormulaire()
        {
            if (singleton == null)
            {
                singleton = new frmListeClients();
            }
            return singleton;
        }

        private void btnNouveauClient_Click(object sender, EventArgs e)
        {
            // instancie un form de saisie de client et l'affiche en modal
            frmNouveauClient frmAjout = new frmNouveauClient();

            // si on sort de la saisie par OK
            if (frmAjout.ShowDialog() == DialogResult.OK)
            {
                grdClients.DataSource = null;
                afficheClients();
            }

        }

        public void afficheClients()
        {
            bs.DataSource = GestionCommercialeDll.Donnees.TabClients;
            grdClients.DataSource = GestionCommercialeDll.Donnees.TabClients;

            grdClients.Columns[0].Visible = false;
            grdClients.Columns[1].HeaderText = "Raison Sociale";
            grdClients.Columns[2].Visible = false;
            grdClients.Columns[3].Visible = false;
            grdClients.Columns[4].HeaderText = "Ville";
            grdClients.Columns[5].HeaderText = "Code Postal";
            grdClients.Columns[6].Visible = false;
            grdClients.Columns[7].HeaderText = "Privé ?";
            grdClients.Columns[8].Visible = false;
            grdClients.Columns[9].Visible = false;
            grdClients.Columns[10].HeaderText = "Activité";
            grdClients.Columns[11].HeaderText = "Nature";
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRecherche.Text != "")
                {
                    BindingList<GestionCommercialeDll.Client> filtered = new BindingList<GestionCommercialeDll.Client>(GestionCommercialeDll.Donnees.TabClients.Where(obj => obj.RaisonSociale.Contains(txtRecherche.Text)).ToList());

                    grdClients.DataSource = filtered;
                    grdClients.Update();
                    btnTous.Enabled = true;
                }

                else
                    MessageBox.Show("La recherche est vide", "Erreur", MessageBoxButtons.OK);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTous_Click(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
            btnTous.Enabled = false;

            grdClients.DataSource = null;

            grdClients.DataSource = GestionCommercialeDll.Donnees.TabClients;

            grdClients.Columns[0].Visible = false;
            grdClients.Columns[1].HeaderText = "Raison Sociale";
            grdClients.Columns[2].Visible = false;
            grdClients.Columns[3].Visible = false;
            grdClients.Columns[4].HeaderText = "Ville";
            grdClients.Columns[5].HeaderText = "Code Postal";
            grdClients.Columns[6].Visible = false;
            grdClients.Columns[7].HeaderText = "Privé ?";
            grdClients.Columns[8].Visible = false;
            grdClients.Columns[9].Visible = false;
            grdClients.Columns[10].HeaderText = "Activité";
            grdClients.Columns[11].HeaderText = "Nature";
        }

        private void grdClients_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // ouvrir la feuille détail en y affichant
                // le client correspondant à la ligne double-cliquée
                Int32 iClient; // rang du client dans le tableau
                               // récupérer indice du client cliqué en DataGridView

                iClient = this.grdClients.CurrentRow.Index;

                // instancier un objet client pointant vers
                // le client d'origine dans la collection
                GestionCommercialeDll.Client leClient = GestionCommercialeDll.Donnees.TabClients[iClient] as GestionCommercialeDll.Client;

                // instancier un form détail pour ce client
                frmConsultClient frmConsult = new frmConsultClient(leClient);

                // afficher le form détail en modal
                frmConsult.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Vous n'avez sélectionné aucun client");
            }
        }

        private void frmListeClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            singleton = null;
        }


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 iClient; // rang du client dans le tableau
                               // récupérer indice du client cliqué en DataGridView

                iClient = this.grdClients.CurrentRow.Index;

                // instancier un objet client pointant vers
                // le client d'origine dans la collection
                GestionCommercialeDll.Client leClient = GestionCommercialeDll.Donnees.TabClients[iClient] as GestionCommercialeDll.Client;

                GestionCommercialeDll.Donnees.TabClients.Remove(leClient);

                // en sortie du form détail, refraichir la datagridview
                //if (frmConsult.ShowDialog() == DialogResult.OK)
                //{

                //}
            }
            catch
            {
                MessageBox.Show("Vous n'avez sélectionné aucun client");
            }
        }
    }
}
