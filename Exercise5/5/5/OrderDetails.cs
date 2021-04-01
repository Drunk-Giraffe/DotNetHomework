using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    class OrderDetails
    {
        public OrderDetails(Cargo cargo,int amount)
        {
            this.cargo = cargo;
            this.amount = amount;
            TP = amount * cargo.cargoPrice;
        }
        public Cargo cargo { get; set; }
        public int amount { get; set; }
        public long TP;
        public override string ToString()
        {
            return (cargo.ToString()+"货物数量："+amount+"\n");
        }
        public override bool Equals(object obj)
        {
            OrderDetails od = obj as OrderDetails;
            return cargo==od.cargo&&amount==od.amount;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
