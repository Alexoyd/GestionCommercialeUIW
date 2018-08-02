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
            frmListe = frmListeClients.CreateFormulaire();
            //frmListe = new frmListeClients(); // instancie le form listeClient
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
            // VERSION 1 sans contrôle pour savoir si la fenêtre est déjà ouverte // 

            /* frmListe = new frmListeClients(); // instancie le form listeClient
             frmListe.MdiParent = this; // précise le conteneur MDI du form liste client     
             frmListe.Show();//Affiche le form liste dans son form conteneur*/

                      
                frmListe = frmListeClients.CreateFormulaire();
                this.frmListe.MdiParent = this;// implémente un événement sur le nouveau form pour libérer la ref à ce form
               
                this.frmListe.Show(); // affiche le form
                frmListe.Location = new Point(0, 0);
               // this.frmListe = FormWindowState.Maximized;

            //else
            //{
            //    this.frmListe.Activate(); //Réactive le formListe (lui donne également le focus)
            //}


        }
      
    }
}
