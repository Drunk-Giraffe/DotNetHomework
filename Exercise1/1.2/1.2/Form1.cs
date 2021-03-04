using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2
{
    public partial class Form1 : Form
    {
        double x=0, y=0;
        string c;
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBoxForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            x = Double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text!="")
            y = Double.Parse(textBox2.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (c[0])
            {
                case '+':
                    label4.Text = (x + y).ToString();
                    break;
                case '-':
                    label4.Text = (x - y).ToString();
                    break;
                case '*':
                    label4.Text = (x * y).ToString();
                    break;
                case '/':
                    if (y != 0)
                    label4.Text = (x / y).ToString();
                    else
                    label4.Text="除数不能为0，无法计算！";
                    break;
            }

        }

    }
}
