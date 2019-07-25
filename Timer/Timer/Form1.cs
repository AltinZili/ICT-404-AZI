using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    
    public partial class Form1 : Form
    {
        Random Hasard = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void boutton1_Click(object sender, EventArgs e)
        {
            int x = Hasard.Next(1, this.Width - pictureBox1.Width);
            int y = Hasard.Next(50, this.Height - pictureBox1.Height);
            pictureBox1.Visible = true;
            pictureBox1.Top = y;
            pictureBox1.Left = x;
            timer1.Enabled = true;
            //this.SetBounds(Screen.PrimaryScreen.Bounds.Width - this.Width, 0, this.Width, this.Height);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Top > 0)
             {
                 pictureBox1.Top = pictureBox1.Top - 2;

             }
            else
            {
               
                pictureBox1.Top = pictureBox1.Top - 0; //EXPLOSION DU BALLON !!!!
            }
        }
    }
}
