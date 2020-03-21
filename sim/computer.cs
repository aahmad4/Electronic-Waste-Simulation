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
    public partial class computer : Form
    {
        public computer()
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
        // This event happens when the user clicks the 'EXIT' button
        private void button1_Click(object sender, EventArgs e)
        {
            // Hide this form
            this.Hide();
        }

        // computerLoad Event
        // This event happens as soon as the user loads up the form
        private void computer_Load(object sender, EventArgs e)
        {
            // Set the form size to a height of 600 and a width of 480
            this.Size = new Size(600, 480);

            // Create computer object instantiated from the Information class. 
            // Sends over 3 strings into the paramterized constructor in the Information class.
            Information computer = new Information("Computers (including laptops) represented 26% of the e-waste recycling stream in 2009. (source: EPA) \n \nAmericans bought 68.7 million computers in 2011. (source: Electronics Takeback Coalition)",
                                                   "**Make sure to pause the video before exiting.**", "COMPUTER");

            // Adds the information from the class into the labels
            label5.Text = computer.info2;
            label2.Text = computer.info3;
            label3.Text = computer.info1;
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
            var url = "https://www.youtube.com/embed/EHWFPEWoHJY";
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }
    }
}
