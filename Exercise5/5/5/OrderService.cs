using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5
{
    class OrderService
    {
        public OrderService() { }
        public List<Order> orders = new List<Order>();
        public void AddOrder()
        {
            Console.Clear();
            Order newOrder = new Order();
            Console.WriteLine("请输入客户姓名：");
            string customerName = Console.ReadLine();
            Console.WriteLine("请输入客户编号：");
            string customerID = Console.ReadLine();
            Customer newCustomer = new Customer(customerID, customerName);
            newOrder.customer = newCustomer;
            Console.WriteLine("请输入订单编号：");
            newOrder.orderId = Console.ReadLine();
            bool flag = true;
            while (flag)
            {
                bool flag2 = true;
                Console.WriteLine("请选择货物：（编号001：苹果（单位：千克）；002：大米（单位：千克）；003：铁矿石（单位：吨）");
                string ID = Console.ReadLine();
                Cargo newCargo = new Cargo(ID);
                Console.WriteLine("请输入货物数量：");
                int newAmount = int.Parse(Console.ReadLine());
                OrderDetails newOrderDetails = new OrderDetails(newCargo, newAmount);
                newOrder.orderDetails.Add(newOrderDetails);
                Console.WriteLine("是否继续购买？（Y/N）");
                while (flag2)
                {
                    switch (Console.ReadLine())
                    {
                        case "Y":
                            flag2 = false;
                            break;
                        case "N":
                            flag2 = false;
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("输入错误，请重新输入！");
                            break;
                    }
                }
            }
            foreach (OrderDetails orderDetails in newOrder.orderDetails)
            {
                newOrder.totalPrice += orderDetails.TP;
            }
            orders.Add(newOrder);
            Console.ReadLine();
            Console.Clear();
        }
        public void DeleteOrder(string key)
        {   orders.Remove(QueryOrder(1, key).First());
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
        public void ModifyOrder(string key)
        {
            
            Console.Clear();
            bool flag = true;
            Order order=QueryOrder( 1, key).First();
            while (flag)
            {
                Console.WriteLine("请选择要修改的内容：");
                Console.WriteLine("1.订单明细");
                Console.WriteLine("2.客户信息");
                Console.WriteLine("3.订单编号");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("请输入要修改的货物名称：");
                        OrderDetails od = order.SelectOrderDetails(Console.ReadLine());
                        bool flag8 = true;
                        Console.Clear();
                        while (flag8)
                        {
                            Console.WriteLine("请选择要修改的内容：");
                            Console.WriteLine("1.货物种类");
                            Console.WriteLine("2.货物数量");
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("请输入货物编号：");
                                    string newName = Console.ReadLine();
                                    od.cargo = new Cargo(newName);
                                    od.TP = od.amount * od.cargo.cargoPrice;
                                    order.totalPrice = 0;
                                    foreach (OrderDetails orderDetails in order.orderDetails)
                                    {
                                        order.totalPrice += orderDetails.TP;
                                    }
                                    Console.WriteLine("修改成功！是否继续修改？（Y/N）");
                                    bool flag7 = true;
                                    while (flag7)
                                    {
                                        switch (Console.ReadLine())
                                        {
                                            case "Y":
                                                flag7 = false;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case "N":
                                                flag7 = false;
                                                flag8 = false;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            default:
                                                Console.WriteLine("请重新输入！");
                                                break;
                                        }
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("请输入货物数量：");
                                    int newAmount = int.Parse(Console.ReadLine());
                                    od.amount = newAmount;
                                    od.TP = od.amount * od.cargo.cargoPrice;
                                    order.totalPrice = 0;
                                    foreach (OrderDetails orderDetails in order.orderDetails)
                                    {
                                        order.totalPrice += orderDetails.TP;
                                    }
                                    Console.WriteLine("修改成功！是否继续修改？（Y/N）");
                                    bool flag9 = true;
                                    while (flag9)
                                    {
                                        switch (Console.ReadLine())
                                        {
                                            case "Y":
                                                flag9 = false;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case "N":
                                                flag9 = false;
                                                flag8 = false;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            default:
                                                Console.WriteLine("请重新输入！");
                                                break;
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("请重新选择！");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        bool flag2 = true;
                        while (flag2)
                        {
                            Console.WriteLine("请选择要修改的内容：");
                            Console.WriteLine("1.客户姓名");
                            Console.WriteLine("2.客户编号");
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("请输入新的客户姓名：");
                                    order.customer.customerName = Console.ReadLine();
                                    Console.WriteLine("是否继续修改？（Y/N）");
                                    bool flag3 = true;
                                    while (flag3)
                                    {
                                        switch (Console.ReadLine())
                                        {
                                            case "Y":
                                                flag3 = false;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case "N":
                                                flag3 = false;
                                                flag2 = false;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            default:
                                                Console.WriteLine("请重新输入！");
                                                break;
                                        }
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("请输入新的客户编号：");
                                    order.customer.customerID = Console.ReadLine();
                                    Console.WriteLine("是否继续修改？（Y/N）");
                                    bool flag4 = true;
                                    while (flag4)
                                    {
                                        switch (Console.ReadLine())
                                        {
                                            case "Y":
                                                flag4 = false;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case "N":
                                                flag4 = false;
                                                flag2 = false;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            default:
                                                Console.WriteLine("请重新输入！");
                                                break;
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("请重新选择！");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("请输入新的订单编号：");
                        order.orderId = Console.ReadLine();
                        Console.WriteLine("是否继续修改？（Y/N）");
                        bool flag5 = true;
                        while (flag5)
                        {
                            switch (Console.ReadLine())
                            {
                                case "Y":
                                    flag5 = false;
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case "N":
                                    flag5 = false;
                                    flag = false;
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("请重新输入！");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("请重新选择！");
                        break;
                }
                Console.WriteLine("是否继续修改？（Y/N）");
                bool flag6 = true;
                while (flag6)
                {
                    switch (Console.ReadLine())
                    {
                        case "Y":
                            flag6 = false;
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "N":
                            flag6 = false;
                            flag = false;
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("请重新输入！");
                            break;
                    }
                }
            }
        }

    }
}
