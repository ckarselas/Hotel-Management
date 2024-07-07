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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ergasiaui
{
    public partial class Staff1 : Form
    {
        public Staff1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string roomNumberText = textBox3.Text;
            string password = textBox1.Text; 

            
            if (!string.IsNullOrWhiteSpace(roomNumberText) && !string.IsNullOrWhiteSpace(password))
            {
                
                int roomNumber;

                if (int.TryParse(roomNumberText, out roomNumber))
                {
                    
                    if ((roomNumber >= 100 && roomNumber <= 110) || (roomNumber >= 200 && roomNumber <= 210))
                    {
                        
                        if (password == "1111")
                        {
                           
                            Rooms room = new Rooms();
                            this.Hide();
                            room.ShowDialog();
                            this.Close();
                           
                        }
                        else
                        {
                            
                            MessageBox.Show("Incorrect password.");
                        }
                    }
                    else
                    {
                        
                        MessageBox.Show("Your room number is wrong.");
                    }
                }
                else
                {
                    
                    MessageBox.Show("Invalid room number.");
                }
            }
            else
            {
                
                MessageBox.Show("Please enter both room number and password.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            string password = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar))
            {
                
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staffmain staffmain = new Staffmain();
            this.Hide();
            staffmain.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("20.html"))
            {

                Process.Start("20.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
