using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace _8
{
    public partial class Form1 : Form
    {
        OrderService OrderService = new OrderService();
        List<OrderDetails> list = new List<OrderDetails>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString()) {
                case ("订单编号"):
                    bindingSource1.DataSource=OrderService.QueryOrder(1, textBox1.Text);
                    break;
                case ("商品名称"):
                    bindingSource1.DataSource = OrderService.QueryOrder(2, textBox1.Text);
                    break;
                case ("客户姓名"):
                    bindingSource1.DataSource = OrderService.QueryOrder(3, textBox1.Text);
                    break;
                case ("订单金额"):
                    bindingSource1.DataSource = OrderService.QueryOrder(4, textBox1.Text);
                    break;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();
            switch(comboBox2.Text){
                case "苹果":
                    orderDetails.cargo = new Cargo("001");
                    break;
                case "大米":
                    orderDetails.cargo = new Cargo("002");
                    break;
                case "铁矿石":
                    orderDetails.cargo = new Cargo("003");
                    break;
            }
            orderDetails.amount = int.Parse(textBox5.Text);
            list.Add(orderDetails);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.orderId = textBox2.Text;
            order.customer.customerID = textBox3.Text;
            order.customer.customerName = textBox4.Text;
            order.orderDetails = list;
            list = null;
            OrderService.AddOrder(order);
            MessageBox.Show("订单添加成功");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrderService.DeleteOrder(textBox11.Text);
            MessageBox.Show("订单删除成功");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderService.Import();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderService.Export();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OrderService.ModifyOrderID(textBox10.Text, textBox6.Text);
            MessageBox.Show("修改成功");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OrderService.ModifyCustomerID(textBox10.Text, textBox7.Text);
            MessageBox.Show("修改成功");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OrderService.ModifyCustomerName(textBox10.Text, textBox8.Text);
            MessageBox.Show("修改成功");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OrderService.ModifyOrderDetailsCargo(textBox10.Text, comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString());

            MessageBox.Show("修改成功");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OrderService.ModifyOrderDetailsAmount(textBox10.Text, comboBox3.SelectedItem.ToString(), int.Parse(textBox13.Text));
            MessageBox.Show("修改成功");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();
            switch (comboBox5.Text)
            {
                case "苹果":
                    orderDetails.cargo = new Cargo("001");
                    break;
                case "大米":
                    orderDetails.cargo = new Cargo("002");
                    break;
                case "铁矿石":
                    orderDetails.cargo = new Cargo("003");
                    break;
            }
            orderDetails.amount = int.Parse(textBox9.Text);
            OrderService.QueryOrder(1, textBox10.Text).First().orderDetails.Add(orderDetails);
            MessageBox.Show("添加成功");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OrderService.QueryOrder(1, textBox10.Text).First().orderDetails.Remove(OrderService.QueryOrder(1, textBox10.Text).First().SelectOrderDetails(comboBox6.SelectedItem.ToString()));
            MessageBox.Show("删除成功");
        }
    }
}
