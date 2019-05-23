using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deductions
{
    public partial class Form1 : Form
    {
        float revenu;
        float coeffamilial = 1;
        float checkjeune;
        float checktrans;
        float checkfidel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtjeune.Text = "900";
            txttransport.Text = "650";
            chkjeune.Checked = false;
            chktransport.Checked = false;
            chkfidelite.Checked = false;
            lblimposable.Visible = false;
        }

        private void btncalcul_Click(object sender, EventArgs e)
        {
            float revenucoeff;
            float pourcentages;
            float fidel = 0;
            float revenuimposable;
            

            revenucoeff = revenu / coeffamilial;
            revenuimposable = revenucoeff;

            pourcentages = revenucoeff / 100;
            fidel = pourcentages * checkfidel;
            if (chkfidelite.Checked == true)
            {
                revenuimposable = revenucoeff - fidel;
            }
            if(chktransport.Checked == true)
            {
                revenuimposable = revenuimposable - checktrans;
            }
            if(chkjeune.Checked == true)
            {
                revenuimposable = revenuimposable - checkjeune;
            }


            lblimposable.Visible = true;
            lblimposable.Text = "Revenu imposable:" + revenuimposable;
            

          
        }

        private void txtrevenu_TextValidated(object sender, EventArgs e)
        {
            revenu = float.Parse(txtrevenu.Text);
        }

        private void txtcoeff_Validated(object sender, EventArgs e)
        {
            coeffamilial = float.Parse(txtcoeff.Text);
        }

        private void txtjeune_Validated(object sender, EventArgs e)
        {
            checkjeune = float.Parse(txtjeune.Text);
        }

        private void txttransport_Validated(object sender, EventArgs e)
        {
            checktrans = float.Parse(txttransport.Text);
        }

        private void txtfidelite_Validated(object sender, EventArgs e)
        {
            checkfidel = float.Parse(txtfidelite.Text);
        }
    }
}
