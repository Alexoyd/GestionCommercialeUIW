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
    public partial class frmNouveauClient : Form
    {
        public frmNouveauClient()
        {
            InitializeComponent();
        }

        private void btnContact_Click(object sender, EventArgs e) // Permet d'ouvrir la fenêtre Nouveau contact par le biais du bouton "Contacts" de la fenêtre Nouveau client
        {
            frmNouveauContact frmContact = new frmNouveauContact();
            frmContact.Show();

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
