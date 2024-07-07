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
    public partial class Horsemain : Form
    {
        int count = 1;
        SoundPlayer player= new SoundPlayer("ladder.wav");
        public Horsemain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
            if (count%2==1)
            {
                MessageBox.Show("Ladder is going down!");

            }
            else
            {
                MessageBox.Show("Ladder is coming up!");
            }
            count++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            door door = new door(); 
            door.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation();
            this.Hide();
            navigation.ShowDialog();   
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customermain customermain = new Customermain(); 
            this.Hide();
            customermain.ShowDialog();
            this.Close();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists("16.html"))
            {

                Process.Start("16.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Customermain customermain = new Customermain();
            this.Hide();
            customermain.ShowDialog();
            this.Close();
        }
    }
}
