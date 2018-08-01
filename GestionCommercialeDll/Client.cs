using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommercialeDll
{
    public class Client
    {
        private string numClient;
        private string raisonSociale;
        private string adresse;
        private string codePostal;
        private string ville;
        private string telephone;
        private bool prive;
        private int effectif;
        private int chiffreAffaire;
        private string activite;
        private string nature;

        public string NumClient
        {
            get { return this.numClient; }
            set { this.numClient = value; }
        }

        public string RaisonSociale
        {
            get { return this.raisonSociale; }
            set { this.raisonSociale = value; }
        }

        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }

        public string CP
        {
            get { return this.codePostal; }
            set
            { 
                // L'appelant doit fournir un code postal valide à 5 chiffres
                bool erreur = false; // Indicateur erreur

                if (value.Length == 5) // 5 charactères attendus : OK ==> contrôler un à un
                {
                    for (int i = 0; i < value.Length; i++) // Controle chiffres par boucle
                    {
                        if (!(Char.IsDigit(value[i])))
                        { erreur = true; }

                    } // Fin de boucle controle chiffres

                    if (erreur) // On a rencontre un non-chiffre
                    {
                        throw new Exception(value.ToString() + "\n" + "n'est pas un code postal valide : uniquement des chiffres");
                    }

                    else
                    {
                        codePostal = value; // tout est bon, on affecte la propriété
                    }
                }

                else // Il n'y a pas 5 caractères
                {
                    // Première solution par simple messagebox
                    MessageBox.Show(value.ToString() + "\n" +
                   "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins", "Erreur", MessageBoxButtons.OK);
                }
            }
        }

        public string Ville
        {
            get { return this.ville; }
            set { this.ville = value; }
        }

        public string Telephone
        {
            get { return this.telephone; }
            set
            { 
                // L'appelant doit fournir un numéro de téléphone valide à 10 chiffres
                bool erreur = false; // Indicateur erreur

                if (value.Length == 10) // 10 charactères attendus : OK ==> contrôler un à un
                {
                    for (int i = 0; i < value.Length; i++) // Controle chiffres par boucle
                    {
                        if (!(Char.IsDigit(value[i])))
                        { erreur = true; }

                    } // Fin de boucle controle chiffres

                    if (erreur) // On a renconté un non-chiffre
                    {
                        throw new Exception(value.ToString() + "\n" + "n'est pas un numéro de téléphone valide : uniquement des chiffres");
                    }

                    else
                    {
                        telephone = value; // Tout est bon, on affecte la propriété
                    }
                }

                else // Il n'y a pas 10 caractères
                {
                    // Première solution par simple messagebox
                    MessageBox.Show(value.ToString() + "\n" +
                   "n'est pas un numéro de téléphone valide : 10 chiffres, pas plus, pas moins", "Erreur", MessageBoxButtons.OK);
                }
            }
        }

        public bool Prive
        {
            get { return this.prive; }
            set { this.prive = value; }
        }

        public int Effectif
        {
            get { return this.effectif; }
            set { this.effectif = value; }
        }

        public int CA
        {
            get { return this.chiffreAffaire; }
            set { this.chiffreAffaire = value; }
        }

        public string Activite
        {
            get { return this.activite; }
            set { this.activite = value; }
        }

        public string Nature
        {
            get { return this.nature; }
            set { this.nature = value; }
        }
    }
}