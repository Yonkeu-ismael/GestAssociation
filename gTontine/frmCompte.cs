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
    public partial class frmCompte : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette = "";
        string lecode;
        //string requette_numero = "";
        //int codeTypeCompte;
      

        public frmCompte()

        {
            InitializeComponent();
        }
        //string Retrait, Encaissement, Virement;

        private void frmcCompte_Load(object sender, EventArgs e)
        {
            Chargement();
        }
        void Chargement()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnEnregistrer, "Enregistrer");
            tooltip.SetToolTip(btnModifier, "Modifier");
            tooltip.SetToolTip(btnSupprimer, "Supprimer");
            tooltip.SetToolTip(btnFermer, "Fermer");

            //requette_numero = "select numero from type_compte";
            //a.ChargeCombo(cboNumero, requette_numero);

            //a.ChargeTable1(dataGridView1, "select numero_compte,compte.numero,retrait,encaissement,virement,compte_adherent  from compte,type_compte");
            a.ChargeTable1(dataGridView1, "select *  from compte");

            txtNombre.Text = Convert.ToString(a.ResultatRequette1("select count(*) from compte"));

            txtLib.Text = "";
            txtDes.Text = "";
          

            btnEnregistrer.Enabled = true;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
           
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGriview1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            lecode = Convert.ToString(dataGridView1.CurrentRow.Cells["id_compte"].Value);
            txtLib.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["libelle"].Value);
            txtDes.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["description"].Value);
           

            btnEnregistrer.Enabled = false;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    Retrait = "Non";
        //}

        //private void radioButton3_CheckedChanged(object sender, EventArgs e)
        //{
        //    Encaissement = "Oui";
        //}

        //private void radioButton4_CheckedChanged(object sender, EventArgs e)
        //{
        //    Encaissement = "Non";
        //}

        //private void radioButton5_CheckedChanged(object sender, EventArgs e)
        //{
        //    Virement = "Oui";
        //}

        //private void radioButton6_CheckedChanged(object sender, EventArgs e)
        //{
        //    Virement = "Non";
        //}

        //private void groupBox2_Enter(object sender, EventArgs e)
        //{

        //}

        private void select(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //    Retrait = "Oui";
        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //codeTypeCompte = a.ResultatRequette1(" SELECT numero FROM type_compte WHERE numero = '" + cboNumero.Text + "'");
            requette = ("INSERT INTO compte VALUES (NULL,'" + txtLib.Text + "','" + txtDes.Text + "')");
            // requette =( "CALL creation_numero_compte ('" + txtNumCompte.Text + "'," + codeTypeCompte + ",'" + Retrait + "','" + Encaissement + "','" + Virement + "')");

            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {

            requette = ("Update compte Set  libelle = '" + txtLib.Text + "', description = '" + txtDes.Text + "'  WHERE id_compte = " + lecode + "");
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {

            requette = "delete from compte   WHERE id_compte  = " + lecode + "";
            a.ResultatRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
