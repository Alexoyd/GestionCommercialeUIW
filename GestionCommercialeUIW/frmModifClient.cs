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
            this.InitActivité();
            this.InitNature();

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


    }


}
