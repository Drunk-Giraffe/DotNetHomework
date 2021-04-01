using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    class Order
    {
        public Order()
        {
            orderTime = DateTime.Now.ToString();
            totalPrice = 0;
        }
        
        public Customer customer;
        public List<OrderDetails> orderDetails = new List<OrderDetails>();
        public long totalPrice { get; set; }
        public string orderId { get; set; }
        public string orderTime { get; set; }
        public override string ToString()
        {
            return (customer.ToString() + "订单编号：" + orderId + "\n" + "下单时间：" + orderTime + "\n" + "订单总价：" + totalPrice+ "\n");
        }
        public bool QueryOrderDetails(string key)
        {
            foreach(OrderDetails od in orderDetails)
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
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return orderId==o.orderId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(customer, orderDetails, totalPrice, orderId, orderTime);
        }
    }
}
