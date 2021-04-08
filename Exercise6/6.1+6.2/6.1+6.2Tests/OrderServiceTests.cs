using Microsoft.VisualStudio.TestTools.UnitTesting;
using _6._1_6._2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace _6._1_6._2.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        OrderService orderService = new OrderService();
        [TestInitialize()]
        public void Initialize()
        {
            Order order = new Order();
            Customer customer = new Customer("1", "张三");
            order.customer = customer;
            order.orderId = "1";
            order.orderDetails.Add(new OrderDetails(new Cargo("001"), 1));
            orderService.AddOrder(order);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Order order = new Order();
            Customer customer = new Customer("2", "李四");
            order.customer = customer;
            order.orderId = "2";
            order.orderDetails.Add(new OrderDetails(new Cargo("002"), 3));
            foreach (OrderDetails orderDetails in order.orderDetails)
            {
                order.totalPrice += orderDetails.TP;
            }
            orderService.AddOrder(order);
            Assert.AreEqual(orderService.orders.Find(p => p.orderId == order.orderId), order);
        }

        [TestMethod()]
        public void QueryOrderTest()
        {
            Assert.AreEqual(orderService.orders.First(), orderService.QueryOrder(1, "1").First());
        }

        [TestMethod()]
        public void ModifyOrderDetailsCargoTest()
        {
            Order order = new Order();
            Customer customer = new Customer("1", "张三");
            order.customer = customer;
            order.orderId = "1";
            order.orderDetails.Add(new OrderDetails(new Cargo("002"), 1));
            order.totalPrice = 0;
            foreach (OrderDetails orderDetails in order.orderDetails)
            {
                order.totalPrice += orderDetails.TP;
            }
            orderService.ModifyOrderDetailsCargo("1", "苹果", "002");
            Assert.AreEqual(orderService.orders.First(), order);
        }

        [TestMethod()]
        public void ModifyOrderDetailsAmountTest()
        {
            Order order = new Order();
            Customer customer = new Customer("1", "张三");
            order.customer = customer;
            order.orderId = "1";
            order.orderDetails.Add(new OrderDetails(new Cargo("001"), 2));
            foreach (OrderDetails orderDetails in order.orderDetails)
            {
                order.totalPrice += orderDetails.TP;
            }
            orderService.ModifyOrderDetailsAmount("1", "苹果", 2);
            Assert.AreEqual(orderService.orders.First(), order);
        }

        [TestMethod()]
        public void ModifyCustomerNameTest()
        {
            Order order = new Order();
            Customer customer = new Customer("1", "李四");
            order.customer = customer;
            order.orderId = "1";
            order.orderDetails.Add(new OrderDetails(new Cargo("001"), 1));
            orderService.ModifyCustomerName("1", "李四");
            Assert.AreEqual(orderService.orders.First(), order);
        }

        [TestMethod()]
        public void ModifyCustomerIDTest()
        {
            Order order = new Order();
            Customer customer = new Customer("2", "张三");
            order.customer = customer;
            order.orderId = "1";
            order.orderDetails.Add(new OrderDetails(new Cargo("001"), 1));
            orderService.ModifyCustomerID("1", "2");
            Assert.AreEqual(orderService.orders.First(), order);
        }

        [TestMethod()]
        public void ModifyOrderIDTest()
        {
            Order order = new Order();
            Customer customer = new Customer("1", "张三");
            order.customer = customer;
            order.orderId = "2";
            order.orderDetails.Add(new OrderDetails(new Cargo("001"), 1));
            orderService.ModifyOrderID("1", "2");
            Assert.AreEqual(orderService.orders.First(), order);
        }
        [TestMethod()]
        public void DeleteOrderTest()
        {
            Assert.ThrowsException<KeyNotFoundException>(() => orderService.DeleteOrder("1"));
        }
        [TestMethod()]
        public void ExportTest()
        {
            orderService.Export();
            Assert.AreEqual(new FileInfo("订单.xml"), new FileInfo("订单1.xml"));
        }
    }   
}