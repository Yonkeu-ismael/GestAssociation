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
    public partial class frmPlanification_rotative_des_bénéficiaires : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette = "";
        int lecode;
        string requette_nom_prenom = "";
        string requette_libelle = "";
        int codeadherent, codeCycle;
        public frmPlanification_rotative_des_bénéficiaires()
        {
            InitializeComponent();
        }

        private void frmPlanification_rotative_des_bénéficiaires_Load(object sender, EventArgs e)
        {
            Chargement();
        }
        void Chargement()
        {
            a.ChargeTable1(dataGridView1, "SELECT code_pla,planification.code_adherent,  planification.code_cycle, concat(nom,'  ',prenom) NomComplet, lib_cycle,date,montant,rang FROM planification, cycle, adherent WHERE planification.code_cycle = cycle.code_cycle AND planification.code_adherent = adherent.code_adherent ");

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnEnregistrer, "Enregistrer");
            tooltip.SetToolTip(btnModifier, "Modifier");
            tooltip.SetToolTip(btnSupprimer, "Supprimer");
            tooltip.SetToolTip(btnFermer, "Fermer");

            requette_libelle = "select lib_cycle from cycle";
            a.ChargeCombo(cboCycle, requette_libelle);
            requette_nom_prenom = "select concat(nom,'  ',prenom) NomComplet from adherent";
            a.ChargeCombo(cboAdhe, requette_nom_prenom);



            txtRang.Text = "";
            txtMontant.Text = "";
           


            txtNombre.Text = Convert.ToString(a.ResultatRequette1("select count(*) from planification  "));

            btnEnregistrer.Enabled = true;
            btnSupprimer.Enabled = false;
            btnModifier.Enabled = false;
        }


     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["code_pla"].Value);
            cboAdhe.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["NomComplet"].Value);
            cboCycle.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["lib_cycle"].Value);
            dtpDate.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["date"].Value);
            txtMontant.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["montant"].Value);
            txtRang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["rang"].Value);



            codeadherent = a.ResultatRequette1("SELECT code_adherent FROM adherent WHERE concat(nom,'  ',prenom)= '" + cboAdhe.Text + "'");
            codeCycle = a.ResultatRequette1(" SELECT code_cycle FROM cycle WHERE lib_cycle = '" + cboCycle.Text + "'");


            btnEnregistrer.Enabled = false;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            codeadherent = a.ResultatRequette1("SELECT code_adherent FROM adherent WHERE concat(nom,'  ',prenom)  = '" + cboAdhe.Text + "'");
            codeCycle = a.ResultatRequette1(" SELECT code_cycle FROM cycle WHERE lib_cycle = '" + cboCycle.Text + "'");
            requette = ("INSERT INTO planification VALUES (NULL," + codeadherent + "," + codeCycle + ",'" + dtpDate.Text + "','" + txtMontant.Text + "','" + txtRang.Text + "')");
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            requette = "UPDATE planification SET code_adherent=" + codeadherent + ",code_cycle=" + codeCycle + " ,date = '" + dtpDate.Text + "',montant='" + txtMontant.Text + "', rang = '" + txtRang.Text + "' WHERE code_pla =" + lecode + "";
            a.ExecuteRequette(requette);

            Chargement();

            MessageBox.Show("Opération éffectuée avec succès !");
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            requette = "DELETE FROM planification WHERE code_pla =" + lecode + "";
            a.ExecuteRequette(requette);

            Chargement();

            MessageBox.Show("Opération éffectuée avec succès !");
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
