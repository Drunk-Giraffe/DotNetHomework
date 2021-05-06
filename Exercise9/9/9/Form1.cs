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
        Crawler Crawler;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crawler = new Crawler(textBox1.Text);
            bindingSource1.DataSource = Crawler;
            Crawler.Crawl(textBox1.Text);
            bindingSource1.ResetBindings(false);
        }
    }
}
