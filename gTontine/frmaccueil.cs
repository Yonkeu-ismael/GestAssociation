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
    public partial class frmSécurité : Form
    {
        string imglocat = "";

        public frmSécurité()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";
                openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imglocat = openFileDialog1.FileName.ToString();
                    ptbPhoto.ImageLocation = imglocat;
                }


                {
                    try
                    {
                        //if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            // using (myStream)
                            {
                                // Insert code to read the stream here.

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTontine f = new frmTontine();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCycle f = new frmCycle();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmutilisateur f = new frmutilisateur();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMenu f = new frmMenu();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmChangerpassword f = new frmChangerpassword();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmConnexion f = new frmConnexion();
            //f.ShowDialog();
           
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
            
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmSécurité_Load(object sender, EventArgs e)
        {
        
        }
        }
    }

