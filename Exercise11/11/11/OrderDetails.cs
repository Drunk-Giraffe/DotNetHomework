using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails() { Id = Guid.NewGuid().ToString(); }
        public OrderDetails(Cargo cargo, int amount)
        {
            Id = Guid.NewGuid().ToString();
            this.Cargo = cargo;
            this.Amount = amount;
        }
        public string Id { get; set; }
        public Cargo Cargo { get; set; }
        public int Amount { get; set; }
        public double TP
        {
            get => Cargo == null ? 0.0 : Cargo.CargoPrice * Amount;
        }
        public override string ToString()
        {
            return (Cargo.ToString() + "货物数量：" + Amount + "\n");
        }
        public override bool Equals(object obj)
        {
            OrderDetails od = obj as OrderDetails;
            return Cargo == od.Cargo && Amount == od.Amount;
        }

        public override int GetHashCode()
        {
            var hashCode = -2127770830;
            hashCode = hashCode * -1521134295 + Cargo.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cargo.CargoName);
            hashCode = hashCode * -1521134295 + Amount.GetHashCode();
            return hashCode;
        }
    }
}
