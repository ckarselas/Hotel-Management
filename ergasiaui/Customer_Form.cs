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
    public partial class Customer_Form : Form
    {
        
        public static string roomNumberText { get; private set; }

        public Customer_Form()
        {
            InitializeComponent();
        }

        private void User_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string roomNumberText = richTextBox1.Text;

           
            if (!string.IsNullOrWhiteSpace(roomNumberText))
            {
                
                int roomNumber = Convert.ToInt32(roomNumberText);

               
                if ((roomNumber >= 100 && roomNumber <= 110) || (roomNumber >= 200 && roomNumber <= 210))
                {
                    if (textBox1.Text == "3545" + roomNumber)
                    {
                        
                        Room room = new Room();
                        this.Hide();
                        room.ShowDialog();
                        this.Close();
                        
                    }
                }
                else
                {
                    
                    MessageBox.Show("Your room number is wrong.");
                }
            }
            else
            {
                
                MessageBox.Show("Please enter a room number.");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar))
            {
             
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void richTextBox1_AcceptsTabChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            string password = textBox1.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {

                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customermain customermain = new Customermain();
            this.Hide();
            customermain.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("8.html"))
            {

                Process.Start("8.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
