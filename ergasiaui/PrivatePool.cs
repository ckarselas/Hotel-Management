using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ergasiaui
{
    public partial class PrivatePool : Form
    {
        public PrivatePool()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WATERLEVEL wATERLEVEL = new WATERLEVEL();
            wATERLEVEL.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            code code = new code(); 
            code.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TEMPERATURE tEMPERATURE = new TEMPERATURE();
            tEMPERATURE.ShowDialog();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            this.Hide();
            room.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("22.html"))
            {

                Process.Start("22.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
