using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _11
{
    public partial class Form1 : Form
    {
        List<OrderDetails> list = new List<OrderDetails>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var _context = new OrderDBContext()) {
                bindingSource1.DataSource = _context.Orders; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var _context = new OrderDBContext())
            {
                switch (QueryWay.SelectedItem.ToString())
                {
                    case ("订单编号"):
                        bindingSource1.DataSource = OrderService.QueryOrder(1, QueryKey.Text);
                        break;
                    case ("商品名称"):
                        bindingSource1.DataSource = OrderService.QueryOrder(2, QueryKey.Text);
                        break;
                    case ("客户姓名"):
                        bindingSource1.DataSource = OrderService.QueryOrder(3, QueryKey.Text);
                        break;
                    case ("订单金额"):
                        bindingSource1.DataSource = OrderService.QueryOrder(4, QueryKey.Text);
                        break;
                }
                bindingSource1.ResetBindings(false);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();
            switch (AddCargoName.Text)
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
            orderDetails.amount = int.Parse(AddCargoAmount.Text);
            list.Add(orderDetails);
            bindingSource1.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.orderId = AddOrderID.Text;
            Customer customer = new Customer();
            customer.customerID = AddCustomerID.Text;
            customer.customerName = AddCustomerName.Text;
            order.customer = customer;
            order.orderDetails = list;
            list = null;
            OrderService.AddOrder(order);
            bindingSource1.ResetBindings(false);
            MessageBox.Show("订单添加成功");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrderService.DeleteOrder(DeleteOrderID.Text);
            bindingSource1.ResetBindings(false);
            MessageBox.Show("订单删除成功");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OrderService.Import())
            {
                MessageBox.Show("导入成功");
                bindingSource1.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("导入失败");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (OrderService.Export())
            {
                MessageBox.Show("导出成功");
                bindingSource1.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("导出失败");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OrderService.ModifyOrderID(ModifiedOrderID.Text, NewOrderID.Text);
            bindingSource1.ResetBindings(false);
            MessageBox.Show("修改成功");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OrderService.ModifyCustomerID(ModifiedOrderID.Text, NewCustomerID.Text);
            bindingSource1.ResetBindings(false);
            MessageBox.Show("修改成功");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OrderService.ModifyCustomerName(ModifiedOrderID.Text, NewCustomerName.Text);
            bindingSource1.ResetBindings(false);
            MessageBox.Show("修改成功");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OrderService.ModifyOrderDetailsCargo(ModifiedOrderID.Text, ModifiedCargo.SelectedItem.ToString(), NewCargo.SelectedItem.ToString());
            bindingSource1.ResetBindings(false);
            MessageBox.Show("修改成功");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OrderService.ModifyOrderDetailsAmount(ModifiedOrderID.Text, ModifiedCargo.SelectedItem.ToString(), int.Parse(NewCargoAmount.Text));
            bindingSource1.ResetBindings(false);
            MessageBox.Show("修改成功");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();
            switch (AddNewCargoName.Text)
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
            orderDetails.amount = int.Parse(AddNewCargoAmount.Text);
            OrderService.QueryOrder(1, ModifiedOrderID.Text).First().orderDetails.Add(orderDetails);
            bindingSource1.ResetBindings(false);
            MessageBox.Show("添加成功");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OrderService.QueryOrder(1, ModifiedOrderID.Text).First().orderDetails.Remove(OrderService.QueryOrder(1, ModifiedOrderID.Text).First().SelectOrderDetails(DeleteCargoName.SelectedItem.ToString()));
            bindingSource1.ResetBindings(false);
            MessageBox.Show("删除成功");
        }
    }
}
