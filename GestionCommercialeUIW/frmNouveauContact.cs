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
        public frmNouveauContact()
        {
            InitializeComponent();
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

            nouveauContact.NomContact = txtBoxNomContact.Text;
            nouveauContact.PrenomContact = txtBoxPrenomContact.Text;
            nouveauContact.TelContact = Int32.Parse(txtBoxTel.Text);
            nouveauContact.MailContact = txtBoxMail.Text;
            nouveauContact.CmbBoxFonctionMetier = cmbBoxFonctionMetier.Text;

           // GestionCommercialeDll.Donnees.TabContact.Add(nouveauContact);

            GestionCommercialeDll.Contact.NContact += 1;

            this.DialogResult = DialogResult.OK;
        }
    }
}
