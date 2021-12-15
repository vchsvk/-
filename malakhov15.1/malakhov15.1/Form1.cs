using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malakhov15._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (radioButton1.Checked)
                {
                    int k = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = Convert.ToString(k * 10);
                }
                if (radioButton2.Checked)
                {
                    int k = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = Convert.ToString(k * 20);
                }
                if (radioButton3.Checked)
                {
                    int k = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = Convert.ToString(k * 30);
                }
            }
        }
    }

