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
    public partial class Form4 : Form
    {
        // Form4 constructor that has ID variable passed into it from Form3
        public Form4(int ID)
        {
            InitializeComponent();

            // set the public id variable to the private ID variable sent from Form3
            id = ID;
        }
        // declare the public id variable
        public int id;

        // declare a counter for the timer to determine which and how the pictureboxes will move
        static int counter = 0;

        // declare array named info holding all of the string text that needs to be implemented into the labels
        string[] info = new string[] { "Batteries", "Metals", "Circuits", "After shredding, magnets sort the shredded material. Press the button to begin the extraction process." };
      
        // Form4 Load Event
        // This event happens when the user loads up Form4
        private void Form4_Load(object sender, EventArgs e)
        {
            // Change the form size on load to height 940 and width 670
            this.Size = new Size(940, 670);

            // Add all of the info from the arrays into the labels
            label1.Text = info[3];
            label2.Text = info[0];
            label3.Text = info[1];
            label4.Text = info[2];

        }

        // Timer1 Tick event
        // Happens every time the timer ticks at interval of 5
        private void timer1_Tick(object sender, EventArgs e)
        {
            // increment the counter
            counter++;

            // The following if and elseif statements dictate which and how the pictureboxes move
            if (counter <= 80)
            {
                // all move to the right
                pictureBox1.Location = new Point(pictureBox1.Location.X + 2, pictureBox1.Location.Y);
                pictureBox2.Location = new Point(pictureBox2.Location.X + 2, pictureBox2.Location.Y);
                pictureBox3.Location = new Point(pictureBox3.Location.X + 2, pictureBox3.Location.Y);
                pictureBox4.Location = new Point(pictureBox4.Location.X + 2, pictureBox4.Location.Y);
                pictureBox5.Location = new Point(pictureBox5.Location.X + 2, pictureBox5.Location.Y);
            }
            else if (counter > 80 & counter <= 180)
            {
                // pictureBox4 or battery moves up. Change the mixed image
                pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - 2);
                pictureBox5.Image = Properties.Resources.mixed21;          
                
                // show skip button
                pictureBox6.Show();
            }
            else if (counter > 180 & counter <= 290)
            {
                // all but pb4 move right
                pictureBox1.Location = new Point(pictureBox1.Location.X + 2, pictureBox1.Location.Y);
                pictureBox2.Location = new Point(pictureBox2.Location.X + 2, pictureBox2.Location.Y);
                pictureBox3.Location = new Point(pictureBox3.Location.X + 2, pictureBox3.Location.Y);
                pictureBox5.Location = new Point(pictureBox5.Location.X + 2, pictureBox5.Location.Y);
            }
            else if (counter > 290 & counter <= 400)
            {
                // pictureBox3 or metal moves up. Change the mixed image
                pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 2);
                pictureBox5.Image = Properties.Resources.mixed3;

            }
            else if (counter > 400 & counter <= 510)
            {
                // all but pb4 and pb3 move right
                pictureBox1.Location = new Point(pictureBox1.Location.X + 2, pictureBox1.Location.Y);
                pictureBox2.Location = new Point(pictureBox2.Location.X + 2, pictureBox2.Location.Y);
                pictureBox5.Location = new Point(pictureBox5.Location.X + 2, pictureBox5.Location.Y);
            }
            else if (counter > 510 & counter <= 620)
            {
                // pictureBox2 or circuit moves up. Hide the mixed image
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 2);
                pictureBox5.Visible = false;
            }
            else if (counter > 620 & counter <= 700)
            { 
                // move the plastic to the right
                pictureBox1.Location = new Point(pictureBox1.Location.X + 2, pictureBox1.Location.Y);
            }
            else if (counter == 701)
            {
                // display that the extraction finished
                MessageBox.Show("Extraction Completed.");

                // show the 'next' button
                pictureBox6.Show();
            }
        }

        // button1 Click Event
        // This event happens when the user presses the 'start extraction' button
        private void button1_Click(object sender, EventArgs e)
        {
            // enable the timer to begin moving the pictures to represent the extraction
            timer1.Enabled = true;
        }

        // pictureBox6 Click Event
        // This event happens when the user presses the 'next' button
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // declare Form5 with nothing passed into it
            Form5 Form5 = new Form5();

            // show Form5
            Form5.Show();

            // hide this form
            this.Hide();
        }
    }
}
