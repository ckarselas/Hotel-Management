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
    public partial class card1 : Form
    {
        public card1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your order!\nPayment succesful!");
            Room room = new Room();
            this.Hide();
            room.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("30.html"))
            {

                Process.Start("30.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
