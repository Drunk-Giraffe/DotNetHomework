using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _12.Models
{
    [Serializable]
    public class OrderDetail
    {
        public OrderDetail() { Id = Guid.NewGuid().ToString(); }
        public OrderDetail(string GoodsName, int GoodsAmount,double GoodsPrice)
        {
            Id = Guid.NewGuid().ToString();
            this.GoodsName = GoodsName;
            this.GoodsAmount = GoodsAmount;
            this.GoodsPrice = GoodsPrice;
        }
        [Key]
        public string Id { get; set; }
        public string GoodsName { get; set; }
        public int GoodsAmount { get; set; }
        public double GoodsPrice { get; set; }
        public double TP
        {
            get => GoodsAmount*GoodsPrice;
        }
        public override string ToString()
        {
            return $"商品名称：{GoodsName} 商品数量：{GoodsAmount} 商品价格：{GoodsPrice}";
        }
        public override bool Equals(object obj)
        {
            OrderDetail od = obj as OrderDetail;
            return GoodsName == od.GoodsName && GoodsAmount == od.GoodsAmount && GoodsPrice == od.GoodsPrice;
        }

        public override int GetHashCode()
        {
            var hashCode = -2127770830;
            hashCode = hashCode * -1521134295 + GoodsName.GetHashCode();
            hashCode = hashCode * -1521134295 + GoodsAmount.GetHashCode();
            hashCode = hashCode * -1521134295 + GoodsPrice.GetHashCode();
            return hashCode;
        }
    }
}
