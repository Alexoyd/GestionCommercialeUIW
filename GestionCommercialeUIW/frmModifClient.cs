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
        private GestionCommercialeDll.Client leClient;

        public frmModifClient(GestionCommercialeDll.Client unClient)
        {
            this.leClient = unClient;
            InitializeComponent();
            this.InitActivité();
            this.InitNature();
        }

        private void InitActivité()
        {
            // vide la combobox
            this.cmbBoxActivité.Items.Clear();

            // ajoute une collection d'items
            this.cmbBoxActivité.Items.AddRange(new String[]
            { "Céréales", "Boissons", "Administration", "Bovins","Laiterie" });

            // permet de remplir par défaut la première valeur de l'index afin de ne pas mettre le programme en erreur
            this.cmbBoxActivité.SelectedIndex = 0;
        }

        private void InitNature()
        {
            // vide la combobox
            this.cmbBoxNature.Items.Clear();

            // ajoute une collection d'items
            this.cmbBoxNature.Items.AddRange(new String[]
            { "Principale", "Secondaire", "Ancienne" });

            // permet de remplir par défaut la première valeur de l'index afin de ne pas mettre le programme en erreur
            this.cmbBoxNature.SelectedIndex = 0;
        }

        private void afficheClient(GestionCommercialeDll.Client unClient)
        {
            this.lblNum.Text = unClient.NumClient;
            this.txtBoxRaisonSocial.Text = unClient.RaisonSociale;
            this.txtBoxAdresse.Text = unClient.Adresse1;
            this.txtBoxAdresse2.Text = unClient.Adresse2;
            this.txtBoxCP.Text = unClient.CP;
            this.txtBoxVille.Text = unClient.Ville;
            this.txtBoxTelephone.Text = unClient.Telephone;
            this.txtBoxEffectif.Text = unClient.Effectif.ToString();
            this.cmbBoxActivité.Text = unClient.Activite;
            this.txtBoxCA.Text = unClient.CA.ToString();
            this.cmbBoxNature.Text = unClient.Nature;
            this.chkBoxPrive.Checked = unClient.Prive;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmConsultClient frmConsult = new frmConsultClient(leClient);

            //Permet la modification des champs et d'afficher les information dans le form Consult client

            leClient.RaisonSociale = txtBoxRaisonSocial.Text;
            frmConsult.lblRSociale.Text = leClient.RaisonSociale;    
            
            leClient.Adresse1 = txtBoxAdresse.Text;
            frmConsult.lblAdresse.Text = leClient.Adresse1;
            leClient.Adresse2 = txtBoxAdresse2.Text;
            frmConsult.lblAdresse1.Text = leClient.Adresse2;
            leClient.CP = txtBoxCP.Text;
            frmConsult.lblCP.Text = leClient.CP;
            leClient.Ville = txtBoxVille.Text;
            frmConsult.lblVille.Text = leClient.Ville;
            leClient.Telephone = txtBoxTelephone.Text;
            frmConsult.lblTelephone.Text = leClient.Telephone;
            leClient.Effectif = Convert.ToInt32(txtBoxEffectif.Text);
            frmConsult.lblEffectif.Text = leClient.Effectif.ToString();
            leClient.CA = Convert.ToInt32 (txtBoxCA.Text);
            frmConsult.lblCA.Text = leClient.CA.ToString();
            leClient.Activite = cmbBoxActivité.Text;
            frmConsult.lblActivite.Text = leClient.Activite;
            leClient.Nature = cmbBoxNature.Text;
            frmConsult.lblNature.Text = leClient.Nature;
            leClient.Prive = chkBoxPrive.Checked;
            frmConsult.checkPrive.Checked = leClient.Prive;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void frmModifClient_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.leClient);
        }



    }


}
