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
        public Customer() { }
        public Customer(string ID, string name)
        {
            customerID = ID;
            customerName = name;
        }
        public string customerID { get; set; }
        public string customerName { get; set; }
        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null &&
                   customerID == customer.customerID &&
                   customerName == customer.customerName;
        }
        public override int GetHashCode()
        {
            var hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(customerID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(customerName);
            return hashCode;
        }
        public override string ToString()
        {
            return ("顾客编号：" + customerID + "\n" + "顾客姓名：" + customerName + "\n");
        }
    }
}
