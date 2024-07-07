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
    public partial class Staffmain : Form
    {
        public Staffmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff1 staff1 = new Staff1();
            this.Hide();
            staff1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffRoomService roomService = new StaffRoomService();
            this.Hide();
            roomService.ShowDialog();   
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pool pool = new Pool();
            this.Hide();    
            pool.ShowDialog();  
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reservationlist reservationlist = new Reservationlist();
            this.Hide();    
            reservationlist.ShowDialog();   
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists("19.html"))
            {

                Process.Start("19.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
