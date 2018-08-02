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
        private GestionCommercialeDll.Client leClient;

        public frmConsultClient(GestionCommercialeDll.Client unClient)
        {
            this.leClient = unClient;
            InitializeComponent();
        }

        private void txtNumClient_TextChanged(object sender, EventArgs e)
        {


        }

        private void frmConsultClient_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.leClient);
                
        }
        private void afficheClient(GestionCommercialeDll.Client unClient)
        {
            this.txtNumClient.Text = unClient.NumClient;
            this.txtRSocial.Text = unClient.RaisonSociale;
            this.rue.Text = unClient.Adresse;
            this.textAdresse1.Text = unClient.Adresse;
            this.txtCP.Text = unClient.CP;
            this.txtVille.Text = unClient.Ville;
            this.txtTel.Text = unClient.Telephone;
            this.txtEffectif.Text = unClient.Effectif.ToString();
            this.txtActivite.Text = unClient.Activite;
            this.txtCA.Text = unClient.CA.ToString();
            this.txtNature.Text = unClient.Nature;

        }

    }
}
        
      

       

        

