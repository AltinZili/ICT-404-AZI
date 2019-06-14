using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arche_De_Noe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDroite_Click(object sender, EventArgs e)
        {
            if (lstATerre.SelectedIndex == -1)
            {
                MessageBox.Show("erreur, sélectionnez un mot");
                return;
            }
            lstABord.Items.Add(lstATerre.SelectedItem);
            lstATerre.Items.Remove(lstATerre.SelectedItem);


        }
    }
}
