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


        }
    }
}
