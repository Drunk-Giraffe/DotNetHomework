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
        public Cargo() { }
        public Cargo(string ID)
        {
            bool flag = true;
            while (flag)
            {
                switch (ID)
                {
                    case "001":
                        cargoID = ID;
                        cargoName = "苹果";
                        cargoPrice = 5;
                        cargoDescription = "一种水果";
                        flag = false;
                        break;
                    case "002":
                        cargoID = ID;
                        cargoName = "大米";
                        cargoPrice = 3;
                        cargoDescription = "一种粮食";
                        flag = false;
                        break;
                    case "003":
                        cargoID = ID;
                        cargoName = "铁矿石";
                        cargoPrice = 1000;
                        cargoDescription = "一种工业原料";
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("货物不存在！请重新选择");
                        flag = false;
                        break;
                }
            }
        }
        public string cargoID { get; set; }
        public string cargoName { get; set; }
        public long cargoPrice { get; set; }
        public string cargoDescription { get; set; }
        public override string ToString()
        {
            return ("货物编号：" + cargoID + "\n" + "货物名称：" + cargoName + "\n" + "货物价格：" + cargoPrice + "\n" + "货物描述：" + cargoDescription + "\n");
        }
        public override bool Equals(object obj)
        {
            var cargo = obj as Cargo;
            return cargo != null &&
                   cargoID == cargo.cargoID &&
                   cargoName == cargo.cargoName &&
                   cargoDescription == cargo.cargoDescription;
        }

        public override int GetHashCode()
        {
            var hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cargoID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cargoName);
            return hashCode;
        }
    }
}
