using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int rabbit1, rabbit2, rabbit3;

        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int widthrabbit1 = pictureBox1.Width;
            int widthrabbit2 = pictureBox2.Width;
            int widthrabbit3 = pictureBox3.Width;
            int start = label5.Left;
            pictureBox1.Left = pictureBox1.Left + rnd.Next(5, 16);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(5, 16);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(5, 16);
            if(widthrabbit1+pictureBox1.Left>=start)
            if(pictureBox1.Left>pictureBox2.Left+5&&pictureBox1.Left>pictureBox3.Left+5)
                {
                    label6.Text = "the race continues first";
                }
            if(pictureBox2.Left>pictureBox1.Left+5&&pictureBox2.Left>pictureBox3.Left+5)
            {
                label6.Text = "rabbit2 got ahead";
            }
            if(pictureBox3.Left>pictureBox1.Left+5&&pictureBox3.Left>pictureBox2.Left+5)
            {
             
                label6.Text = "rabbit3 took first place";
            }
            {
                timer1.Enabled = false;
            } 
            if(widthrabbit1+pictureBox1.Left>=start)
            {
                timer1.Enabled = false;
                label6.Text = "Rabbi1 won the race";
            }
            if(widthrabbit2+pictureBox2.Left>=start)
            {
                timer1.Enabled = false;
                label6.Text = "Rabbit2 won the race";
            }
            if(widthrabbit3+pictureBox3.Left>=start)
            {
                timer1.Enabled = false;
                label6.Text = "Rabbit3 won the race";
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rabbit1 = pictureBox1.Left;
            rabbit2 = pictureBox2.Left;
            rabbit3 = pictureBox3.Left;

        }
    }
}
