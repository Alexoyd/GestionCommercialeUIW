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
    public partial class frmModifClient : Form
    {
        public frmModifClient(string unNumClient, string RaisonSociale, string AdresseUne, string AdresseDeux, string CP, string Ville, string Telephone, bool prive, string Effectif, string CA, string Activite, string Nature)
        {
            InitializeComponent();
            this.lblNum.Text = unNumClient;
            this.txtBoxRaisonSocial.Text = RaisonSociale;
            this.txtBoxAdresse.Text = AdresseUne;
            this.txtBoxAdresse2.Text = AdresseDeux;
            this.txtBoxCP.Text = CP;
            this.txtBoxVille.Text = Ville;
            this.txtBoxTelephone.Text = Telephone;
            this.chkBoxPrive.Checked = prive;
            this.txtBoxEffectif.Text = Effectif;
            this.txtBoxCA.Text = CA;
            this.cmbBoxActivité.Text = Activite;
            this.cmbBoxNature.Text = Nature;
        }


    }


}
