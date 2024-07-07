using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;


namespace ergasiaui
{
    public partial class Service : Form
    {

        String connectionString = "Data Source = roomservice.db;Version=3";
        SQLiteConnection connection;

        decimal frappeprice = 3.00m;
        decimal greekcoffeeprice = 2.50m;
        decimal freddoprice = 3.50m;
        decimal iceteaprice = 2.50m;
        decimal cocktailprice = 10.00m;
        decimal beerprice = 5.00m;
        decimal wineprice = 5.00m;
        decimal ginwhiskeyprice = 8.00m;
        decimal greeksaladprice = 8.00m;
        decimal tzatzikiprice = 5.00m;
        decimal souvlakiprice = 4.00m;
        decimal fasoladaprice = 8.00m;
        decimal moussakaprice = 11.00m;
        decimal galaktompourekoprice = 6.00m;
        decimal yogurtprice = 4.00m;




        public Service()
        {
            InitializeComponent();
        }

        private void RoomService_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void updatetotal()
        {
            decimal total = 0.0m;
            if (Frappe.Checked)
            {
                if (int.TryParse(frappeq.Text, out int quantity))
                {
                    total += frappeprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(Frappe.Text, out int quantity))
                {
                    total -= frappeprice * quantity;
                }
            }


            if (Greekcoffee.Checked)
            {
                if (int.TryParse(greekcoffeeq.Text, out int quantity))
                {
                    total += greekcoffeeprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(greekcoffeeq.Text, out int quantity))
                {
                    total -= greekcoffeeprice * quantity;
                }
            }

            if (Freddo.Checked)
            {
                if (int.TryParse(freddoq.Text, out int quantity))
                {
                    total += freddoprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(freddoq.Text, out int quantity))
                {
                    total -= freddoprice * quantity;
                }
            }


            if (Icetea.Checked)
            {
                if (int.TryParse(iceteaq.Text, out int quantity))
                {
                    total += iceteaprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(iceteaq.Text, out int quantity))
                {
                    total -= iceteaprice * quantity;
                }
            }


            if (Cocktail.Checked)
            {
                if (int.TryParse(coktailq.Text, out int quantity))
                {
                    total += cocktailprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(coktailq.Text, out int quantity))
                {
                    total -= cocktailprice * quantity;
                }
            }

            if (Wine.Checked)
            {
                if (int.TryParse(wineq.Text, out int quantity))
                {
                    total += wineprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(wineq.Text, out int quantity))
                {
                    total -= wineprice * quantity;
                }
            }

            if (Beer.Checked)
            {
                if (int.TryParse(beerq.Text, out int quantity))
                {
                    total += beerprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(beerq.Text, out int quantity))
                {
                    total -= beerprice * quantity;
                }
            }


            if (Greeksalad.Checked)
            {
                if (int.TryParse(greeksalq.Text, out int quantity))
                {
                    total += greeksaladprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(greeksalq.Text, out int quantity))
                {
                    total -= greeksaladprice * quantity;
                }
            }

            if (Tzatziki.Checked)
            {
                if (int.TryParse(tzatzikiq.Text, out int quantity))
                {
                    total += tzatzikiprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(tzatzikiq.Text, out int quantity))
                {
                    total -= tzatzikiprice * quantity;
                }
            }

            if (Souvlaki.Checked)
            {
                if (int.TryParse(souvlakiq.Text, out int quantity))
                {
                    total += souvlakiprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(souvlakiq.Text, out int quantity))
                {
                    total -= souvlakiprice * quantity;
                }
            }

            if (Fasolada.Checked)
            {
                if (int.TryParse(fasoladaq.Text, out int quantity))
                {
                    total += fasoladaprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(fasoladaq.Text, out int quantity))
                {
                    total -= fasoladaprice * quantity;
                }
            }

            if (Moussaka.Checked)
            {
                if (int.TryParse(moussakaq.Text, out int quantity))
                {
                    total += moussakaprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(moussakaq.Text, out int quantity))
                {
                    total -= moussakaprice * quantity;
                }
            }

            if (Galaktompoureko.Checked)
            {
                if (int.TryParse(galaktq.Text, out int quantity))
                {
                    total += galaktompourekoprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(galaktq.Text, out int quantity))
                {
                    total -= galaktompourekoprice * quantity;
                }
            }

            if (Yoghurt.Checked)
            {
                if (int.TryParse(yogurtq.Text, out int quantity))
                {
                    total += yogurtprice * quantity;
                }
            }
            else
            {
                if (int.TryParse(yogurtq.Text, out int quantity))
                {
                    total -= yogurtprice * quantity;
                }
            }


            TotalTextBox.Text = total.ToString("C");

        }

        private void Frappe_CheckedChanged(object sender, EventArgs e)
        {
            if ((Frappe.Checked) && (frappeq.Text == ""))
            {
               
                    frappeq.Text = "1";
                
            }
            

            updatetotal();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Greekcoffee_CheckedChanged(object sender, EventArgs e)
        {
            if ((Greekcoffee.Checked) && (greekcoffeeq.Text == ""))
            {
                greekcoffeeq.Text = "1";
            }

            updatetotal();
        }

        private void Freddo_CheckedChanged(object sender, EventArgs e)
        {
            if ((Freddo.Checked) && (freddoq.Text == ""))
            {
                freddoq.Text = "1";
            }

            updatetotal();
        }

        private void Icetea_CheckedChanged(object sender, EventArgs e)
        {
            if ((Icetea.Checked) && (iceteaq.Text == ""))
            {
                iceteaq.Text = "1";
            }

            updatetotal();
        }

        private void Cocktail_CheckedChanged(object sender, EventArgs e)
        {
            if ((Cocktail.Checked) && (coktailq.Text == ""))
            {
                coktailq.Text = "1";
            }

            updatetotal();
        }

        private void Beer_CheckedChanged(object sender, EventArgs e)
        {
            if ((Beer.Checked) && (beerq.Text == ""))
            {
                beerq.Text = "1";
            }

            updatetotal();
        }

        private void Wine_CheckedChanged(object sender, EventArgs e)
        {
            if ((Wine.Checked) && (wineq.Text == ""))
            {
                wineq.Text = "1";
            }

            updatetotal();
        }

        private void GinWhiskey_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void Greeksalad_CheckedChanged(object sender, EventArgs e)
        {
            if ((Greeksalad.Checked) && (greeksalq.Text == ""))
            {
                greeksalq.Text = "1";
            }

            updatetotal();
        }

        private void Tzatziki_CheckedChanged(object sender, EventArgs e)
        {
            if ((Tzatziki.Checked) && (tzatzikiq.Text == ""))
            {
                tzatzikiq.Text = "1";
            }

            updatetotal();
        }

        private void Souvlaki_CheckedChanged(object sender, EventArgs e)
        {
            if ((Souvlaki.Checked) && (souvlakiq.Text == ""))
            {
                souvlakiq.Text = "1";
            }

            updatetotal();
        }

        private void Fasolada_CheckedChanged(object sender, EventArgs e)
        {
            if ((Fasolada.Checked) && (fasoladaq.Text == ""))
            {
                fasoladaq.Text = "1";
            }

            updatetotal();
        }

        private void Moussaka_CheckedChanged(object sender, EventArgs e)
        {
            if ((Moussaka.Checked) && (moussakaq.Text == ""))
            {
                moussakaq.Text = "1";
            }

            updatetotal();
        }

        private void Galaktompoureko_CheckedChanged(object sender, EventArgs e)
        {
            if ((Galaktompoureko.Checked) && (galaktq.Text == ""))
            {
                galaktq.Text = "1";
            }

            updatetotal();
        }

        private void Yoghurt_CheckedChanged(object sender, EventArgs e)
        {
            if ((Yoghurt.Checked) && (yogurtq.Text == ""))
            {
                yogurtq.Text = "1";
            }

            updatetotal();
        }

        private void TotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void greekcoffeeq_TextChanged(object sender, EventArgs e)
        {

        }

        private void galaktq_TextChanged(object sender, EventArgs e)
        {

        }

        private void frappeq_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            // Uncheck all the menu item checkboxes
            Frappe.Checked = false;
            Greekcoffee.Checked = false;
            Freddo.Checked = false;
            Icetea.Checked = false;
            Cocktail.Checked = false;
            Beer.Checked = false;
            Wine.Checked = false;
            Greeksalad.Checked = false;
            Tzatziki.Checked = false;
            Souvlaki.Checked = false;
            Fasolada.Checked = false;
            Moussaka.Checked = false;
            Galaktompoureko.Checked = false;
            Yoghurt.Checked = false;

            updatetotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roomNumber = textBox16.Text.Trim();


            if (string.IsNullOrWhiteSpace(roomNumber))
            {
                MessageBox.Show("Please enter your table's number.");
                return;
            }

            int roomNumberInt;
            if (!int.TryParse(roomNumber, out roomNumberInt) ||
                !(roomNumberInt >= 1 && roomNumberInt <= 17) )
            {
                MessageBox.Show("Please enter a valid table number between 1-17");
                return;
            }
            
            






            connection.Open();

            
            string orderDescription = "";

            
            if (Frappe.Checked)
            {
                string quantitytext = frappeq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Frappe (Quantity: {quantity}), ";
                }
            }

            if (Greekcoffee.Checked)
            {
                string quantitytext = greekcoffeeq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Greek Coffee (Quantity: {quantity}), ";
                }
            }

            if (Freddo.Checked)
            {
                string quantitytext = freddoq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Freddo (Quantity: {quantity}), ";
                }
            }

            if (Icetea.Checked)
            {
                string quantitytext = iceteaq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Ice Tea (Quantity: {quantity}), ";
                };
            }

            if (Cocktail.Checked) {

                string quantitytext = coktailq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Cocktail (Quantity: {quantity}), ";
                }
            }

            if (Wine.Checked)
            {
                string quantitytext = wineq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Wine (Quantity: {quantity}), ";
                }
            }

            if (Beer.Checked)
            {
                string quantitytext = beerq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Beer (Quantity: {quantity}), ";
                }
            }

            if (Greeksalad.Checked)
            {
                string quantitytext = greeksalq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Greek salad (Quantity: {quantity}), ";
                }
            }

            if (Tzatziki.Checked)
            {
                string quantitytext = tzatzikiq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Tzatziki (Quantity: {quantity}), ";
                }
            }

            if (Souvlaki.Checked)
            {
                string quantitytext = souvlakiq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Souvlaki (Quantity: {quantity}), ";
                }
            }

            if (Fasolada.Checked)
            {
                string quantitytext = fasoladaq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Fasolada (Quantity: {quantity}), ";
                }
            }
            
            if (Moussaka.Checked)
            {
                string quantitytext = moussakaq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Moussaka (Quantity: {quantity}), ";
                }
            }

            if (Galaktompoureko.Checked)
            {
                string quantitytext = galaktq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Galaktompoureko (Quantity: {quantity}), ";
                }
            }

            if (Yoghurt.Checked)
            {
                string quantitytext = yogurtq.Text.Trim();
                if (!string.IsNullOrWhiteSpace(quantitytext) && int.TryParse(quantitytext, out int quantity) && quantity > 0)
                {
                    orderDescription += $"Yogurt (Quantity: {quantity}), ";
                }
            }

            string insertSQL = "INSERT INTO Orders (Room_number, Order_description) VALUES (@roomno, @order)";
            using (SQLiteCommand command = new SQLiteCommand(insertSQL, connection))
            {
                command.Parameters.AddWithValue("@roomno", roomNumber);
                command.Parameters.AddWithValue("@order",orderDescription);
                command.ExecuteNonQuery();
            }
            
            connection.Close();

            pay nfc = new pay(this);
            this.Hide();
            nfc.ShowDialog();
            this.Close();



        }
        private void textBox16_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant();
            this.Hide();
            restaurant.ShowDialog();    
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("4.html"))
            {

                Process.Start("4.html");
            }
            else
            {
                MessageBox.Show("Το HTML αρχείο δεν υπάρχει στον φάκελο bin.");
            }
        }
    }
}
    
    
