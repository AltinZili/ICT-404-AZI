using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            int et;
            if (txtTable.Text == "")
            {
                MessageBox.Show("Introduisez le numéro de la table", "Erreur");
                lblComChoisie.Text = "";
                return;
            }
            if (!int.TryParse(txtTable.Text, out et))
            {
                MessageBox.Show("Introduisez un chiffre", "Erreur");
                lblComChoisie.Text = "";
                return;
            }
            lblComChoisie.Text = "Pour la " + txtTable.Text + ": ";
            if (rdoEpaisse.Checked == true)
            {
                lblComChoisie.Text += "pâte epaisse ";
            }
            if (rdoNormale.Checked == true)
            {
                lblComChoisie.Text += "pâte normale ";
            }
            if (rdoFine.Checked == true)
            {
                lblComChoisie.Text += "pâte fine ";
            }
            if (rdoExtra.Checked == true)
            {
                lblComChoisie.Text += "pâte extra-fine ";
            }
            lblComChoisie.Text += "avec ";
            if (chkAnchois.Checked == true)
            {
                lblComChoisie.Text += "anchois, ";
            }
            if (chkCapres.Checked == true)
            {
                lblComChoisie.Text += "câpres, ";
            }
            if (chkJambon.Checked == true)
            {
                lblComChoisie.Text += "jambon, ";
            }
            if (chkCrevettes.Checked == true)
            {
                lblComChoisie.Text += "crevettes, ";
            }
            
            lblComChoisie.Text = lblComChoisie.Text.Substring(0, lblComChoisie.Text.Length-2); 
        }

    }
}
