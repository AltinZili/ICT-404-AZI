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
    public partial class lblcoefficient : Form
    {
        public lblcoefficient()
        {
            InitializeComponent();
        }

        private void lblcoefficient_Load(object sender, EventArgs e)
        {
            txtjeune.Text = "900";
            txttransport.Text = "650";
            chktransport.Enabled = false;
            chkjeune.Enabled = false;
            chkfidelite.Enabled = false;
            lblimposable.Visible = false;
        }

    }
}
