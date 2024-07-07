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
    public partial class Reservationlist : Form
    {
        String connectionString = "Data Source = reservations.db; Version=3";
        SQLiteConnection connection;

        public Reservationlist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            String selectSQl = "Select number, time, name from List ";
            SQLiteCommand command = new SQLiteCommand(selectSQl, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                richTextBox1.AppendText($"\"Table number: {reader.GetString(0)}\", \"Time: {reader.GetString(1)}\", \"Name:{reader.GetString(2)}\"");
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText(Environment.NewLine);
            }
            connection.Close();
        }

        private void Reservationlist_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staffmain staffmain = new Staffmain();
            this.Hide();
            staffmain.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("26.html"))
            {
                
                Process.Start("26.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
