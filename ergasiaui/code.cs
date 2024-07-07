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
using System.IO;

namespace ergasiaui
{
    public partial class code : Form
    {   bool alarm=false;
        SoundPlayer blip =new SoundPlayer("blip.wav");
        SoundPlayer alarm1 = new SoundPlayer("alarm.wav");
        public code()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            blip.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            blip.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            blip.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            blip.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            blip.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            blip.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            blip.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            blip.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
                blip.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
                blip.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            blip.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {   blip.Play();
            if ((textBox1.Text == "4567") && (alarm == false))
            {
                MessageBox.Show("Alarm activated");
                alarm = true;
            }
            else if ((textBox1.Text == "4567") && (alarm == true))
            {
                MessageBox.Show("Alarm deactivated");
                alarm = false;

            }
            else { alarm1.Play();
                MessageBox.Show("Wrong password");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (File.Exists("14.html"))
            {

                Process.Start("14.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
