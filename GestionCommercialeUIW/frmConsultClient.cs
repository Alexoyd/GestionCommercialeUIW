﻿using System;
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
    public partial class frmConsultClient : Form
    {
        private GestionCommercialeDll.Client leClient;

        public frmConsultClient(GestionCommercialeDll.Client unClient)
        {
            this.leClient = unClient;

            InitializeComponent();
        }

        private void txtNumClient_TextChanged(object sender, EventArgs e)
        {


        }

        private void frmConsultClient_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.leClient);
                
        }
        private void afficheClient(GestionCommercialeDll.Client unClient)
        {
            this.lblNumClient.Text = unClient.NumClient;
            this.lblRSociale.Text = unClient.RaisonSociale;
            this.lblAdresse.Text = unClient.Adresse1;
            this.lblAdresse1.Text = unClient.Adresse2;
            this.lblCP.Text = unClient.CP;
            this.lblVille.Text = unClient.Ville;
            this.lblTelephone.Text = unClient.Telephone;
            this.lblEffectif.Text = unClient.Effectif.ToString();
            this.lblActivite.Text = unClient.Activite;
            this.lblCA.Text = unClient.CA.ToString();
            this.lblNature.Text = unClient.Nature;
            this.checkPrive.Checked = unClient.Prive;
            this.dGContacts.DataSource = Donnees.ArrayCont;
            this.dGContacts.Refresh();
           

        }

        private void lblEffectif_Click(object sender, EventArgs e)
        {

        }

        private void lblActivite_Click(object sender, EventArgs e)
        {

        }
        //boutton modification client
        private void btnModifClient_Click(object sender, EventArgs e)
        {
            frmModifClient frmModClient = new frmModifClient(lblNumClient.Text, lblRSociale.Text, lblAdresse.Text, lblAdresse1.Text, lblCP.Text, lblVille.Text, lblTelephone.Text, checkPrive.Checked, lblEffectif.Text, lblActivite.Text, lblCA.Text, lblNature.Text);
            frmModClient.ShowDialog();
        }
        
        private void btnNouveauContactModif_Click(object sender, EventArgs e)
        {
            frmNouveauContact frmNewContact = new frmNouveauContact(lblNumClient.Text.ToString(), lblRSociale.Text);
            frmNewContact.ShowDialog();
        }
        //Boutton quitter
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        
        //DataTable : permet de recopier les contacts
        //stockés en collection 
        //relier au DataGridview pour personnaliser son affichage
            private void dGConatcts()
            {  DataTable dt = new DataTable();
            DataRow dr; //ligne de la datatable
            Int32 i;

            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("email", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Fonction", typeof(System.String)));

            //boucle remplissage d ela DataTable à partir de la collection
            for (i = 0; i < frmNouveauContact.ArrayCont.Count; i++)
            {

                //instanciation Datrow (=ligne de la DataTable)
                dr = dt.NewRow();
                object donnees = null;
                //affectation des 5 colonnes
                dr[0] = ((frmNouveauContact)(donnees.ArrayCont[i])).Nom;
                dr[1] = ((frmNouveauContact)(donnees.ArrayCont[i])).Prenom;
                dr[2] = ((frmNouveauContact)(donnees.ArrayCont[i])).Telephone;
                dr[3] = ((frmNouveauContact)(donnees.ArrayCont[i])).Email;
                dr[4] = ((frmNouveauContact)(donnees.ArrayCont[i])).Fonction;

                dt.Rows.Add(dr);
            }
            //determine l'origine des données à afficher en DataGridView
            this.dGContacts.DataSource = dt;
            this.dGContacts.Refresh();
            dt = null;
            dr = null;
            }
        }
           
        
        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e
    }
    

        
      

       

        

