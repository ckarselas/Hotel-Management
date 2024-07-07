using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ergasiaui
{
    public partial class TEMPERATURE : Form
    {
        int count = 1;
        public TEMPERATURE()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count > 1)
            {
                count--;
                pictureBox1.ImageLocation = "temp" + count + ".png";
                
            }
            else
            {
                MessageBox.Show("Pool have reached the coldest temperature!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 5) {
                count++;
                pictureBox1.ImageLocation = "temp" + count + ".png";
                
            }
            else
            {
                MessageBox.Show("Pool have reached the hotest temperature!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("1.html"))
            {

                Process.Start("1.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
