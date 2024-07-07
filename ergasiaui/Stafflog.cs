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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace ergasiaui
{
    public partial class Stafflog : Form
    {
        public Stafflog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            string password = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1111")
            {
                Staffmain staffmain = new Staffmain();
                this.Hide();
                staffmain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You have entered the wrong password!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog(); 
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("18.html"))
            {

                Process.Start("18.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
