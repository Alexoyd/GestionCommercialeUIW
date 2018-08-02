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

        private void btnContact_Click(object sender, EventArgs e) // Permet d'ouvrir la fenêtre Nouveau contact par le biais du bouton "Contacts" de la fenêtre Nouveau client
        {
            frmNouveauContact frmContact = new frmNouveauContact();

            if (frmContact.ShowDialog() == DialogResult.OK)
            { }


        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            GestionCommercialeDll.Client nouveauClient = new GestionCommercialeDll.Client();

            try
            {


                // déclenchement des méthodes get/set du Client.cs
                nouveauClient.NumClient = txtBoxNumClient.Text;
                nouveauClient.RaisonSociale = txtBoxRaisonSocial.Text;
                nouveauClient.Adresse = txtBoxAdresse.Text;
                nouveauClient.CP = txtBoxCP.Text;
                nouveauClient.Ville = txtBoxVille.Text;
                nouveauClient.Telephone = txtBoxTelephone.Text;
                nouveauClient.Effectif = Int32.Parse(txtBoxEffectif.Text);
                nouveauClient.CA = Int32.Parse(txtBoxCA.Text);
                nouveauClient.Activite = cmbBoxActivité.Text;
                nouveauClient.Nature = cmbBoxNature.Text;
                nouveauClient.Prive = chkBoxPrive.Checked;

                GestionCommercialeDll.Donnees.TabClients.Add(nouveauClient);

                GestionCommercialeDll.Client.NClient += 1;

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                nouveauClient = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Raison sociale");
            }


        }

        private void chkBoxPrive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxActivité_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}