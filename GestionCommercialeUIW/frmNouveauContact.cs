﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;


namespace GestionCommercialeUIW
{
    public partial class frmNouveauContact : Form
    {
        public frmNouveauContact(string unNumClient, string uneRaisonSociale)
        {
            InitializeComponent();
            this.lblContactNumClient.Text = unNumClient;
            this.lblNomClient.Text = uneRaisonSociale;
            this.ComboBoxInitMetier();
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
                    // son ajout à la collection est OK :
                    // - incrémentation compteurs de stagiaires
                    // - fermeture de la boite de dialogue par validation
                    this.DialogResult = DialogResult.OK;
                }


            }


        }

        bool invalid = false;

        public bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Renvoie true si strIn est dans un format de mail correct.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
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


            if (!(IsValidEmail(this.txtBoxMail.Text)))
            {
                MessageBox.Show("Format adresse mail non valide");
                code = false;

            }

            if (!(NomEstEntre(this.txtBoxNomContact.Text)))
            {
                MessageBox.Show("Veuillez entrer un Nom", "ERREUR");
                code = false;
            }

            if (!(PrenomEstEntre(this.txtBoxPrenomContact.Text)))
            {
                MessageBox.Show("Veuillez entrer un Prénom", "ERREUR");
                code = false;
            }

            return code;
        }

        private Boolean NomEstEntre(string a)
        {
            int i;
            Char c;
            Boolean controle = true;
            if (a.Length == 0)
            {

                controle = false;
            }
            else
            {
                for (i = 0; i < a.Length; i++)
                {
                    c = a[i]; // extrait le i° car
                    if (!(Char.IsLetter(c))) // si ce n'est pas un chiffre
                    {
                        controle = false; // erreur détectée
                    }

                } // fin de boucle for

            }
            return controle;
        }
        private Boolean PrenomEstEntre(string a)
        {
            int i;
            Char c;
            Boolean controle = true;
            if (a.Length == 0)
            {
                controle = false;
            }
            else
            {
                for (i = 0; i < a.Length; i++)
                {
                    c = a[i]; // extrait le i° car
                    if (!(Char.IsLetter(c))) // si ce n'est pas un chiffre
                    {
                        controle = false; // erreur détectée
                    }

                } // fin de boucle for

            }
            return controle;
        }

        private Boolean estEntierTelephone(String s)
        {

            Int32 i; // indice de parcours de chaîne
            Char c; // caractère courant
            Boolean code = true; // code retour; OK a priori
                                 // test longueur chaîne reçue
            if (s.Length == 10 || s.Length == 0)
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
            // créer une référence d'objet GestionCommercialeDll
            GestionCommercialeDll.Contact nouveauContact = new GestionCommercialeDll.Contact();
            try
            {// déclenchement des méthodes get/set du Client.cs
                nouveauContact.NumContact = Convert.ToInt32(lblContactNumClient.Text);
                nouveauContact.NomContact = txtBoxNomContact.Text;
                nouveauContact.PrenomContact = txtBoxPrenomContact.Text;
                nouveauContact.TelContact = txtBoxTel.Text;
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

        private void ComboBoxInitMetier()
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

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Explorateur de fichiers";
            // Filter représente le type de fichier qu'il est possible d'ouvrir, ce qu'il y a en bas de la fenetre
            // Tu commence par le texte qui s'affiche, ensuite |, ensuite les extensions correspondante
            ofd.Filter = "Images(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|Tous les fichiers (*.*)|*.* ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picBoxPhotoContact.Image = Image.FromFile(ofd.FileName); // Code d'ouverture du fichier
            }


        }
    }

}



