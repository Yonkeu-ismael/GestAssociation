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
    public partial class frmOpération : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette = "";
        int lecode;
        string requette_libelle = "";
        string requette_lib_cyle = "";
        string requette_nom_prenom = "";
        int codecompte, codeCycle, codeadherent;

        public frmOpération()
        {
            InitializeComponent();
        }

        private void frmOpération_Load(object sender, EventArgs e)
        {
            Chargement(); 
        }
        void Chargement()
        {
            a.ChargeTable1(dataGridView1, "SELECT code_operation,operation.id_compte,operation.code_adherent, operation.code_cycle,libelle, concat(nom,'  ',prenom)NomComplet, lib_cycle,date_op,montant_payer,date_effe_op FROM operation, cycle, compte,adherent WHERE operation.code_adherent=adherent.code_adherent AND operation.code_cycle = cycle.code_cycle AND operation.id_compte = compte.id_compte" );

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnEnregistrer, "Enregistrer");
            //tooltip.SetToolTip(btnModifier, "Modifier");
            tooltip.SetToolTip(btnSupprimer, "Supprimer");
            tooltip.SetToolTip(btnFermer, "Fermer");

            requette_lib_cyle = "select lib_cycle from cycle";
            a.ChargeCombo(cboCycle, requette_lib_cyle);
            requette_libelle = "select libelle from compte";
            a.ChargeCombo(cboLib, requette_libelle);
            requette_nom_prenom = "select concat(nom,'  ',prenom) from adherent";
            a.ChargeCombo(cboAdhe, requette_nom_prenom);



            txtNombre.Text = Convert.ToString(a.ResultatRequette1("select count(*) from operation  "));

            cboAdhe.Text = "";
            cboLib.Text = "";
            cboCycle.Text = "";
            dtpDate.Text = "";
            txtMontant.Text = "";
            dtpDateEffe.Text = "";

            btnEnregistrer.Enabled = true;
            btnSupprimer.Enabled = false;
            //btnModifier.Enabled = false;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
        }

        //private void btnModifier_Click(object sender, EventArgs e)
        //{
        //    requette = ("UPDATE operation SET code_adherent=" + codeadherent + " ,id_compte=" + codecompte + ", code_cycle=" + codeCycle + " , date_op = '" + dtpDate.Text + "',montant_payer='" + txtMontant.Text + "', date_effe_op = '" + dtpDateEffe.Text + "' WHERE code_operation =" + lecode + "");
        //    a.ExecuteRequette(requette);

        //    Chargement();

        //    MessageBox.Show("Opération éffectuée avec succès !");
        //}

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["code_operation"].Value);
            cboLib.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["libelle"].Value);
            cboCycle.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["lib_cycle"].Value);
            dtpDate.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["date_op"].Value);
            txtMontant.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["montant_payer"].Value);
            dtpDateEffe.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["date_effe_op"].Value);
            cboAdhe.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["NomComplet"].Value);


            codeadherent = a.ResultatRequette1("SELECT code_adherent FROM adherent WHERE concat(nom,'  ',prenom) = '" + cboAdhe.Text + "'");
            codecompte = a.ResultatRequette1("SELECT id_compte FROM compte WHERE libelle = '" + cboLib.Text + "'");
            codeCycle = a.ResultatRequette1(" SELECT code_cycle FROM cycle WHERE lib_cycle = '" + cboCycle.Text + "'");

            btnEnregistrer.Enabled = false;
            //btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {

            codecompte = a.ResultatRequette1("SELECT id_compte FROM compte WHERE libelle = '" + cboLib.Text + "'");
            codeCycle = a.ResultatRequette1(" SELECT code_cycle FROM cycle WHERE lib_cycle = '" + cboCycle.Text + "'");
            codeadherent = a.ResultatRequette1("SELECT code_adherent FROM adherent WHERE concat(nom,'  ',prenom) = '" + cboAdhe.Text + "'");
            requette = ("INSERT INTO operation VALUES (NULL," + codeadherent + "," + codecompte + "," + codeCycle + ",'" + dtpDate.Text + "','" + txtMontant.Text + "','" + dtpDateEffe.Text + "')");
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {

            requette = "delete from operation   WHERE code_operation = " + lecode + "";
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
