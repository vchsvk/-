using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malakhov26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, to;

            from = listBox1.SelectedItem.ToString();
            to = listBox2.SelectedItem.ToString();

            if (from == to)
            {
                MessageBox.Show("Это одна и та же валюта!");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Введите количество валюты!");
            }
            else
            {
                webBrowser1.Navigate("https://www.google.ru/search?q=" + textBox1.Text + "" + from + " %D0%B2 " + to);
            }
        }
    }
}
