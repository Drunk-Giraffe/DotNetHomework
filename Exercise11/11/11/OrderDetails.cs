using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails() { }
        public OrderDetails(Cargo cargo, int amount)
        {
            this.cargo = cargo;
            this.amount = amount;
        }
        public Cargo cargo { get; set; }
        public int amount { get; set; }
        public double TP
        {
            get => cargo == null ? 0.0 : cargo.cargoPrice * amount;
        }
        public override string ToString()
        {
            return (cargo.ToString() + "货物数量：" + amount + "\n");
        }
        public override bool Equals(object obj)
        {
            OrderDetails od = obj as OrderDetails;
            return cargo == od.cargo && amount == od.amount;
        }

        public override int GetHashCode()
        {
            var hashCode = -2127770830;
            hashCode = hashCode * -1521134295 + cargo.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cargo.cargoName);
            hashCode = hashCode * -1521134295 + amount.GetHashCode();
            return hashCode;
        }
    }
}
