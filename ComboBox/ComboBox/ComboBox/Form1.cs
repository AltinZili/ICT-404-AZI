using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        string variable;
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEntreprises.Items.Add("Swisscom" );
            cmbEntreprises.Items.Add("Arches");
            cmbEntreprises.ForeColor = Color.Blue;
            cmbEntreprises.SelectedItem = "Arches";
            cmbGymnases.Items.Add("Gymnase du Bugnon");
            cmbGymnases.Items.Add("Gymnase de Beaulieu");
            cmbGymnases.Items.Add("Gymnase d'Yverdon");
            cmbGymnases.ForeColor = Color.Red;
            lstEcoles.Items.Add("CEPM");
            lstEcoles.Items.Add("CPNV");
            lstEcoles.Items.Add("ECL");
            lstEcoles.Items.Add("EPCL");
            lstEcoles.Items.Add("EPSIC");
            lstEcoles.Items.Add("ETML");
            lstEcoles.ForeColor = Color.Green;
            lstAjouter.ForeColor = Color.Brown;
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (lstEcoles.SelectedIndex == -1 && cmbEntreprises.SelectedIndex  == -1 && cmbGymnases.SelectedIndex == -1)
            {
                MessageBox.Show("erreur, sélectionnez quelque chose");
                return;
            }
            if(!lstAjouter.Items.Contains(variable))
            {
                lstAjouter.Items.Add(variable);
                counter++;
                lblCount.Text = counter.ToString();
            }        
        }

        

        private void cmbEntreprises_SelectedIndexChanged(object sender, EventArgs e)
        {
            variable = cmbEntreprises.SelectedItem.ToString();
        }

        private void lstEcoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            variable = lstEcoles.SelectedItem.ToString();
        }

        private void cmbGymnases_SelectedIndexChanged(object sender, EventArgs e)
        {
            variable = cmbGymnases.SelectedItem.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            lstAjouter.Items.Remove(lstAjouter.SelectedItem);
            counter--;
            lblCount.Text = counter.ToString();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            lstAjouter.Items.Clear();
            counter = 0;
            lblCount.Text = counter.ToString();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "FormClosing",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
    }
}
