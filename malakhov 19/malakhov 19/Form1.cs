using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malakhov_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vys = textBox1.Text;
            string shir = textBox2.Text;

            int s = Convert.ToInt32(vys) * Convert.ToInt32(shir);
            int ess = 0;

            if (comboBox1.SelectedIndex == 0)
            { ess = 3500; }
            if (comboBox1.SelectedIndex == 1)
            { ess = 2500; }
            if (checkBox1.Checked == true)
            { ess = ess + 100; }
            if (checkBox2.Checked == true)
            { ess = ess + 200; }
            if (checkBox3.Checked == true)
            { ess = ess + 300; }

            int itog = s * 7 + ess;
            label4.Text = Convert.ToString(itog);
        }
    }
}
