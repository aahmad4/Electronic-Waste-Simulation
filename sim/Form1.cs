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
    /* Ali Ahmad, Mustafa Al-Khawaja, Aidan Camilleri, Robert English, Deenah Hamdan
     * 11/18/18
     * Period 2 (GLP)
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declares an integer variable named 'id' to hold which type of e-waste the user selects.
        int id;

        // Form1 Load event
        // This event happens as soon as the form loads up.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Sets the form size to height:940 and width:670
            this.Size = new Size(940, 670);

            //Allows pictureBox5 to have a picture from the other 4 pictureboxes to be dropped into it.
            pictureBox5.AllowDrop = true;

        }

        // pictureBox1 MouseDown event
        // This event happens when the user holds mouse click on pictureBox1
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Allows pictureBox1 to be able to drag/drop.
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);

            // Sets ID variable to 1, to identify that the cellphone was chosen.
            id = 1;

            // Shows the 'next' button to proceed
            pictureBox6.Show();
        }

        // pictureBox2 MouseDown event
        // This event happens when the user holds mouse click on pictureBox1
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            // Allows pictureBox2 to be able to drag/drop.
            pictureBox2.DoDragDrop(pictureBox2.Image, DragDropEffects.Copy);

            // Sets ID variable to 2, to identify that the computer was chosen.
            id = 2;

            // Shows the 'next' button to proceed
            pictureBox6.Show();
        }

        // pictureBox3 MouseDown event
        // This event happens when the user holds mouse click on pictureBox3
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            // Allows pictureBox3 to be able to drag/drop.
            pictureBox3.DoDragDrop(pictureBox3.Image, DragDropEffects.Copy);

            // Sets ID variable to 3, to identify that the television was chosen.
            id = 3;

            // Shows the 'next' button to proceed.
            pictureBox6.Show();
        }

        // pictureBox4 MouseDown event
        // This event happens when the user holds mouse click on pictureBox4
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            // Allows pictureBox4 to able to drag/drop.
            pictureBox4.DoDragDrop(pictureBox4.Image, DragDropEffects.Copy);

            // Sets ID variable to 4, to identify that the appliance was chosen
            id = 4;
            pictureBox6.Show();
        }

        // pictureBox5 DragDrop event
        // This event happens when the user dragdrops pictureBox1,2,3,4 into pictureBox5
        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            // Sets the image for pictureBox5 to the image of whatever pictureBox was dropped into it
            pictureBox5.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        // pictureBox5 DragEnter event
        // This event happens when the user's mouse enters the range of pictureBox5 while holding down mouse click
        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {
            // Give mouse effect that it is allowed to drop in the pictureBox5
            e.Effect = e.AllowedEffect;
        }

        // pictureBox6 MouseClick event
        // This event happens when the user clicks on pictureBox6
        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            // Declares new form and sends ID variable to the constructor in Form2.
            Form2 Form2 = new Form2(id);

            // Shows Form2
            Form2.Show();

            // Hides Form2
            this.Hide();
        }
    }
}
