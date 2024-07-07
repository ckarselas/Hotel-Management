using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace ergasiaui
{
    public partial class Room : Form
    {
             
         
        
        int num = 1;
        SoundPlayer player = new SoundPlayer();
        Boolean songplaying = false;
        SoundPlayer tv = new SoundPlayer("tv.wav"); 

        public Room()
        {
            InitializeComponent();
        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation == "roomdark.png")
            {
                pictureBox1.ImageLocation = "roomlight.png";
                pictureBox3.ImageLocation = "toogle1.png";

            }
            else
            {
                pictureBox1.ImageLocation = "roomdark.png";
                pictureBox3.ImageLocation = "toogle2.png";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            airconditioner airconditioner = new airconditioner();
            airconditioner.ShowDialog();    
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "song" + num + ".wav";
            player.Play();
           
            songplaying = true;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {  
           player.Stop();
            songplaying = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {  if ((num > 1) && (songplaying=true) ) {
                num--;
                player.SoundLocation = "song" + num + ".wav";
                player.Play(); }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {  if ((num < 4) && (songplaying=true) ) 
            {
                num++;
                player.SoundLocation = "song" + num + ".wav";
                player.Play();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.ImageLocation != "green.jpg")
            {
                
                pictureBox7.ImageLocation = "green.jpg";
                tv.Play();
                
            }
            else
            {
                pictureBox7.ImageLocation = "blue.jpg";
                tv.Stop();  
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrivatePool privatePool = new PrivatePool();
            this.Hide();
            privatePool.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            RoomService roomService = new RoomService();
            this.Hide();
            roomService.ShowDialog();
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
            if (File.Exists("9.html"))
            {

                Process.Start("9.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
