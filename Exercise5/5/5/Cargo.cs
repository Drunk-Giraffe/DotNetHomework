using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    class Cargo
    {
        public Cargo(string ID)
        {
            switch (ID) {
                case "001":
                    cargoID = ID;
                    cargoName = "苹果";
                    cargoPrice = 5;
                    cargoDescription = "一种水果";
                    break;
                case "002":
                    cargoID = ID;
                    cargoName = "大米";
                    cargoPrice = 3;
                    cargoDescription = "一种粮食";
                    break;
                case "003":
                    cargoID = ID;
                    cargoName = "铁矿石";
                    cargoPrice = 1000;
                    cargoDescription = "一种工业原料";
                    break;
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
    }
}
