using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._1_6._2
{
    class OrderSystem
    {
        public OrderSystem() { }
        public OrderService os=new OrderService();
        public void UI()
        {
            Console.WriteLine("*************欢迎使用订单管理管理系统*************");
            Console.WriteLine("***************请选择您要使用的功能***************");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.添加订单");
                Console.WriteLine("2.删除订单");
                Console.WriteLine("3.查询订单");
                Console.WriteLine("4.修改订单");
                Console.WriteLine("5.导出订单");
                Console.WriteLine("6.导入订单");
                Console.WriteLine("7.退出");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        AddOrderUI();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("请输入订单编号：");
                        os.DeleteOrder(Console.ReadLine());
                        break;
                    case 3:
                        QueryOrderUI();
                        break;
                    case 4:
                        ModifyOrderUI();
                        break;
                    case 5:
                        os.Export();
                        break;
                    case 6:
                        os.Import();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("请重新选择！");
                        break;
                }
            }

        }
        public void AddOrderUI()
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
            os.AddOrder(newOrder);
            Console.ReadLine();
            Console.Clear();
        }
        public void QueryOrderUI()
        {
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
                        if (order1 != null)
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
                        if (order2 != null)
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
                        List<Order> order3 = os.QueryOrder(3, Console.ReadLine());
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
            
        }
        public void ModifyOrderUI()
        {
            Console.Clear();
            bool flag = true;
            Console.WriteLine("请输入要修改的订单的订单编号：");
            string key = Console.ReadLine();
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
                        string cargoName = Console.ReadLine();
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
                                    string newCargo = Console.ReadLine();
                                    os.ModifyOrderDetailsCargo(key, cargoName, newCargo);
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
                                    os.ModifyOrderDetailsAmount(key, cargoName, newAmount);
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
                                    string newCustomerName = Console.ReadLine();
                                    os.ModifyCustomerName(key, newCustomerName);
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
                                    string newCustomerID = Console.ReadLine();
                                    os.ModifyCustomerID(key, newCustomerID);
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
                        string newOrderId = Console.ReadLine();
                        os.ModifyOrderID(key, newOrderId);
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
    
