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
    public partial class frmImpression : Form
    {
        mon_dataset sDs = new mon_dataset();
        mon_dataset sDs1 = new mon_dataset();

        public frmImpression()
        {
            InitializeComponent();
        }

        void gestion_impression()
        {

            int i;
            DataTable TabPrint = new DataTable("DataTable1");
            DataTable TabPrint1 = new DataTable("DataTable2");

            //ajout de la table de l'impresseion
            sDs.Tables.Add(TabPrint);
            sDs.Tables.Add(TabPrint1);

            //ajout des colonnes dans le dataset
            DataColumn dCol1 = new DataColumn("DataColumn1", Type.GetType("System.String"));
            DataColumn dCol2 = new DataColumn("DataColumn2", Type.GetType("System.String"));
            DataColumn dCol3 = new DataColumn("DataColumn3", Type.GetType("System.String"));
            DataColumn dCol4 = new DataColumn("DataColumn4", Type.GetType("System.String"));
            DataColumn dCol5 = new DataColumn("DataColumn5", Type.GetType("System.String"));
            DataColumn dCol6 = new DataColumn("DataColumn6", Type.GetType("System.String"));
            DataColumn dCol7 = new DataColumn("DataColumn7", Type.GetType("System.String"));
            DataColumn dCol8 = new DataColumn("DataColumn8", Type.GetType("System.String"));
            DataColumn dCol9 = new DataColumn("DataColumn9", Type.GetType("System.String"));
            DataColumn dCol10 = new DataColumn("DataColumn10", Type.GetType("System.String"));

            TabPrint.Columns.Add(dCol1);
            TabPrint.Columns.Add(dCol2);
            TabPrint.Columns.Add(dCol3);
            TabPrint.Columns.Add(dCol4);
            TabPrint.Columns.Add(dCol5);
            TabPrint.Columns.Add(dCol6);
            TabPrint.Columns.Add(dCol7);
            TabPrint.Columns.Add(dCol8);
            TabPrint.Columns.Add(dCol9);
            TabPrint.Columns.Add(dCol10);

            switch (ClasseGenerale.gNomEtatImpression)
            {
                case "etat_planification":
                    //chargement des lignes grâce à la table stores du formulaire 2
                    foreach (DataRow ligne in ClasseGenerale.dsPrint.Tables[0].Rows)
                    {
                        DataRow NouvelleLigne = TabPrint.NewRow();
                        NouvelleLigne["DataColumn1"] = ligne.ItemArray[0];
                        NouvelleLigne["DataColumn2"] = ligne.ItemArray[1];
                        NouvelleLigne["DataColumn3"] = ligne.ItemArray[2];
                        NouvelleLigne["DataColumn4"] = ligne.ItemArray[3];
                        NouvelleLigne["DataColumn5"] = ligne.ItemArray[4];
                        NouvelleLigne["DataColumn6"] = ligne.ItemArray[5];
                        NouvelleLigne["DataColumn7"] = ligne.ItemArray[6];
                       // NouvelleLigne["DataColumn8"] = ligne.ItemArray[7];
                       // NouvelleLigne["DataColumn9"] = ligne.ItemArray[8];
                       // NouvelleLigne["DataColumn10"] = ligne.ItemArray[9];
                        TabPrint.Rows.Add(NouvelleLigne);
                    }
                    etat_planification objrpt = new etat_planification();
                    objrpt.SetDataSource(TabPrint);
                    crystalReportViewer1.ReportSource = objrpt;
                    break;

                case "liste_adherent":
                    //chargement des lignes grâce à la table stores du formulaire 2
                    foreach (DataRow ligne in ClasseGenerale.dsPrint.Tables[0].Rows)
                    {
                        DataRow NouvelleLigne = TabPrint.NewRow();
                        NouvelleLigne["DataColumn1"] = ligne.ItemArray[0];
                        NouvelleLigne["DataColumn2"] = ligne.ItemArray[1];
                        NouvelleLigne["DataColumn3"] = ligne.ItemArray[2];
                        NouvelleLigne["DataColumn4"] = ligne.ItemArray[3];
                        NouvelleLigne["DataColumn5"] = ligne.ItemArray[4];
                        NouvelleLigne["DataColumn6"] = ligne.ItemArray[5];
                        NouvelleLigne["DataColumn7"] = ligne.ItemArray[6];
                       // NouvelleLigne["DataColumn8"] = ligne.ItemArray[7];
                        TabPrint.Rows.Add(NouvelleLigne);
                    }
                    liste_adherent objrpt1 = new liste_adherent();
                    objrpt1.SetDataSource(TabPrint);
                    crystalReportViewer1.ReportSource = objrpt1;
                    break;
            }
            crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmImpression_Load_1(object sender, EventArgs e)
        {

            gestion_impression();
            this.Text = ClasseGenerale.gNomProjet + " Gestion des impressions";

        }

    }
}
