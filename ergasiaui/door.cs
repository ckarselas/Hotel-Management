using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ergasiaui
{
    public partial class door : Form
    {
        SoundPlayer player = new SoundPlayer("gate.wav");
        
        public door()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = "door1.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != "door4.png")
            {
                pictureBox1.ImageLocation = "door4.png";
                player.Play();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != "door2.png")
            {
                pictureBox1.ImageLocation = "door2.png";
                player.Play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != "door1.png")
            {
                pictureBox1.ImageLocation = "door1.png";
                player.Play();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != "door3.png")
            {
                pictureBox1.ImageLocation = "door3.png";
                player.Play();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists("31.html"))
            {

                Process.Start("31.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
