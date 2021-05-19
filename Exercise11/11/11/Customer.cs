using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    [Serializable]
    public class Customer
    {
        public Customer() { CustomerID = Guid.NewGuid().ToString(); }
        public Customer(string ID, string name)
        {
            CustomerID = ID;
            CustomerName = name;
        }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null &&
                   CustomerID == customer.CustomerID &&
                   CustomerName == customer.CustomerName;
        }
        public override int GetHashCode()
        {
            var hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerName);
            return hashCode;
        }
        public override string ToString()
        {
            return ("顾客编号：" + CustomerID + "\n" + "顾客姓名：" + CustomerName + "\n");
        }
    }
}
