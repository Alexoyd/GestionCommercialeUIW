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
    public partial class frmNouveauContact : Form
    {
        public frmNouveauContact(string unNumClient, string uneRaisonSociale)
        {
            InitializeComponent();
            this.lblContactNumClient.Text = unNumClient;
            this.lblNomClient.Text = uneRaisonSociale;
        }

        private void btnAnnulerContact_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxNomContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOkContact_Click(object sender, EventArgs e)
        {
            GestionCommercialeDll.Contact nouveauContact = new GestionCommercialeDll.Contact();
            try
            {
                nouveauContact.NomContact = txtBoxNomContact.Text;
                nouveauContact.PrenomContact = txtBoxPrenomContact.Text;
                nouveauContact.TelContact = Int32.Parse(txtBoxTel.Text);
                nouveauContact.MailContact = txtBoxMail.Text;
                nouveauContact.CmbBoxFonctionMetier = cmbBoxFonctionMetier.Text;
                GestionCommercialeDll.Contact.NContact += 1;

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            // GestionCommercialeDll.Donnees.TabContact.Add(nouveauContact);  //=> En attente de papi pour supprimer le commentaire devant cette ligne.


        }

        private void frmAfficheNumclient(object sender, EventArgs e)
        {

        }


    }
}