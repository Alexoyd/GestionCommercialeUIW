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
       
        public frmListeClients()
        {
            InitializeComponent();
            this.afficheClients();
        }

        private void btnNouveauClient_Click(object sender, EventArgs e)
        {
            // instancie un form de saisie de stagiaire et l'affiche en modal
            frmNouveauClient frmAjout = new frmNouveauClient();

            // si on sort de la saisie par OK
            if (frmAjout.ShowDialog() == DialogResult.OK)
                frmAjout.Show();

        }
        
        public void afficheClients()
        {
            // DataTable : pour recopier les clients
            // (stockés en collection) ;
            // à relier au DataGridView pour personnaliser son affichage
            DataTable dt = new DataTable();
            DataRow dr; // ligne de la datatable
            
            // Ajout à la datatable des colonnes
            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Code Postal", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Privé ?", typeof(System.Boolean)));
            dt.Columns.Add(new DataColumn("Activité", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));


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

                // ajout de la ligne à la Datatable
                // (la propriété Rows est elle-même une collection...)
                dt.Rows.Add(dr);

            } // fin de boucle

            // déterminer l'origine des données à afficher en DataGridView
            this.grdClients.DataSource = dt;

            // refraîchir l'affichage (même pas utile…)
            this.grdClients.Refresh();

            dt = null; // pas vraiment utile non plus…
            dr = null;

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
