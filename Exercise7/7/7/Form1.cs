using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pen = new Pen(Color.Blue);
        int n = 10;
        int leng = 100;
        public Form1()
        {
            InitializeComponent();
            ComboBoxForm_Load();
            trackBar1_Load();
            trackBar2_Load();
            trackBar3_Load();
            trackBar4_Load();
            trackBar5_Load();
            trackBar6_Load();
            label1_Load();
            label2_Load();
            label3_Load();
            label4_Load();
            label5_Load();
            label6_Load();
            label7_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = CreateGraphics();
            else
                graphics.Clear(BackColor);
            drawCayleyTree(n, 200, 400, leng, -Math.PI / 2);
        }
        
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1,pen);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0,double y0,double x1,double y1,Pen pen)
        {
            graphics.DrawLine(pen ,(int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen = new Pen((Color)comboBox1.SelectedItem);
        }
        public void ComboBoxForm_Load()
        {
            comboBox1.Items.Add(Color.Black);
            comboBox1.Items.Add(Color.Blue);
            comboBox1.Items.Add(Color.Gray);
            comboBox1.Items.Add(Color.Red);
            comboBox1.Items.Add(Color.Silver);
            comboBox1.Items.Add(Color.White);
        }
        
        public void trackBar1_Load()
        {
            trackBar1.Maximum = 20;
            trackBar1.Minimum = 1;
            trackBar1.SmallChange = 1;
            trackBar1.TickFrequency = 1;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            n = trackBar1.Value;
            label2.Text=label2.Text.Replace(label2.Text, "递归深度："+trackBar1.Value.ToString());
        }
        public void trackBar2_Load()
        {
            trackBar2.Maximum = 200;
            trackBar2.Minimum = 10;
            trackBar2.SmallChange = 10;
            trackBar2.TickFrequency = 10;
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            leng = trackBar2.Value;
            label3.Text=label3.Text.Replace(label3.Text, "主干长度："+trackBar2.Value.ToString());
        }
        public void trackBar3_Load()
        {
            trackBar3.Maximum = 10;
            trackBar3.Minimum = 1;
            trackBar3.SmallChange = 1;
            trackBar3.TickFrequency = 1;
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            per1 = (double)(trackBar3.Value) / 10;
            label4.Text=label4.Text.Replace(label4.Text, "右分支长度比：" + ((double)(trackBar3.Value)/10).ToString());
        }

        public void trackBar4_Load()
        {
            trackBar4.Maximum = 10;
            trackBar4.Minimum = 1;
            trackBar4.SmallChange = 1;
            trackBar4.TickFrequency = 1;
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            per2 = (double)(trackBar4.Value) / 10;
            label5.Text=label5.Text.Replace(label5.Text, "左分支长度比：" + ((double)(trackBar4.Value) / 10).ToString());
        }
        public void trackBar5_Load()
        {
            trackBar5.Maximum = 180;
            trackBar5.Minimum = 0;
            trackBar5.SmallChange = 1;
            trackBar5.TickFrequency = 1;
        }
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            th1 = trackBar5.Value * Math.PI / 180;
            label6.Text=label6.Text.Replace(label6.Text, "右分支角度：" + trackBar5.Value.ToString()+"度");
        }
        public void trackBar6_Load()
        {
            trackBar6.Maximum = 180;
            trackBar6.Minimum = 0;
            trackBar6.SmallChange = 1;
            trackBar6.TickFrequency = 1;
        }
        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            th2 = trackBar6.Value * Math.PI / 180;
            label7.Text=label7.Text.Replace(label7.Text, "左分支角度：" + trackBar6.Value.ToString() + "度");
        }

        public void label1_Load()
        {
            label1.Text = "选择笔触颜色";
        }
        public void label2_Load()
        {
            label2.Text = "递归深度：" + n.ToString();
        }
        public void label3_Load()
        {
            label3.Text = "主干长度：" + leng.ToString();
        }
        public void label4_Load()
        {
            label4.Text = "右分支长度比：" + per1.ToString();
        }
        public void label5_Load()
        {
            label5.Text = "左分支长度比：" + per2.ToString();
        }
        public void label6_Load()
        {
            label6.Text = "右分支角度：" + th1.ToString();
        }
        public void label7_Load()
        {
            label7.Text = "左分支角度：" + th2.ToString();
        }
    }
}
