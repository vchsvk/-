using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox2.Clear();
            label9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = double.Parse(textBox1.Text);
            double v = double.Parse(textBox2.Text);
            double l = double.Parse(textBox3.Text);
            double bmr = 0;

            if (radioButton1.Checked)
            {
                bmr = 66 + (13.7 * v) + (5 * r) + (6.8 * l);
            }

            if (radioButton2.Checked)
            {

                bmr = 665 + (9.6 * v) + (1.8 * r) + (4.7 * l);
            }

            label9.Text = bmr.ToString();

        }

    
        }
    }

