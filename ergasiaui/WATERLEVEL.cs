using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ergasiaui
{
    public partial class WATERLEVEL : Form
    {
        int count = 0;
        public WATERLEVEL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 5)
            {
                count++;
                pictureBox1.ImageLocation = count + "m.png";

            }
            else {
                MessageBox.Show("The pool have reached maximum water level ");
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count >0)
            {
                count--;
                pictureBox1.ImageLocation = count + "m.png";

            }
            else
            {
                MessageBox.Show("The pool is empty ");
                    }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("33.html"))
            {

                Process.Start("33.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
    }
