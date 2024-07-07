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
    public partial class pay : Form
    {
        Service roomservice; 

        public pay(Service room_service)
        {
            InitializeComponent();
            this.roomservice = room_service;
        }
    
        public pay()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void nfc_Load(object sender, EventArgs e)
        {
            textBox1.Text = roomservice.TotalTextBox.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your order!");
            Restaurant restaurant   = new Restaurant();
            this.Hide();
            restaurant.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CARD card = new CARD();
            this.Hide();
            card.ShowDialog();  
            this.Close();   
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("34.html"))
            {

                Process.Start("34.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
