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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // declare an array named info to hold all of the strings that will be implemented into the labels
        string[] info = new string[] {"After the shredding, sorting and separation stages have been executed, the separated materials are prepared for sale as usable raw materials for the production of new electronics or other products.",
                                       "Would you like to restart the program?"};
        
        // Form5 Load Event
        // This event happens as soon as the form loads up
        private void Form5_Load(object sender, EventArgs e)
        {
            // add the info from the arrays into the two labels
            label1.Text = info[0];
            label2.Text = info[1];

            // Sets the form size to height of 940 and width of 670.
            this.Size = new Size(940, 670);
        }

        // button2 Click Event
        // This event happens when the user presses the 'Exit' button
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // button1 Click Event
        // This event happens when the user presses the 'Restart' button
        private void button1_Click(object sender, EventArgs e)
        {
            // Restart this program
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
