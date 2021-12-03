using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_калькулятор_malakhov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ves = double.Parse(textBox2.Text);
            double rost = double.Parse(textBox1.Text);
            double index = ves / ((rost / 100) * (rost / 100));
            label8.Text = index.ToString("##.##");
            trackBar1.Value = Convert.ToInt32(index);
            if (index < 18.5)

                pictureBox6.Image = Image.FromFile(@"C:\Users\student\source\repos\BMI калькулятор malakhov\BMI калькулятор malakhov\images\3050344.png");
            {


                if (index < 18.5)
                {
                    pictureBox6.Image = Image.FromFile(@"C:\Users\student\source\repos\BMI калькулятор malakhov\BMI калькулятор malakhov\images\678087.png");
                }
                if (index > 18.5) 
                {
                    pictureBox6.Image = Image.FromFile(@"C:\Users\student\source\repos\BMI калькулятор malakhov\BMI калькулятор malakhov\images\678087.png");
                }
                if (index > 25) 
                {

                    pictureBox6.Image = Image.FromFile(@"C:\Users\student\source\repos\BMI калькулятор malakhov\BMI калькулятор malakhov\images\678087.png");
                }
                    if (index > 30) 
                {
                    pictureBox6.Image = Image.FromFile(@"C:\Users\student\source\repos\BMI калькулятор malakhov\BMI калькулятор malakhov\images\5859965_body_fat_health_obesity_overweight_icon.png");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = pictureBox3.Image;
        }
    }
}
