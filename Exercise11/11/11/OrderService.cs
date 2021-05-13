using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _11
{
    public class OrderService
    {
        public static void AddOrder(Order order)
        {
            using (var _context = new OrderDBContext())
            {
                _context.Orders.Add(order);
                _context.Entry(order).State = EntityState.Added;
                _context.SaveChanges();
            }
        }
        public static void DeleteOrder(string key)
        {
            using (var _context = new OrderDBContext())
            {
                var currentOrder = _context.Orders.Include(o => o.orderDetails).Where(o => o.orderId == key).FirstOrDefault();
                if (currentOrder == null)
                    throw new InvalidOperationException("要删除的订单不存在！");
                _context.Orders.Remove(currentOrder);
                _context.SaveChanges();
            }
        }
        public static IEnumerable<Order> QueryOrder(int num, string key)
        {
            using (var _context = new OrderDBContext())
            {
                try
                {
                    List<Order> order;
                    switch (num)
                    {
                        case 1:
                            order = (from o in _context.Orders where o.orderId == key orderby o.totalPrice select o).ToList();
                            if (order == null)
                                throw new Exception("没有符合条件的订单！");
                            break;
                        case 2:
                            order = (from o in _context.Orders where o.QueryOrderDetails(key) orderby o.totalPrice select o).ToList();
                            if (order == null)
                                throw new Exception("没有符合条件的订单！");
                            break;
                        case 3:
                            order = (from o in _context.Orders where o.customer.customerName == key orderby o.totalPrice select o).ToList();
                            if (order == null)
                                throw new Exception("没有符合条件的订单！");
                            break;
                        case 4:
                            order = (from o in _context.Orders where o.totalPrice <= int.Parse(key) orderby o.totalPrice select o).ToList();
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
        }
        public static void ModifyOrderDetailsCargo(string key1, string key2, string newCargo)
        {
            using (var _context = new OrderDBContext())
            {
                Order order = QueryOrder(1, key1).First();
                if (order != null)
                {
                    OrderDetails od = order.SelectOrderDetails(key2);
                    od.cargo = new Cargo(newCargo);
                }
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public static void ModifyOrderDetailsAmount(string key1, string key2, int newAmount)
        {
            using (var _context = new OrderDBContext())
            {
                Order order = QueryOrder(1, key1).First();
                if (order != null)
                {
                    OrderDetails od = order.SelectOrderDetails(key2);
                    od.amount = newAmount;
                }
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public static void ModifyCustomerName(string key, string newCustomerName)
        {
            using (var _context = new OrderDBContext())
            {
                Order order = QueryOrder(1, key).First();
                if (order != null)
                    order.customer.customerName = newCustomerName;
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }

        }
        public static void ModifyCustomerID(string key, string newCustomerID)
        {
            using (var _context = new OrderDBContext())
            {
                Order order = QueryOrder(1, key).First();
                if (order != null)
                    order.customer.customerID = newCustomerID;
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public static void ModifyOrderID(string key, string newOrderID)
        {
            using (var _context = new OrderDBContext())
            {
                Order order = QueryOrder(1, key).First();
                if (order != null)
                    order.orderId = newOrderID;
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public static bool Export()
        {
            using (var _context = new OrderDBContext())
            {
                
                using (FileStream fs = new FileStream("订单.xml", FileMode.Create))
                {
                    _serializer.Serialize(fs, _context.Orders);
                }
                _context.SaveChanges();
                return true;
            }
        }
        private static XmlSerializer _serializer = new XmlSerializer(typeof(Order[]), new[] { typeof(Order), typeof(OrderDetails) });
        public static bool Import()
        {
            if (!File.Exists("订单.xml"))
                throw new InvalidOperationException("文件不存在");
            Order[] arr = null;
            using (var input = File.OpenRead("订单.xml"))
            {
                arr = _serializer.Deserialize(input) as Order[];
            }
            if (arr == null)
                throw new InvalidOperationException("读取失败");
            foreach (var o in arr)
            {
                AddOrder(o);
            }
            return true;
        }
    }
}
