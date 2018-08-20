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
            this.JeanBurgerStuveux();
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
            if (this.controle())
            {
                if (this.instancie())
                {
                    // cas général :
                    // si l'instanciation stagiaire et
                    // son ajout à la collection est OK :
                    // - incrémentation compteurs de stagiaires
                    // - fermeture de la boite de dialogue par validation
                    this.DialogResult = DialogResult.OK;
                }
            }


        }

        private void frmAfficheNumclient(object sender, EventArgs e)
        {

        }




        private Boolean controle()
        {

            // contrôler la vraissemblance de tous les champs
            Boolean code = true; // le code de retour ; OK a priori
                                 // appel fonction générique de contrôle



            if (!(estEntierTelephone(this.txtBoxTel.Text)))
            {
                // la chaîne reçue n'est pas convertible
                code = false;
                MessageBox.Show("le numéro de téléphone saisi n'est pas un entier valide", "ERREUR", MessageBoxButtons.OK);
            }


            if (!(estArobase(this.txtBoxMail.Text)))
            {
                code = false;

            }
            return code;
        }

        private Boolean estArobase(String s)
        {
            Boolean code = true; // code retour; OK a priori
                                 // test longueur chaîne reçue
            string arobase = "@";

            if (txtBoxMail.Text.Contains(arobase))

            {
                // vérifier 1 à 1 que tous les caractères sont des chiffres

            }
            else // erreur de longueur de chaine
            {
                code = false;
                MessageBox.Show("Il n'y à pas d'AROBASE !"); ; // erreur détectée
            }
            return code;
        }




        private Boolean estEntierTelephone(String s)
        {

            Int32 i; // indice de parcours de chaîne
            Char c; // caractère courant
            Boolean code = true; // code retour; OK a priori
                                 // test longueur chaîne reçue
            if (s.Length == 10)
            {
                // vérifier 1 à 1 que tous les caractères sont des chiffres
                for (i = 0; i < s.Length; i++)
                {
                    c = s[i]; // extrait le i° car
                    if (!(Char.IsDigit(c))) // si ce n'est pas un chiffre
                    {
                        code = false; // erreur détectée
                    }
                } // fin de boucle for
            }
            else // erreur de longueur de chaine
            {
                code = false; // erreur détectée
            }
            return code;
        }


        private Boolean instancie()
        {
            // créer une référence d'objet MStagiaire
            GestionCommercialeDll.Contact nouveauContact = new GestionCommercialeDll.Contact();
            try
            {// déclenchement des méthodes get/set du Client.cs
                nouveauContact.NumContact = Convert.ToInt32(lblContactNumClient.Text);
                nouveauContact.NomContact = txtBoxNomContact.Text;
                nouveauContact.PrenomContact = txtBoxPrenomContact.Text;
                nouveauContact.TelContact = Int32.Parse(txtBoxTel.Text);
                nouveauContact.MailContact = txtBoxMail.Text;
                nouveauContact.CmbBoxFonctionMetier = cmbBoxFonctionMetier.Text;

                GestionCommercialeDll.Donnees.TabContacts.Add(nouveauContact);
                return true;
            }
            catch (Exception ex)
            {
                nouveauContact = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de Contact");
                return false;
            }

        }

        private void JeanBurgerStuveux()
        {
            // vide la combobox
            this.cmbBoxFonctionMetier.Items.Clear();

            this.cmbBoxFonctionMetier.Items.AddRange(new String[]
            {
                "Directeur", "RH", "Comptable", "Employé Lambda", "Stagiaire"
            });
            this.cmbBoxFonctionMetier.SelectedIndex = 0;
        }

        private void cmbBoxFonctionMetier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



