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
    public partial class frmChangerpassword : Form
    {
        AccesDonnees a = new AccesDonnees();
        public frmChangerpassword()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
          
        }

        private void frmChangerpassword_Load(object sender, EventArgs e)
        {
            this.Text = " Changer de mot de passe";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {

            int i = a.ResultatRequette1("select count(*) from utilisateur where compte='" + txtCompte.Text + "' and mot_de_passe='" + a.CryptageMD5(txtPsw.Text) + "'");

            if (i == 0)
            {
                MessageBox.Show("Votre ancien mot de passe est incorrect");
                txtCompte.Text = "";
                txtPsw.Text = "";
                txtPwd1.Text = "";
                txtPwd2.Text = "";
            }
            else
            {
                if (txtPwd1.Text != txtPwd2.Text)
                {
                    MessageBox.Show("Vos nouveaux mots de passe sont différents");
                    txtCompte.Text = "";
                    txtPsw.Text = "";
                    txtPwd1.Text = "";
                    txtPwd2.Text = "";
                }
                else
                {
                    a.ExecuteRequette("update utilisateur set mot_de_passe='" + a.CryptageMD5(txtPwd2.Text) + "' where compte='" + txtCompte.Text + "'");
                    txtCompte.Text = "";
                    txtPsw.Text = "";
                    txtPwd1.Text = "";
                    txtPwd2.Text = "";
                    MessageBox.Show("Mot de passe changé avec succès");
                }

            }

        }

        private void btnQuitter_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
