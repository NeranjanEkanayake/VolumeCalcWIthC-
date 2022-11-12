using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sphere");
            comboBox1.Items.Add("Cube");
            comboBox1.Items.Add("Cuboid");
            comboBox1.Items.Add("Cone");
            comboBox1.Items.Add("Cylinder");

            value1.Hide();
            value2.Hide();
            value3.Hide();

            value1Lbl.Hide();
            value2Lbl.Hide();
            value3Lbl.Hide();

            button1.Hide();
            volume.Hide();
            result.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            value1.Visible= false;
            value2.Visible= false;
            value3.Visible= false;
            value1Lbl.Visible= false;
            value2Lbl.Visible= false;
            value3Lbl.Visible= false;
            button1.Visible= false;
            volume.Visible= false;
            result.Visible= false;

            switch(this.comboBox1.Text)
            {
                case "Sphere":
                    value1.Visible= true;
                    value1Lbl.Visible= true;
                    value1Lbl.Text= "Radius:";
                    button1.Visible = true;
                    volume.Visible= true;
                    result.Visible= true;
                    break;

                case "Cube":
                    value1.Visible= true;
                    value1Lbl.Visible= true;
                    value1Lbl.Text = "Side:";
                    button1.Visible= true;
                    volume.Visible= true;
                    result.Visible = true;
                    break;

                case "Cuboid":
                    value1.Visible= true;
                    value1Lbl.Visible= true;
                    value2.Visible = true;
                    value2Lbl.Visible= true;
                    value3.Visible= true;
                    value3Lbl.Visible = true;
                    value1Lbl.Text = "Width:";
                    value2Lbl.Text = "Length:";
                    value3Lbl.Text = "Height:";
                    button1.Visible= true;
                    volume.Visible= true; 
                    result.Visible= true; 
                    break;

                case "Cone":
                    value1.Visible= true;
                    value2.Visible= true;
                    
                    value1Lbl.Visible= true;
                    value2Lbl.Visible= true;
                    
                    value1Lbl.Text ="Radius:";
                    value2Lbl.Text = "Height:";

                    button1.Visible=true;
                    volume.Visible= true;
                    result.Visible= true; 
                    break;

                case "Cylinder":
                    value1.Visible= true;
                    value2.Visible= true;

                    value1Lbl.Visible= true;
                    value2Lbl.Visible= true;

                    value1Lbl.Text = "Radius:";
                    value2Lbl.Text = "Height:";

                    volume.Visible = true;
                    button1.Visible = true;
                    result.Visible= true; 
                    break;

                default: break;
            }
        }
    }
}
