using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        SimpleCrawler SimpleCrawler;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleCrawler = new SimpleCrawler(textBox1.Text);
            bindingSource1.DataSource = SimpleCrawler;
            SimpleCrawler.Crawl();
            bindingSource1.ResetBindings(false);
        }
    }
}
