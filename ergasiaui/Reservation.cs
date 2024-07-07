using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
    public partial class Reservation : Form
    {
        String connectionString = "Data Source = reservations.db; Version=3";
        SQLiteConnection connection;

        public Reservation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            if (( textBox1.Text!="") &&(Convert.ToInt32(this.textBox1.Text)>=1 && Convert.ToInt32(this.textBox1.Text) <= 17))
            { 
                if (textBox2.Text != "")
                {
                    if(textBox3.Text != "")
                    {
                        connection.Open();
                        string insertSQL = "INSERT INTO List (number, time, name) VALUES (@number, @time, @name)";
                        using (SQLiteCommand command = new SQLiteCommand(insertSQL, connection))
                        {
                            command.Parameters.AddWithValue("@number", textBox1.Text);
                            command.Parameters.AddWithValue("@time", textBox2.Text);
                            command.Parameters.AddWithValue("@name", textBox3.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                        }

                        MessageBox.Show("Reservation was made for " + textBox3.Text + " at " + textBox2.Text + " for table " + textBox1.Text);
                        Customermain customermain = new Customermain();
                        this.Hide();
                        customermain.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Please write your lastname!");
                    }
                }
                else
                {
                    MessageBox.Show("You haven't select the time!");

                }
            }
        else
            {
                MessageBox.Show("Table Number does not exist!");
            }
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Insert only numbers");
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "^[0-9:.]*$"))
            {
                MessageBox.Show("Please insert the time like this 12:15");
                textBox2.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "^[a-zA-Zα-ωΑ-Ω ]*$"))
            {
                MessageBox.Show("Your name must only contain letters!");
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text= string.Empty;    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant();
            this.Hide();
            restaurant.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customermain customermain = new Customermain();
            this.Hide();
            customermain.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists("5.html"))
            {

                Process.Start("5.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
