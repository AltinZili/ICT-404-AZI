using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Fenetre : Form
    {
        int Compteur = 0;
        int Compteur2 = 0;
        public Fenetre()
        {
            InitializeComponent();
        }

        private void btnHG_Click(object sender, EventArgs e)
        {
            this.SetBounds(0, 0, this.Width, this.Height);
            Compteur++;
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            this.SetBounds(Screen.PrimaryScreen.Bounds.Width - this.Width, 0, this.Width, this.Height);
            Compteur++;
        }

        private void btnBG_Click(object sender, EventArgs e)
        {
            this.SetBounds(0, Screen.PrimaryScreen.Bounds.Height - this.Height, this.Width, this.Height);
            Compteur++;
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            this.SetBounds(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height, this.Width, this.Height);
            Compteur++;
        }

        private void btnbleu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            Compteur2++;
        }

        private void btnrouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            Compteur2++;
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnstats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Compteur + " déplacement(s), " + Compteur2 + " changement(s) de couleur.");
        }
    }
}
