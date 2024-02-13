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
    public partial class frmInscrire : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette = "";
        int lecode;
        string requette_nom_prenom = "";
        string requette_libelle = "";
        int codeadherent, codeCycle;

        public frmInscrire()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Chargement();
        }
        void Chargement()
        {
            a.ChargeTable1(dataGridView1, "SELECT code_inscrire,inscrire.code_adherent,  inscrire.code_cycle, concat(nom,'  ',prenom) NomComplet, lib_cycle FROM inscrire, cycle, adherent WHERE inscrire.code_cycle = cycle.code_cycle AND inscrire.code_adherent = adherent.code_adherent ");

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnEnregistrer, "Enregistrer");
           // tooltip.SetToolTip(btnModifier, "Modifier");
            tooltip.SetToolTip(btnSupprimer, "Supprimer");
            tooltip.SetToolTip(btnFermer, "Fermer");

            requette_libelle = "select lib_cycle from cycle";
            a.ChargeCombo(cboCycle, requette_libelle);
            requette_nom_prenom = "select concat(nom,'  ',prenom) from adherent";
            a.ChargeCombo(cboAdherent, requette_nom_prenom);



           txtNombre.Text = Convert.ToString(a.ResultatRequette1("select count(*) from inscrire"));

            btnEnregistrer.Enabled = true;
            btnSupprimer.Enabled = false;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            codeadherent = a.ResultatRequette1("SELECT code_adherent FROM adherent WHERE concat(nom,'  ',prenom) = '" + cboAdherent.Text + "'");
            codeCycle = a.ResultatRequette1(" SELECT code_cycle FROM cycle WHERE lib_cycle = '" + cboCycle.Text + "'");
            requette = ("INSERT INTO inscrire VALUES (NULL," + codeadherent + "," + codeCycle + ")");
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void dataGriview1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["code_inscrire"].Value);
            cboCycle.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["lib_cycle"].Value);
            cboAdherent.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["NomComplet"].Value);

            codeadherent = a.ResultatRequette1("SELECT code_adherent FROM adherent WHERE concat(nom,'  ',prenom) = '" + cboAdherent.Text + "'");
            codeCycle = a.ResultatRequette1(" SELECT code_cycle FROM cycle WHERE lib_cycle = '" + cboCycle.Text + "'");

            btnEnregistrer.Enabled = false;
            btnSupprimer.Enabled = true;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

      

        private void select(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnEnregistrer_Click_2(object sender, EventArgs e)
        {
            codeadherent = a.ResultatRequette1("SELECT code_adherent FROM adherent WHERE concat(nom,'  ',prenom) = '" + cboAdherent.Text + "'");
            codeCycle = a.ResultatRequette1(" SELECT code_cycle FROM cycle WHERE lib_cycle = '" + cboCycle.Text + "'");
            requette = ("INSERT INTO inscrire VALUES (NULL," + codeadherent + "," + codeCycle + ")");
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            requette = "DELETE FROM  inscrire  WHERE code_inscrire = " + lecode + "";
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
