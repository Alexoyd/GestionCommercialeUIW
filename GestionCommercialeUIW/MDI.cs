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
    public partial class MDI : Form
    {
        private frmListeClients frmListe; // déclare une instance du form liste client 

           public MDI()
        {
            InitializeComponent();
            frmListe = new frmListeClients(); // instancie le form listeClient
            frmListe.MdiParent = this; // précise le conteneur MDI du form liste client
            frmListe.Show();//Affiche le form liste dans son form conteneur
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // quitter

        }

        private void aProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frmAbout = new AboutBox1();
            frmAbout.ShowDialog();
        }

        private void listeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListe = new frmListeClients(); // instancie le form listeClient
            frmListe.MdiParent = this; // précise le conteneur MDI du form liste client
            frmListe.Show();//Affiche le form liste dans son form conteneur
        }
    }
}
