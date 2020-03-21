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
    public partial class cellphone : Form
    {
        public cellphone()
        {
            InitializeComponent();
        }

        // declare public class Information
        public class Information
        {
            // Declare 3 fields to hold all 3 pieces of information
            // All of the fields have get and set accessors
            public string info1 { get; set; }
            public string info2 { get; set; }
            public string info3 { get; set; }

            // Default Constructor Information()
            // This default constructor instantiates each of the 3 info fields
            public Information()
            {
                // Instantiate each of the 3 fields to ""
                info1 = "";
                info2 = "";
                info3 = "";
            }

            // Parameterized Constructor Information()
            // This paramterized constructor has 3 arguments passed into it from the object declaration
            public Information(string Info1, string Info2, string Info3)
            {
                // set the fields to the input from the object declaration
                info1 = Info1;
                info2 = Info2;
                info3 = Info3;
            }
        }

        // button1 Click Event
        // This event happens as soon as the 'EXIT' button is pressed
        private void button1_Click(object sender, EventArgs e)
        {
            // Hide this form
            this.Hide();
        }

        // cellphoneLoad Event
        // This event hapepns as soon as the form is loaded up
        private void cellphone_Load(object sender, EventArgs e)
        {
            // Sets the size to height of 600 and width of 480
            this.Size = new Size(600, 480);

            // Create cellphone object instantiated from the Information class. 
            // Sends over 3 strings into the paramterized constructor in the Information class.
            Information cellphone = new Information("20% of mobile phones are sent for end-of-life management after two years. 90% of mobile devices are sent for end-of-life management after five years. (source: EPA) \n \nOf the mobile phones collected for recycling in 2009, 38% were refurbished or reused and the remaining 62% were recycled. (source: EPA)"
                                                  , "**Make sure to pause the video before exiting.**", "CELLPHONE");

            // adds the information from the class into the labels
            label5.Text = cellphone.info2;
            label2.Text = cellphone.info3;
            label3.Text = cellphone.info1;
        }

        // OnLoad method that embeds the youtube video into webBrowser1
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"300\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = "https://www.youtube.com/embed/RDM7SDqBl94";
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }
    }
}
