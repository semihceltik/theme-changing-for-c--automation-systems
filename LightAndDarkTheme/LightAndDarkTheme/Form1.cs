using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightAndDarkTheme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false; // I closed theme panel cause i don't want to show this when program is starting.
            
            // U can use this in different forms. 
            // U can change ur background image,fonts,backcolors,events bla bla bla...
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true; 
        }

        private void darktheme_CheckedChanged(object sender, EventArgs e)
            // DARKTHEME AREA
        {
            
            lighttheme.Checked = false; // If darktheme is checked == true lighttheme.checked == false...
            this.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            darktheme.ForeColor = Color.White;
            lighttheme.ForeColor = Color.White;
        }

        private void lighttheme_CheckedChanged(object sender, EventArgs e)
        {
            // LIGHT THEME AREA
            darktheme.Checked = false;
            
            this.BackColor = Color.White;
            button1.ForeColor = Color.Black; 
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            darktheme.ForeColor = Color.Black;
            lighttheme.ForeColor = Color.Black;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
