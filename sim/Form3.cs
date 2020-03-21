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
    public partial class Form3 : Form
    {
        // Form3 constructor that has ID variable passed into it
        public Form3(int ID)
        {
            InitializeComponent();

            //assign the public id variable to the private ID variable sent from the object declaration in Form2
            id = ID;
        }
        // declare public id integer variable to hold the private variable from Form2
        int id;

        // Form3 Load Event
        // This event happens as soon as the form is loaded up
        private void Form3_Load(object sender, EventArgs e)
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

            // Allow pictureBox2 to have pictures dropped into it.
            pictureBox2.AllowDrop = true;
        }

        // pictureBox1 MouseDown Event
        // This event happens when the user holds down mouse click on pictureBox1
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // allows pictureBox1 to be dragged
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
        }

        // pictureBox2 DragDrop Event
        // This event happens when the user drops the image into this pictureBox
        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            // Change pictureBox2 image to the image of the picturebox that was dropped into it
            pictureBox2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

            // Hide the intial image, to make effect of it moving
            pictureBox1.Visible = false;
        }

        // pictureBox2 DragEnter Event
        // This event happens when the user's mouse enters the vicinity of pictureBox2
        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            // Give mouse effect that it is allowed to drop in the pictureBox5
            e.Effect = e.AllowedEffect;
        }

        // button1 Click Event
        // This event happens when the user presses the 'Shred' button
        private void button1_Click(object sender, EventArgs e)
        {
            // Display in messagebox 'Shredding....'
            MessageBox.Show("Shredding....");

            // Hide the picture of the item before shredding
            pictureBox2.Visible = false;

            // Show the picture of the item after shredding
            pictureBox3.Visible = true;

            // Show label labeling it as a Product
            label2.Visible = true;

            // Show the 'Next' Button
            pictureBox6.Visible = true;

        }

        // pictureBox6 Click Event
        // This event happens when the user clicks the 'Next' button
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Declare Form4 with id variable passed into it.
            Form4 Form4 = new Form4(id);

            // Show Form4
            Form4.Show();

            // Hide this form
            this.Hide();
        }
    }
}
