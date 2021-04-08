using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace _6._1_6._2
{
    [Serializable]
    public class Order : IComparable<OrderService>
    {
        public Order()
        {
            totalPrice = 0;
        }

        public Customer customer;
        public List<OrderDetails> orderDetails = new List<OrderDetails>();
        public long totalPrice { get; set; }
        public string orderId { get; set; }

        public override string ToString()
        {
            return (customer.ToString() + "订单编号：" + orderId + "\n"   + "订单总价：" + totalPrice + "\n");
        }
        public bool QueryOrderDetails(string key)
        {
            foreach (OrderDetails od in orderDetails)
            {
                if (od.cargo.cargoName == key)
                    return true;
            }
            return false;
        }
        public OrderDetails SelectOrderDetails(string key)
        {
            try
            {
                foreach (OrderDetails od in orderDetails)
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
            return orderId == o.orderId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(customer, orderDetails, totalPrice, orderId);
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Order))
                throw new ArgumentException();
            Order order = (Order)obj;
            return int.Parse(orderId).CompareTo(int.Parse(order.orderId));
        }

        public int CompareTo([AllowNull] OrderService other)
        {
            throw new NotImplementedException();
        }
    }
}
