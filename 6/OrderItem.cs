//货物名称，货物单价，货物数量

using System;
using System.Collections.Generic;
using System.Text;

namespace OrderWork
{
    class OrderItem
    {
        public string goodsName = null;
        public double goodsPrice = 0;   //Order类中用到货物单价，故公开
        public int goodsNum = 0;

        public OrderItem() { }
        public OrderItem(string goodsName, double goodsPrice, int goodsNum)
        {
            this.goodsPrice = goodsPrice;
            this.goodsName = goodsName;
            this.goodsNum = goodsNum;
        }

        //重写ToString
        public override string ToString()
        {
            return "货物名称：" + goodsName + "\n货物单价：" + goodsPrice + "\n货物数量：" + goodsNum + "\n"; 
        }

        //重写Equals
        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            if(orderItem == null)
            {
                return false;
            }
            return this.goodsName == orderItem.goodsName;
        }

        public override int GetHashCode()
        {
            return (goodsName != null ? StringComparer.InvariantCulture.GetHashCode(goodsName) : 0);
        }
    }
}
