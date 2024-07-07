using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace ergasiaui
{
    public partial class airconditioner : Form
    {   SoundPlayer blip =new SoundPlayer("blip.wav");
        SoundPlayer air = new SoundPlayer("air.wav");

        int temp = 15;
        public airconditioner()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((temp <30 ) && (pictureBox1.ImageLocation == "poweron.jpg")) {
                temp++;
                textBox1.Text = temp.ToString();
                blip.Play();
                air.PlayLooping();

            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if ((temp >0) && (pictureBox1.ImageLocation == "poweron.jpg") )
            {
                temp--;
                textBox1.Text = temp.ToString() ;
                
                blip.Play();
                air.PlayLooping();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != "poweron.jpg") {
                textBox1.Text = temp.ToString();
                pictureBox1.ImageLocation = "poweron.jpg";
                blip.Play();
                air.PlayLooping();
            }
            else {
                pictureBox1.ImageLocation = "powerof.jpg";
                textBox1.Text= string.Empty;
                air.Stop();
                blip.Play();
                
            }

        }

        private void Help(object sender, EventArgs e)
        {
            if (File.Exists("28.html"))
            {

                Process.Start("28.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
