using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _11
{
    public class OrderService
    {
        public OrderService()
        {        }
        public List<Order> Orders
        {
            get
            {
                using (var ctx = new OrderDBContext())
                {
                    return ctx.Orders.Include(o => o.OrderDetails.Select(d => d.Cargo)).Include("Customer").
                      ToList<Order>();
                }
            }
        }
        public void AddOrder(Order order)
        {
            FixOrder(order);
            using (var _context = new OrderDBContext())
            {
                try
                {
                    _context.Entry(order).State = EntityState.Added;
                    _context.SaveChanges();
                }catch(Exception e)
                {
                    MessageBox.Show(e.InnerException.Message); ;
                }
            }
        }
        public void DeleteOrder(string key)
        {
            using (var _context = new OrderDBContext())
            {
                var currentOrder = _context.Orders.Include(o => o.OrderDetails).Where(o => o.OrderId == key).FirstOrDefault();
                if (currentOrder == null)
                    throw new InvalidOperationException("要删除的订单不存在！");
                _context.OrderDetails.RemoveRange(currentOrder.OrderDetails);
                _context.Orders.Remove(currentOrder);
                _context.SaveChanges();
            }
        }
        public IEnumerable<Order> QueryOrder(int num, string key)
        {
            using (var _context = new OrderDBContext())
            {
                try
                {
                    List<Order> order;
                    switch (num)
                    {
                        case 1:
                            order = (from o in _context.Orders where o.OrderId == key orderby o.TotalPrice select o).ToList();
                            if (order == null)
                                throw new Exception("没有符合条件的订单！");
                            break;
                        case 2:
                            order = (from o in _context.Orders where o.QueryOrderDetails(key) orderby o.TotalPrice select o).ToList();
                            if (order == null)
                                throw new Exception("没有符合条件的订单！");
                            break;
                        case 3:
                            order = (from o in _context.Orders where o.Customer.CustomerName == key orderby o.TotalPrice select o).ToList();
                            if (order == null)
                                throw new Exception("没有符合条件的订单！");
                            break;
                        case 4:
                            order = (from o in _context.Orders where o.TotalPrice <= int.Parse(key) orderby o.TotalPrice select o).ToList();
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
        public void ModifyOrderDetailsCargo(string key1, string key2, string newCargo)
        {
            using (var _context = new OrderDBContext())
            {
                Order order = QueryOrder(1, key1).First();
                if (order != null)
                {
                    OrderDetails od = order.SelectOrderDetails(key2);
                    od.Cargo = new Cargo(newCargo);
                }
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public void ModifyOrderDetailsAmount(string key1, string key2, int newAmount)
        {
            using (var _context = new OrderDBContext())
            {
                Order order = QueryOrder(1, key1).First();
                if (order != null)
                {
                    OrderDetails od = order.SelectOrderDetails(key2);
                    od.Amount = newAmount;
                }
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public void ModifyCustomerName(string key, string newCustomerName)
        {
            using (var _context = new OrderDBContext())
            {
                Order order = QueryOrder(1, key).First();
                if (order != null)
                    order.Customer.CustomerName = newCustomerName;
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }

        }
        public void ModifyCustomerID(string key, string newCustomerID)
        {
            using (var _context = new OrderDBContext())
            {
                Order order = QueryOrder(1, key).First();
                if (order != null)
                    order.Customer.CustomerID = newCustomerID;
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public void ModifyOrderID(string key, string newOrderID)
        {
            using (var _context = new OrderDBContext())
            {
                Order order = QueryOrder(1, key).First();
                if (order != null)
                    order.OrderId = newOrderID;
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public bool Export()
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
        public bool Import()
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
        private void FixOrder(Order newOrder)
        {
            newOrder.Customer.CustomerID = newOrder.Customer.CustomerID;
            newOrder.Customer = null;
            newOrder.OrderDetails.ForEach(d =>
            {
                d.Cargo.CargoID = d.Cargo.CargoID;
                d.Cargo = null;
            });
        }

    }
}
