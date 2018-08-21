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
            if (this.controleClient())
            {
                frmNouveauContact frmContact = new frmNouveauContact(txtBoxNumClient.Text.ToString(), txtBoxRaisonSocial.Text);
                frmContact.ShowDialog();
            }
        }

        private Boolean controleClient()
        {
            Boolean codeClient = true; // le code de retour ; OK a priori
                                       // appel fonction générique de contrôle
            if (!(estEntier(this.txtBoxNumClient.Text)))
            {
                // la chaîne reçue n'est pas convertible
                codeClient = false;
                MessageBox.Show("Le numéro client saisi n'est pas correct", "Attention !!!", MessageBoxButtons.OK);
            }
            return codeClient;
        }



        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
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


        private Boolean controle()
        {

            // contrôler la vraissemblance de tous les champs
            Boolean code = true; // le code de retour ; OK a priori
                                 // appel fonction générique de contrôle
            if (!(estEntier(this.txtBoxNumClient.Text)))
            {
                // la chaîne reçue n'est pas convertible
                code = false;
                MessageBox.Show("le Numéro client saisi n'est pas un entier valide", "ERREUR", MessageBoxButtons.OK);
            }
            if (!(estEntierCP(this.txtBoxCP.Text)))
            {
                code = false;
                MessageBox.Show("le code postal saisi n'est pas correct",
               "ERREUR", MessageBoxButtons.OK);
            }
            if (!(estEntierTelephone(this.txtBoxTelephone.Text)))
            {
                // la chaîne reçue n'est pas convertible
                code = false;
                MessageBox.Show("le numéro de téléphone saisi n'est pas un entier valide", "ERREUR", MessageBoxButtons.OK);
            }

            if (!(estEntier(this.txtBoxEffectif.Text)))
            {
                // la chaîne reçue n'est pas convertible
                code = false;
                MessageBox.Show("l'effectif saisi n'est pas un entier valide", "ERREUR", MessageBoxButtons.OK);
            }
            if (!(estEntier(this.txtBoxCA.Text)))
            {
                code = false;
                MessageBox.Show("le chiffre d'affaire saisi n'est pas correct",
               "ERREUR", MessageBoxButtons.OK);
            }
            return code;
        }

        private Boolean estEntier(String s)
        {
            /* vérifier que la chaine reçue représente bien un entier valide :
            * - uniquement des chiffres
            * - pas vide
            * - pas plus de 9 chiffres (capacité maxi du type Int32)
            */
            Int32 i; // indice de parcours de chaîne
            Char c; // caractère courant
            Boolean code = true; // code retour; OK a priori
                                 // test longueur chaîne reçue
            if (s.Length < 10 && s.Length > 0)
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

        private Boolean estEntierCP(String s)
        {

            Int32 i; // indice de parcours de chaîne
            Char c; // caractère courant
            Boolean code = true; // code retour; OK a priori
                                 // test longueur chaîne reçue
            if (s.Length == 5)
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
            GestionCommercialeDll.Client nouveauClient = new GestionCommercialeDll.Client();
            try
            {// déclenchement des méthodes get/set du Client.cs
                nouveauClient.NumClient = txtBoxNumClient.Text;
                nouveauClient.RaisonSociale = txtBoxRaisonSocial.Text;
                nouveauClient.Adresse1 = txtBoxAdresse1.Text;
                nouveauClient.Adresse2 = txtBoxAdresse2.Text;
                nouveauClient.CP = txtBoxCP.Text;
                nouveauClient.Ville = txtBoxVille.Text;
                nouveauClient.Telephone = txtBoxTelephone.Text;
                nouveauClient.Effectif = Int32.Parse(txtBoxEffectif.Text);
                nouveauClient.CA = Int32.Parse(txtBoxCA.Text);
                nouveauClient.Activite = cmbBoxActivité.Text;
                nouveauClient.Nature = cmbBoxNature.Text;
                nouveauClient.Prive = chkBoxPrive.Checked;

                GestionCommercialeDll.Donnees.TabClients.Add(nouveauClient);
                return true;
            }
            catch (Exception ex)
            {
                nouveauClient = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de Client");
                return false;
            }

        }

        private void chkBoxPrive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxActivité_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNumClient_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxNumClient.Text != "")
                btnContact.Enabled = true;
            else
                btnContact.Enabled = false;
        }
    }
}