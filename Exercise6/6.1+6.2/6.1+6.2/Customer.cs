
using System;

namespace _6._1_6._2
{
    [Serializable]
    public class Customer
    {
        public Customer() { }
        public Customer(string ID, string name)
        {
            customerID = ID;
            customerName = name;
        }
        public string customerID { get; set; }
        public string customerName { get; set; }
        public override string ToString()
        {
            return ("顾客编号：" + customerID + "\n" + "顾客姓名：" + customerName + "\n");
        }
    }
}
