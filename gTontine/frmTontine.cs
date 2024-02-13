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
    public partial class frmTontine : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette = "";
        int lecode;
        public frmTontine()
        {
            InitializeComponent();
        }

        private void frmTontine_Load(object sender, EventArgs e)
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

            a.ChargeTable1(dataGridView1, "select *  from tontine");


            txtNombre.Text = Convert.ToString(a.ResultatRequette1("select count(*) from tontine"));


            txtLibelle.Text = "";
            txtMontant.Text = "";

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
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["code_tontine"].Value);
            txtLibelle.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["libelle"].Value);
            txtMontant.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["montant"].Value);


            btnEnregistrer.Enabled = false;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
        }

        private void select(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            requette = ("INSERT INTO tontine VALUES (null,'" + txtLibelle.Text + "','" + txtMontant.Text + "')");
            a.ExecuteRequette(requette);
            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            requette = ("Update tontine Set libelle = '" + txtLibelle.Text + "', montant = '" + txtMontant.Text + "' WHERE code_tontine = " + lecode + "");
            a.ExecuteRequette(requette);
            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            requette = "delete from tontine   WHERE code_tontine = " + lecode + "";
            a.ResultatRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
