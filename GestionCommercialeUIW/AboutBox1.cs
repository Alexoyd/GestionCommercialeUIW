using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace GestionCommercialeUIW
{
    public partial class AboutBox1 : Form
    {

        public AboutBox1()
        {
            InitializeComponent();

            this.Text = String.Format("À propos de {0}", AssemblyTitle);
            this.lblNomProduit.Text = AssemblyProduct;
            this.lblversion.Text = String.Format("Version {0}", AssemblyVersion);
            this.lblCopyright.Text = AssemblyCopyright;
            this.lblNomSociete.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }



        public string AssemblyTitle
        {
            get
            {
                // Obtenir tous les attributs Title de cet assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // Si au moins un attribut Title existe
                if (attributes.Length > 0)
                {
                    // Sélectionnez le premier
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // Si ce n'est pas une chaîne vide, le retourner
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // Si aucun attribut Title n'existe ou si l'attribut Title était la chaîne vide, retourner le nom .exe
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                // Obtenir tous les attributs Description de cet assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // Si aucun attribut Description n'existe, retourner une chaîne vide
                if (attributes.Length == 0)
                    return "";
                // Si un attribut Description existe, retourner sa valeur
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                // Obtenir tous les attributs Product de cet assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // Si aucun attribut Product n'existe, retourner une chaîne vide
                if (attributes.Length == 0)
                    return "";
                // Si un attribut Product existe, retourner sa valeur
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                // Obtenir tous les attributs Copyright de cet assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // Si aucun attribut Copyright n'existe, retourner une chaîne vide
                if (attributes.Length == 0)
                    return "";
                // Si un attribut Copyright existe, retourner sa valeur
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                // Obtenir tous les attributs Company de cet assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // Si aucun attribut Company n'existe, retourner une chaîne vide
                if (attributes.Length == 0)
                    return "";
                // Si un attribut Company existe, retourner sa valeur
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }



        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            textBoxDescription.Text = "Ce programme à été développé par une équipe de dev très compétente.";
        }
    }
}
