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
    public partial class frmCalculatrice : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public frmCalculatrice()
        {
            InitializeComponent();
        }

        private void frmCalculatrice_Load(object sender, EventArgs e)
        {

        }

     
        private void Button2_Click(object sender, EventArgs e)
        {
            txtResultat.Text = "0";
        }

        private void bt_click(object sender, EventArgs e)
        {
            if ((txtResultat.Text == "0") || (operation_pressed)) 
                txtResultat.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            txtResultat.Text = txtResultat.Text + b.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(txtResultat.Text);
            operation_pressed = true;
            equation .Text = value +" " + operation;
        }

        private void btEgal_Click(object sender, EventArgs e)
        {
             equation.Text = "";
             operation_pressed = false;

             switch (operation )
          {
                 case "+":
                     txtResultat .Text =(value + double.Parse(txtResultat.Text)).ToString ();
                     break ;
                 case "-":
                     txtResultat .Text =(value - double.Parse(txtResultat.Text)).ToString ();
                     break ;
                 case "*":
                     txtResultat .Text =(value * double.Parse(txtResultat.Text)).ToString ();
                     break ;
                 case "/":
                     txtResultat .Text =(value / double.Parse(txtResultat.Text)).ToString ();
                     break ;
                 default :
                     break ;

          }//end switch
            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtResultat.Text="0";
            value = 0;
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            txtResultat.Text = "0";

        }
    }
}
