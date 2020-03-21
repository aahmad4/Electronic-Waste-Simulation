using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sim
{
    public partial class Form2 : Form
    {
        // The constructor below passes the ID variable from form1 into form2.
        public Form2(int ID)
        {
            InitializeComponent();

            // Sets the ID variable from form1 into a public variable for form2 to be used everywhere
            id = ID;
        }

        // Declares public integer variable to hold the ID value sent from Form1
        int id = 0;

        // Form2 Load event
        // This event occurs as soon as Form2 loads up.
        private void Form2_Load(object sender, EventArgs e)
        {
            // Sets the form size to height of 940 and width of 670.
            this.Size = new Size(940, 670);

            // If the ID from form1 equals 1, it will display the cellphone to be dragged
            if (id == 1)
            {
                // Set pictureBox1 image to cellphone in the resources.
                pictureBox1.Image = Properties.Resources.cellphone;
            }
            // If the ID from form1 equals 2, it will display the computer to be dragged
            else if (id == 2)
            {
                // Set pictureBox1 image to computer in the resources.
                pictureBox1.Image = Properties.Resources.computer;
            }
            // If the ID from form1 equals 3, it will display the television to be dragged
            else if (id == 3)
            {   
                // Set pictureBox1 image to television in the resources.
                pictureBox1.Image = Properties.Resources.tv;
            }
            // If the ID from form1 equals 4, it will display the appliance to be dragged
            else if (id == 4)
            {
                // Set pictureBox1 image to appliance in the resources.
                pictureBox1.Image = Properties.Resources.appliance;
            }

            // Allow pictureBox2 to be able to be dropped into.
            pictureBox2.AllowDrop = true;

        }

        // pictureBox1 MouseDown event
        // This event occurs when the user holds down the mouse click on the picturebox
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // allows pictureBox1 to be dragged
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
        }

        // pictureBox2 DragEnter event
        // This event occurs when the user's cursor moves over pictureBox2
        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            // Give mouse effect that it is allowed to drop in the pictureBox5
            e.Effect = e.AllowedEffect;
        }

        // pictureBox2 DragDrop event
        // This event occurs when the user drag/drops a picutrebox into pictureBox2
        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            // Change pictureBox2 image to the image of the picturebox that was dropped into it
            pictureBox2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

            // Hide pictureBox1 to have effect of moving the object
            pictureBox1.Visible = false;
        }

        // buton1 Click event
        // This event occurs when the user presses button1, or 'Start Scan'
        private void button1_Click(object sender, EventArgs e)
        {
            // If the ID variable sent from form1 is equal to 1, or they dragged a cellphone
            if (id == 1)
            {
                // Display messagebox showing "Processing...."
                MessageBox.Show("PROCESSING.....");

                // Display messagebox showing that the e-waste item was scanned as a cellphone
                MessageBox.Show("E-Waste Item scanned as 'CELLPHONE'.");

                // Declare the cellphone form
                cellphone cellphone = new cellphone();

                // Show the cellphone form including information about cellphone recycling
                cellphone.Show();

                // Display the pictureBox showing the next button
                pictureBox6.Show();
            }
            // If the ID variable sent from form1 is equal to 2, or they dragged a computer
            else if (id == 2)
            {
                // Display messagebox showing "Processing..."
                MessageBox.Show("PROCESSING.....");

                // Display messagebox showing that the e-waste item was scanned as a computer
                MessageBox.Show("E-Waste Item scanned as 'COMPUTER'.");

                // Declare the computer form
                computer computer = new computer();

                // Show the computer form
                computer.Show();

                // Display the picturebox showing the next button
                pictureBox6.Show();
            }
            // If the ID variable sent from form1 is equal to 3, or they dragged a television
            else if (id == 3)
            {
                // Display messagebox showing "Processing..."
                MessageBox.Show("PROCESSING.....");

                // Display messagebox showing that the e-waste item was scanned as a television
                MessageBox.Show("E-Waste Item scanned as 'TELEVISION'.");

                // Declare the television form
                television television = new television();

                // Show the television form
                television.Show();

                // Display the picturebox showing the next button
                pictureBox6.Show();
            }
            // If the ID variable sent from form1 is equal to 4, or they dragged an appliance
            else if (id == 4)
            {
                // Display messagebox showing "Processing..."
                MessageBox.Show("PROCESSING.....");

                // Display messagebox showing that the e-waste item was scanned as an appliance
                MessageBox.Show("E-Waste Item scanned as 'APPLIANCE'.");

                // Declare the appliance form
                appliance appliance = new appliance();

                // Show the appliance form
                appliance.Show();

                // Display the picturebox showing the next button
                pictureBox6.Show();
            }

        }

        // pictureBox6 Click Event
        // This event happens when the next button is clicked
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Declare Form3, sending the id variable over to its constructor
            Form3 form3 = new Form3(id);

            // Show Form3
            form3.Show();

            // Hide this form
            this.Hide();
        }
    }
}
