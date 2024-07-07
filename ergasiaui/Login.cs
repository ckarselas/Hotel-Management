using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ergasiaui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          Customermain customermain = new Customermain();
            this.Hide();
            customermain.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Stafflog stafflog = new Stafflog();
            this.Hide();
            stafflog.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoomService roomService = new RoomService();
            roomService.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
         Navigation navigation = new Navigation();
            navigation.ShowDialog();    
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

          
           
            if (File.Exists("manual.html"))
            {
               
                Process.Start("manual.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
