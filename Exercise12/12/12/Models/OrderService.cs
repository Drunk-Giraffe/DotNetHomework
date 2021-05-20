using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows;
namespace _12.Models
{
    public class OrderService
    {
        private OrderDBContext _context;
        public OrderService(OrderDBContext context)
        { _context = context; }
        public List<Order> Orders
        {
            get
            {
                using (_context)
                {
                    return _context.Orders.Include(o => o.OrderDetails.Select(d => d.GoodsName)).Include("CustomerName").
                      ToList<Order>();
                }
            }
        }
        public void AddOrder(Order order)
        {
            using ( _context)
            {
                try
                {
                    _context.Entry(order).State = EntityState.Added;
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
        public void DeleteOrder(string key)
        {
            using ( _context )
            {
                var currentOrder = _context.Orders.Include(o => o.OrderDetails).Where(o => o.OrderId == key).FirstOrDefault();
                if (currentOrder == null)
                    throw new InvalidOperationException("要删除的订单不存在！");
                _context.OrderDetails.RemoveRange(currentOrder.OrderDetails);
                _context.Orders.Remove(currentOrder);
                _context.SaveChanges();
            }
        }
        public Order GetOrder(string id)
        {

            return (from o in _context.Orders.Include(o => o.OrderDetails)
                    orderby o.TotalPrice
                    where o.OrderId == id
                    select o).FirstOrDefault();
        }

        public void EditOrder(Order order)
        {
            if (order == null)
                throw new ArgumentException("参数不能为null");

            var currentOrder = _context.Orders.Include(o => o.OrderDetails).Where(o => o.OrderId == order.OrderId).FirstOrDefault();
            if (currentOrder == null)
                throw new InvalidOperationException("要编辑的订单不存在！");


            if (!string.IsNullOrEmpty(order.CustomerName))
                currentOrder.CustomerName = order.CustomerName;
            if (order.OrderDetails != null && order.OrderDetails.Count > 0)
                currentOrder.OrderDetails = order.OrderDetails;
            _context.Entry(currentOrder).State = EntityState.Modified;
            _context.SaveChanges();
        }
            public bool Export()
        {
            using (_context )
            {

                using (FileStream fs = new FileStream("订单.xml", FileMode.Create))
                {
                    _serializer.Serialize(fs, _context.Orders);
                }
                _context.SaveChanges();
                return true;
            }
        }
        private static XmlSerializer _serializer = new XmlSerializer(typeof(Order[]), new[] { typeof(Order), typeof(OrderDetail) });
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
        

    }
}

