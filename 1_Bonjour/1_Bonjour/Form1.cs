//Auteur: Altin Zili
//Date: 06.05.2019






using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Bonjour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false; //Au chargement du programme le bouton est désactivé
        
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true; //lorsque du texte est entré dans la TextBox Activer le bouton s'active
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Bonjour " + textBox1.Text; //Lorsqu'on clique sur le bouton, un "Bonjour + nom entré dans la Textbox sera affiché
            textBox1.Text = null; //Lorsqu'on clique sur le bouton, le texte dans la Textbox se vide
            button1.Enabled = false; //Lorsqu'on clique sur le bouton, il se désactivera
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
