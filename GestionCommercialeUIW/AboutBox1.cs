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
    public partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();

           /* this.Text = String.Format("À propos de {0}", AssemblyTitle);
            this.lblNomProduit.Text = AssemblyProduct;
            this.lblversion.Text = String.Format("Version {0}", AssemblyVersion);
            this.lblCopyright.Text = AssemblyCopyright;
            this.lblNomSociete.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription; */
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
