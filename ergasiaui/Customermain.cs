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
    public partial class Customermain : Form
    {
        public Customermain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Form customer_Form = new Customer_Form();
            this.Hide();
            customer_Form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant();
            this.Hide();
            restaurant.ShowDialog();
            this.Close();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Horse horse = new Horse();
            this.Hide();
            horse.ShowDialog(); 
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists("2.html"))
            {

                Process.Start("2.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
