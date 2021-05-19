using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    [Serializable]
    public class Cargo
    {
        public Cargo() { CargoID = Guid.NewGuid().ToString(); }
        public Cargo(string ID)
        {
            bool flag = true;
            while (flag)
            {
                switch (ID)
                {
                    case "001":
                        CargoID = ID;
                        CargoName = "苹果";
                        CargoPrice = 5;
                        CargoDescription = "一种水果";
                        flag = false;
                        break;
                    case "002":
                        CargoID = ID;
                        CargoName = "大米";
                        CargoPrice = 3;
                        CargoDescription = "一种粮食";
                        flag = false;
                        break;
                    case "003":
                        CargoID = ID;
                        CargoName = "铁矿石";
                        CargoPrice = 1000;
                        CargoDescription = "一种工业原料";
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("货物不存在！请重新选择");
                        flag = false;
                        break;
                }
            }
        }
        public string CargoID { get; set; }
        public string CargoName { get; set; }
        public long CargoPrice { get; set; }
        public string CargoDescription { get; set; }
        public override string ToString()
        {
            return ("货物编号：" + CargoID + "\n" + "货物名称：" + CargoName + "\n" + "货物价格：" + CargoPrice + "\n" + "货物描述：" + CargoDescription + "\n");
        }
        public override bool Equals(object obj)
        {
            var cargo = obj as Cargo;
            return cargo != null &&
                   CargoID == cargo.CargoID &&
                   CargoName == cargo.CargoName &&
                   CargoDescription == cargo.CargoDescription;
        }

        public override int GetHashCode()
        {
            var hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CargoID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CargoName);
            return hashCode;
        }
    }
}
