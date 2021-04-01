using System;
using System.Collections.Generic;
using System.Linq;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            Console.WriteLine("*************欢迎使用订单管理管理系统*************");
            Console.WriteLine("***************请选择您要使用的功能***************");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.添加订单");
                Console.WriteLine("2.删除订单");
                Console.WriteLine("3.查询订单");
                Console.WriteLine("4.修改订单");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        os.AddOrder();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("请输入订单编号：");
                        os.DeleteOrder(Console.ReadLine());
                        break;
                    case 3:
                        Console.Clear();
                        bool flag2 = true;
                        while (flag2)
                        {
                            Console.WriteLine("请选择查询方式：");
                            Console.WriteLine("1.订单编号");
                            Console.WriteLine("2.商品名称");
                            Console.WriteLine("3.客户姓名");
                            Console.WriteLine("4.订单金额");
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("请输入订单编号：");
                                    Order order1 = os.QueryOrder(1, Console.ReadLine()).First();
                                    if (order1!= null)
                                    {
                                        
                                        Console.WriteLine(order1.ToString());
                                        foreach (OrderDetails od in order1.orderDetails)
                                        {
                                            Console.WriteLine(od.ToString());
                                        }
                                    }
                                    bool flag3 = true;
                                    while (flag3)
                                    {
                                        Console.WriteLine("是否继续查询？（Y/N）");
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
                                    Console.WriteLine("请输入商品名称：");
                                    List<Order> order2 = os.QueryOrder(2, Console.ReadLine());
                                    if (order2!= null)
                                    {
                                        foreach (Order o in order2)
                                        {
                                            Console.WriteLine(o.ToString());
                                            foreach (OrderDetails od in o.orderDetails)
                                            {
                                                Console.WriteLine(od.ToString());
                                            }
                                        }
                                    }
                                    bool flag4 = true;
                                    while (flag4)
                                    {
                                        Console.WriteLine("是否继续查询？（Y/N）");
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
                                case 3:
                                    Console.WriteLine("请输入客户姓名：");
                                    List<Order> order3 = os.QueryOrder(2, Console.ReadLine());
                                    if (order3 != null)
                                    {
                                        foreach (Order o in order3)
                                        {
                                            Console.WriteLine(o.ToString());
                                            foreach (OrderDetails od in o.orderDetails)
                                            {
                                                Console.WriteLine(od.ToString());
                                            }
                                        }
                                    }
                                    bool flag5 = true;
                                    while (flag5)
                                    {
                                        Console.WriteLine("是否继续查询？（Y/N）");
                                        switch (Console.ReadLine())
                                        {
                                            case "Y":
                                                flag5 = false;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case "N":
                                                flag5 = false;
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
                                case 4:
                                    Console.WriteLine("请输入订单金额：");
                                    List<Order> order4 = os.QueryOrder(2, Console.ReadLine());
                                    if (order4 != null)
                                    {
                                        foreach (Order o in order4)
                                        {
                                            Console.WriteLine(o.ToString());
                                            foreach (OrderDetails od in o.orderDetails)
                                            {
                                                Console.WriteLine(od.ToString());
                                            }
                                        }
                                    }
                                    bool flag6 = true;
                                    while (flag6)
                                    {
                                        Console.WriteLine("是否继续查询？（Y/N）");
                                        switch (Console.ReadLine())
                                        {
                                            case "Y":
                                                flag6 = false;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case "N":
                                                flag6 = false;
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
                    case 4:
                        Console.Clear();
                        Console.WriteLine("请输入订单编号：");
                        os.ModifyOrder(Console.ReadLine());
                        break;
                    case 5:
                        foreach (Order o in os.orders)
                        {
                            Console.WriteLine(o.ToString());
                            foreach(OrderDetails od in o.orderDetails)
                            {
                                Console.WriteLine(od.ToString());
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("请重新选择！");
                        break;
                }
            }
        }
    }
}
