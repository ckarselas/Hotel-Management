using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ergasiaui
{
    public partial class Pool : Form
    {
        int count = 1;
        public Pool()
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

        private void button4_Click(object sender, EventArgs e)
        {
            Staffmain staffmain = new Staffmain();
            this.Hide();
            staffmain.ShowDialog(); 
            this.Close();
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ( count % 5 == 0)
            {
                MessageBox.Show("The pool is empty");
                count++;
                
            }
            else if ( count % 5 == 2) {
                MessageBox.Show("The pool has 10 people");
                count++;
            }

            else if (count % 5 == 3)
            {
                MessageBox.Show("The pool has 15 people");
                count++;
            }
            else if (count % 5 == 1)
            {
                MessageBox.Show("The pool has 5 people");
                count++;
            }
            else if (count % 5 == 4)
            {
                MessageBox.Show("The pool has 20 people");
                count++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists("23.html"))
            {

                Process.Start("23.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
