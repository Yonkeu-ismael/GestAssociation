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
    public partial class frmCycle : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette = "";
        int lecode;
      

        public frmCycle()
        {
            InitializeComponent();
        }
        void Chargement()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnEnregistrer, "Enregistrer");
            tooltip.SetToolTip(btnModifier, "Modifier");
            tooltip.SetToolTip(btnSupprimer, "Supprimer");
            tooltip.SetToolTip(btnFermer, "Fermer");

            a.ChargeTable1(dataGridView1, "select *  from cycle");


            txtNombre.Text = Convert.ToString(a.ResultatRequette1("select count(*) from cycle"));

            txtLibelle.Text = "";
            dtpDateDebut.Text = "";
            dtpDateFin.Text = "";

            btnEnregistrer.Enabled = true;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
        }


      

        private void dataGriview1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        

        private void frmCycle_Load(object sender, EventArgs e)
        {
            Chargement();
        }

        private void select(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dtpDateDebut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            requette = ("INSERT INTO cycle VALUES (null,'" + txtLibelle.Text + "','" + dtpDateDebut.Text + "','" + dtpDateFin.Text + "')");
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            requette = ("Update cycle Set lib_cycle = '" + txtLibelle.Text + "', date_debut = '" + dtpDateDebut.Text + "', date_fin = '" + dtpDateFin.Text + "' WHERE code_cycle = " + lecode + "");
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            requette = "delete from cycle   WHERE code_cycle = " + lecode + "";
            a.ResultatRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["code_cycle"].Value);
            txtLibelle.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["lib_cycle"].Value);
            dtpDateDebut.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["date_debut"].Value);
            dtpDateFin.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["date_fin"].Value);


            btnEnregistrer.Enabled = false;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
        }
    }
}
