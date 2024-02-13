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
    public partial class frmConnexion : Form
    {
        AccesDonnees a = new AccesDonnees();
        
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          
        }

        private void btnLogin_Click(object sender, EventArgs e)        
            {
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            int i = a.ResultatRequette1("SELECT count(*) FROM utilisateur WHERE compte= '" + txtCompte.Text + "' AND mot_de_passe = '" + a.CryptageMD5(txtMotpasse.Text) + "'");
            if (i == 0)
            {
                txtCompte.Text = "";
                txtMotpasse.Text = "";
                MessageBox.Show("Compte ou mot de passe incorrect !");
            }
            else
            {
                int j = a.ResultatRequette1("select count(*) from utilisateur where compte='" + txtCompte.Text + "' and mot_de_passe ='" + a.CryptageMD5(txtMotpasse.Text) + "'");
                if (j == 0)
                {
                    MessageBox.Show("Votre compte est bloqué; contacter l'administrateur !");
                }
                else
                {

                    frmPrincipal f = new frmPrincipal();
                    f.ShowDialog();
                    this.Visible = false;
                }

            }         
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
