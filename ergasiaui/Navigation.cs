using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasiaui
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Navigation_KeyDown(object sender, KeyEventArgs e)
        {
            int xOffset = 0;
            int yOffset = 0;

            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.ImageLocation = "horseright.png";
                xOffset = 20;
            }
            else if (e.KeyCode == Keys.Left)
            {
                pictureBox1.ImageLocation = "horseleft.png";
                xOffset = -20;
            }
            else if (e.KeyCode == Keys.Up)
            {
                pictureBox1.ImageLocation = "horseup.png";
                yOffset = -20;
            }
            else if (e.KeyCode == Keys.Down)
            {
                pictureBox1.ImageLocation = "horsedown.png";
                yOffset = 20;
            }
            
            int newX = pictureBox1.Location.X + xOffset;
            int newY = pictureBox1.Location.Y + yOffset;

            Rectangle horseBounds = new Rectangle(newX, newY, pictureBox1.Width, pictureBox1.Height);
            PictureBox[] walls = { wall1, wall2, wall3, wall4, wall5, wall6, wall7, wall8, wall9, wall10, wall11, wall12 };

            bool canMove = true;
            foreach (PictureBox wall in walls)
            {
                Rectangle wallBounds = wall.Bounds;

                if (horseBounds.IntersectsWith(wallBounds))
                {
                    canMove = false;
                    break;
                }
            }

            if (canMove)
            {
                pictureBox1.Location = new Point(newX, newY);
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {   
                
           

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "horseup.png";
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 20);

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "horseright.png";
            pictureBox1.Location = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "horsedown.png";
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 20);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "horseleft.png";
            pictureBox1.Location = new Point(pictureBox1.Location.X - 20, pictureBox1.Location.Y);
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void Navigation_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void wall1_Click(object sender, EventArgs e)
        {

        }

        private void wall10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
          Horsemain horsemain = new Horsemain();
            this.Hide();
            horsemain.ShowDialog();
            this.Close();   

        }
    }
}
