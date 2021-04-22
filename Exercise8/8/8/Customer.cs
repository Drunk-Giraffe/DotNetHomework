using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
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
