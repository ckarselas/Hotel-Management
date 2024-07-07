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
using System.IO;

namespace ergasiaui
{
    public partial class StaffRoomService : Form
    {
        String connectionString = "Data Source = roomservice.db;Version=3";
        SQLiteConnection connection;
        public StaffRoomService()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            String selectSQl = "Select room_number, order_description from Orders ";
            SQLiteCommand command = new SQLiteCommand(selectSQl, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            richTextBox1.Clear();

            int orderNumber = 1; 

            while (reader.Read())
            {
                richTextBox1.AppendText($"Order {orderNumber}: \"Room or Table: {reader.GetString(0)}\", \"Products:{reader.GetString(1)}\"");
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText(Environment.NewLine);

                orderNumber++;
            }
            connection.Close();
        }

        private void StaffRoomService_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staffmain  staffmain = new Staffmain();
            this.Hide();
            staffmain.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("25.html"))
            {
                
                Process.Start("25.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
