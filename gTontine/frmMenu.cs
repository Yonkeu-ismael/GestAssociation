using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gTontine
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void privilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void typeDeCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmType_compte f = new frmType_compte();
            //f.ShowDialog();
        }

        private void compteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompte f = new frmCompte();
            f.ShowDialog();
        }

        private void cotisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpération   f = new frmOpération ();
            f.ShowDialog();
        }

        private void adhérentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdhérent f = new frmAdhérent();
            f.ShowDialog();
        }

        private void inscrireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscrire f = new frmInscrire();
            f.ShowDialog();
        }

        private void cycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tontineToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void réunionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmOpération  f = new frmOpération ();
            f.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = "    gTontine 1.5 ";
            //toolStripStatusLabel2.Text = "         Utilisateur connecté";
            //toolStripStatusLabel3.Text = "                   Date du jour : " + DateTime.Now;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frmAdhérent f = new frmAdhérent();
            f.ShowDialog();
        }

        private void changerDeMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangerpassword f = new frmChangerpassword();
            f.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmgroupe f = new frmgroupe();
            //f.ShowDialog();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmutilisateur f = new frmutilisateur();
            f.ShowDialog();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void afficherLaideToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void planificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanification_rotative_des_bénéficiaires f=new frmPlanification_rotative_des_bénéficiaires ();
            f.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmCalculatrice f = new frmCalculatrice();
            f.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmutilisateur  f = new frmutilisateur ();
            f.ShowDialog();
        }

        private void membresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
