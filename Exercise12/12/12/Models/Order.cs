using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _12.Models
{
    [Serializable]
    public class Order 
    {
        public Order()
        {
            OrderId = Guid.NewGuid().ToString();
            OrderDetails = new List<OrderDetail>();
        }

        public string CustomerName { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public double TotalPrice { get => OrderDetails.Sum(orderDetails => orderDetails.TP); }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string OrderId { get; set; }
        public bool IsComplete { get; set; }

        public override string ToString()
        {
            return (Customer.ToString() + "订单编号：" + OrderId + "\n" + "订单总价：" + TotalPrice + "\n");
        }
        public bool QueryOrderDetails(string key)
        {
            foreach (OrderDetail od in OrderDetails)
            {
                if (od.GoodsName == key)
                    return true;
            }
            return false;
        }
        public OrderDetail SelectOrderDetails(string key)
        {
            try
            {
                foreach (OrderDetail od in OrderDetails)
                {
                    if (QueryOrderDetails(key))
                        return od;
                }
                throw new Exception("订单中无此货物！");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return OrderId == o.OrderId;
        }

        public override int GetHashCode()
        {
            var hashCode = -531220479;
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Customer.CustomerName);
            return hashCode;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Order))
                throw new ArgumentException();
            Order order = (Order)obj;
            return int.Parse(OrderId).CompareTo(int.Parse(order.OrderId));
        }

        
    }
}
