using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Commentaire

namespace GestionCommercialeDll
{
    public class Client
    {
        private string numClient;
        private string raisonSociale;
        private string adresse1;
        private string adresse2;
        private string codePostal;
        private string ville;
        private string telephone;
        private bool prive;
        private int effectif;
        private int chiffreAffaire;
        private string activite;
        private string nature;


        public static Int32 NClient;


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

        public string Adresse1
        {
            get { return this.adresse1; }
            set { this.adresse1 = value; }
        }

        public string Adresse2
        {
            get { return this.adresse2; }
            set { this.adresse2 = value; }
        }

        public string CP
        {
            get { return this.codePostal; }
            set { this.codePostal = value; }
        }

        public string Ville
        {
            get { return this.ville; }
            set { this.ville = value; }
        }

        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
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
