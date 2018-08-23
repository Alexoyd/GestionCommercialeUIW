
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
    public partial class frmConsultClient : Form
    {
        DataTable dt = new DataTable();

        private GestionCommercialeDll.Client leClient;

        public frmConsultClient(GestionCommercialeDll.Client unClient)
        {
            this.leClient = unClient;
            
            InitializeComponent();
        }



        private void frmConsultClient_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.leClient);

            dt.Columns.Add("Nom",
                System.Type.GetType("System.String"));
            dt.Columns.Add("Prénom",
                System.Type.GetType("System.String"));
            dt.Columns.Add("Téléphone",
                System.Type.GetType("System.String"));
            dt.Columns.Add("E-Mail",
                System.Type.GetType("System.String"));
            dt.Columns.Add("Fonction",
               System.Type.GetType("System.String"));

            afficheContacts();

        }
        private void afficheClient(GestionCommercialeDll.Client unClient)
        {
            this.lblNumClient.Text = unClient.NumClient;
            this.lblRSociale.Text = unClient.RaisonSociale;
            this.lblAdresse.Text = unClient.Adresse1;
            this.lblAdresse1.Text = unClient.Adresse2;
            this.lblCP.Text = unClient.CP;
            this.lblVille.Text = unClient.Ville;
            this.lblTelephone.Text = unClient.Telephone;
            this.lblActivite.Text = unClient.Activite;
            this.lblNature.Text = unClient.Nature;
            this.checkPrive.Checked = unClient.Prive;

            if (unClient.Effectif != 0)
                this.lblEffectif.Text = unClient.Effectif.ToString();
            if (unClient.CA != 0)
                this.lblCA.Text = unClient.CA.ToString();

        }

        private void lblEffectif_Click(object sender, EventArgs e)
        {

        }

        private void lblActivite_Click(object sender, EventArgs e)
        {

        }

        //boutton modification client
        private void btnModifClient_Click(object sender, EventArgs e)
        {
            frmModifClient frmModClient = new frmModifClient(leClient);
            if (frmModClient.ShowDialog() == DialogResult.OK)
                this.afficheClient(this.leClient);
        }

        private void btnNouveauContactModif_Click(object sender, EventArgs e)
        {
            frmNouveauContact frmNewContact = new frmNouveauContact(lblNumClient.Text.ToString(), lblRSociale.Text);
            frmNewContact.ShowDialog();

            if (frmNewContact.DialogResult == DialogResult.OK)
            {
                dt.Clear();
                afficheContacts();
            }
        }
        //Boutton quitter
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #region Truc de merde

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void afficheContacts()
        {
            foreach (var Contact in GestionCommercialeDll.Donnees.TabContacts)
            {
                if (Contact.NumContact == Convert.ToInt32(leClient.NumClient))
                {
                    dt.Rows.Add(Contact.NomContact, Contact.PrenomContact, Contact.TelContact, Contact.MailContact, Contact.CmbBoxFonctionMetier);
                }
            }
            dataGridView1.DataSource = dt;
        }

        private void txtNumClient_TextChanged(object sender, EventArgs e)
        {


        }

        #endregion

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblRSociale_Click(object sender, EventArgs e)
        {

        }

        private void lblAdresse_Click(object sender, EventArgs e)
        {

        }

        private void lblAdresse1_Click(object sender, EventArgs e)
        {

        }

        private void lblCP_Click(object sender, EventArgs e)
        {

        }

        private void lblTelephone_Click(object sender, EventArgs e)
        {

        }

        private void lblNumClient_Click(object sender, EventArgs e)
        {

        }

        private void BtnSupContact_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 iContact; // rang du contact dans le tableau
                                // récupérer indice du contact cliqué en DataGridView

                iContact = this.dataGridView1.CurrentRow.Index;

                // instancier un objet contact pointant vers
                // le contact d'origine dans la collection
                GestionCommercialeDll.Contact leContact = GestionCommercialeDll.Donnees.TabContacts[iContact] as GestionCommercialeDll.Contact;

                GestionCommercialeDll.Donnees.TabContacts.Remove(leContact);

                dt.Clear();
                afficheContacts();
            }
            catch
            {
                MessageBox.Show("Vous n'avez sélectionné aucun contact");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // ouvrir la feuille détail en y affichant
                // le client correspondant à la ligne double-cliquée
                Int32 iContact; // rang du client dans le tableau
                               // récupérer indice du client cliqué en DataGridView

                iContact = this.dataGridView1.CurrentRow.Index;

                // instancier un objet client pointant vers
                // le client d'origine dans la collection
                GestionCommercialeDll.Contact leContact = GestionCommercialeDll.Donnees.TabContacts[iContact] as GestionCommercialeDll.Contact;

                // instancier un form détail pour ce client
                frmModifContact frmConsult = new frmModifContact(leContact);

                // afficher le form détail en modal
                frmConsult.ShowDialog();

                if (frmConsult.DialogResult == DialogResult.OK)
                {
                    dt.Clear();
                    afficheContacts();
                }
            }
            catch
            {
                MessageBox.Show("Vous n'avez sélectionné aucun client");
            }
        }

    }
}