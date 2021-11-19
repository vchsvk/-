using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malakhov24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\student\Desktop\skoda-fabia-foto.jpeg");
                label3.Text = ("230000");
            }
            if (checkBox2.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\student\Desktop\skoda-fabia-4dv-sedan-2000.jpg");
                label3.Text = ("350000");
            }

                if (checkBox3.Checked)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\student\Desktop\gg.jpg");
                    label3.Text = ("550000");


                }
            }
        }
    }
