using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{
    public class Contact
    {
        private string nomContact;
        private string prenomContact;
        private int telContact;
        private string mailContact;
        private string cmbBoxFonctionMetier;

        public static Int32 NContact;

        public string NomContact { get => nomContact; set => nomContact = value; }
        public string PrenomContact { get => prenomContact; set => prenomContact = value; }
        public int TelContact { get => telContact; set => telContact = value; }
        public string MailContact { get => mailContact; set => mailContact = value; }
        public string CmbBoxFonctionMetier { get => cmbBoxFonctionMetier; set => cmbBoxFonctionMetier = value; }
    }
}
