using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _8
{
    public class OrderService
    {
        public OrderService() { }
        public List<Order> orders = new List<Order>();
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
        public void DeleteOrder(string key)
        {
            orders.Remove(QueryOrder(1, key).First());
            Console.WriteLine("订单" + key + "已删除！");
            Console.ReadLine();
            Console.Clear();
        }
        public List<Order> QueryOrder(int num, string key)
        {
            try
            {
                List<Order> order;
                switch (num)
                {
                    case 1:
                        order = (from o in orders where o.orderId == key orderby o.totalPrice select o).ToList();
                        if (order == null)
                            throw new Exception("没有符合条件的订单！");
                        break;
                    case 2:
                        order = (from o in orders where o.QueryOrderDetails(key) orderby o.totalPrice select o).ToList();
                        if (order == null)
                            throw new Exception("没有符合条件的订单！");
                        break;
                    case 3:
                        order = (from o in orders where o.customer.customerName == key orderby o.totalPrice select o).ToList();
                        if (order == null)
                            throw new Exception("没有符合条件的订单！");
                        break;
                    case 4:
                        order = (from o in orders where o.totalPrice <= int.Parse(key) orderby o.totalPrice select o).ToList();
                        if (order == null)
                            throw new Exception("没有符合条件的订单！");
                        break;
                    default:
                        throw new Exception("输入错误！");
                }
                return order;
            }
            catch (Exception)
            {
                Console.WriteLine("没有符合条件的订单！");
                return null;
            }
        }
        public void ModifyOrderDetailsCargo(string key1, string key2, string newCargo)
        {
            Order order = QueryOrder(1, key1).First();
            if (order != null)
            {
                OrderDetails od = order.SelectOrderDetails(key2);
                od.cargo = new Cargo(newCargo);
            }
        }
        public void ModifyOrderDetailsAmount(string key1, string key2, int newAmount)
        {
            Order order = QueryOrder(1, key1).First();
            if (order != null)
            {
                OrderDetails od = order.SelectOrderDetails(key2);
                od.amount = newAmount;
            }
        }
        public void ModifyCustomerName(string key, string newCustomerName)
        {
            Order order = QueryOrder(1, key).First();
            if(order!=null)
            order.customer.customerName = newCustomerName;
        }
        public void ModifyCustomerID(string key, string newCustomerID)
        {
            Order order = QueryOrder(1, key).First();
            if(order!=null)
            order.customer.customerID = newCustomerID;
        }
        public void ModifyOrderID(string key, string newOrderID)
        {
            Order order = QueryOrder(1, key).First();
            if (order != null)
                order.orderId = newOrderID;
        }
        public bool Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("订单.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
            return true;
        }
        public bool Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("订单.xml", FileMode.Open))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);
            }
            return true;
        }
        public void SortBy(int num)
        {
            switch (num)
            {
                case 1:
                    orders.Sort();
                    break;
                case 2:
                    orders.Sort((o1, o2) => (int)(o1.totalPrice - o2.totalPrice));
                    break;
                case 3:
                    orders.Sort((o1, o2) => int.Parse(o1.customer.customerID) - int.Parse(o2.customer.customerID));
                    break;
                default:
                    Console.WriteLine("请重新输入！");
                    break;
            }
        }

    }
}
