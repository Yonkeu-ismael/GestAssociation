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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            frmAdhérent f = new frmAdhérent();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmInscrire f = new frmInscrire();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmutilisateur f = new frmutilisateur();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCycle f = new frmCycle();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmChangerpassword f = new frmChangerpassword();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMenu f = new frmMenu();
            f.ShowDialog();
           
        } 

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            Chargement();
           
            this.Visible = false;
            toolStripStatusLabel1.Text = "    gTontine 1.5 ";
            toolStripStatusLabel2.Text = "         Utilisateur connecté";
            toolStripStatusLabel3.Text = "                   Date du jour : " + DateTime.Now;
        }
          void Chargement( )
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(button1, "Ajouter un utilisateur");
            tooltip.SetToolTip(button7, "Changer mot de passe");
            tooltip.SetToolTip(button6, "Ajouter un cycle");
            tooltip.SetToolTip(button5, "Ajouter un adhérent");
            tooltip.SetToolTip(button4, "Inscription");
            tooltip.SetToolTip(button8, "Afficher l'aide");
            tooltip.SetToolTip(button9, "Impression de la liste des adhérents");
            tooltip.SetToolTip(button10, "Ajouter une tontine");
            tooltip.SetToolTip(button2, "Etat de la planification rotative des bénéficiaires");
        }
        private void button2_Click(object sender, EventArgs e)
        {


            this.Close();
            //MessageBox.Show(" Utilisateur déconnecté avec succès !!!");

            //frmConnexion f = new frmConnexion();
            //f.ShowDialog();
            //this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            frmstatlisteadherent f = new frmstatlisteadherent();
            f.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            frmPlanification f = new frmPlanification();
            f.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            frmTontine f = new frmTontine();
            f.ShowDialog();
        }

        private void crToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void compteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompte f = new frmCompte();
            f.ShowDialog();
        }

        private void opérationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpération f = new frmOpération();
            f.ShowDialog();
        }

        private void planificationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmPlanification_rotative_des_bénéficiaires f = new frmPlanification_rotative_des_bénéficiaires();
            f.ShowDialog();
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
