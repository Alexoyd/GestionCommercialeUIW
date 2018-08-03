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
        // DataTable : pour recopier les clients
        // (stockés en collection) ;
        // à relier au DataGridView pour personnaliser son affichage
        DataTable dt = new DataTable();
        DataRow dr; // ligne de la datatable

        private static frmListeClients singleton= null;
        
        private frmListeClients()
        {
            InitializeComponent();
            //this.afficheClients();

            // Ajout à la datatable des colonnes
            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Code Postal", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Privé ?", typeof(System.Boolean)));
            dt.Columns.Add(new DataColumn("Activité", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
        }
        public static frmListeClients CreateFormulaire()
        {
            if (singleton==null)
            {
                singleton = new frmListeClients();
            }
            return singleton;
        }

        private void btnNouveauClient_Click(object sender, EventArgs e)
        {
            // instancie un form de saisie de stagiaire et l'affiche en modal
            frmNouveauClient frmAjout = new frmNouveauClient();

            // si on sort de la saisie par OK
            if (frmAjout.ShowDialog() == DialogResult.OK)
                afficheClients();

        }

        public void afficheClients()
        {
            // boucle remplissage de la DataTable à partir de la collection
            for (int i = 0; i < GestionCommercialeDll.Donnees.TabClients.Count; i++)
            {
                // instanciation DataRow (=ligne de DataTable)
                dr = dt.NewRow();

                // affectation des colonnes
                // la collection voit les éléments comme des ‘Object’
                // ==>'caster' en Client pour en voir les attributs
                dr[0] = ((GestionCommercialeDll.Client)(GestionCommercialeDll.Donnees.TabClients[i])).RaisonSociale;
                dr[1] = ((GestionCommercialeDll.Client)(GestionCommercialeDll.Donnees.TabClients[i])).Ville;
                dr[2] = ((GestionCommercialeDll.Client)(GestionCommercialeDll.Donnees.TabClients[i])).CP;
                dr[3] = ((GestionCommercialeDll.Client)(GestionCommercialeDll.Donnees.TabClients[i])).Prive;
                dr[4] = ((GestionCommercialeDll.Client)(GestionCommercialeDll.Donnees.TabClients[i])).Activite;
                dr[5] = ((GestionCommercialeDll.Client)(GestionCommercialeDll.Donnees.TabClients[i])).Nature;

                

            } // fin de boucle

            // ajout de la ligne à la Datatable
            // (la propriété Rows est elle-même une collection...)
            dt.Rows.Add(dr);

            // déterminer l'origine des données à afficher en DataGridView
            this.grdClients.DataSource = dt;

            // refraîchir l'affichage (même pas utile…)
            //this.grdClients.Refresh();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                string filterField = "Raison Sociale"; // Variable qui indiquera au programme la colonne dans laquelle faire la recherche

                if (txtRecherche.Text != "")
                {
                    dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtRecherche.Text);
                    btnTous.Enabled = true;
                }

                else
                {
                    MessageBox.Show("Erreur : La zone de recherche est vide !", "Rechercher", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnTous_Click(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
            dt.DefaultView.RowFilter = null;
            btnTous.Enabled = false;
        }

        private void grdClients_DoubleClick(object sender, EventArgs e)
        {
            // ouvrir la feuille détail en y affichant
            // le stagiaire correspondant à la ligne double-cliquée
            Int32 iStag; // rang du stagiaire dans le tableau
                         // récupérer indice du stagiaire cliqué en DataGridView

            iStag = this.grdClients.CurrentRow.Index;

            // instancier un objet stagiaire pointant vers
            // le stagiaire d'origine dans la collection
            GestionCommercialeDll.Client leClient = GestionCommercialeDll.Donnees.TabClients[iStag] as GestionCommercialeDll.Client;

            // instancier un form détail pour ce stagiaire
            frmConsultClient frmConsult = new frmConsultClient(leClient);

            // afficher le form détail en modal
            frmConsult.ShowDialog();

            // en sortie du form détail, refraichir la datagridview
            if (frmConsult.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void frmListeClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            singleton = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GestionCommercialeDll.Donnees.TabClients.Count; i++)
            {
                // affectation des colonnes
                // la collection voit les éléments comme des ‘Object’
                // ==>'caster' en Client pour en voir les attributs
                dr[0] = ((GestionCommercialeDll.Client)(GestionCommercialeDll.Donnees.TabClients[i])).RaisonSociale;
                dr[1] = ((GestionCommercialeDll.Client)(GestionCommercialeDll.Donnees.TabClients[i])).Ville;
                dr[2] = ((GestionCommercialeDll.Client)(GestionCommercialeDll.Donnees.TabClients[i])).CP;
                dr[3] = ((GestionCommercialeDll.Client)(GestionCommercialeDll.Donnees.TabClients[i])).Prive;
                dr[4] = ((GestionCommercialeDll.Client)(GestionCommercialeDll.Donnees.TabClients[i])).Activite;
                dr[5] = ((GestionCommercialeDll.Client)(GestionCommercialeDll.Donnees.TabClients[i])).Nature;
            } // fin de boucle
        }
    }
}
