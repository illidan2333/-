//订单号、日期、地址、顾客姓名和ID；
//注意订单明细，通过List来存储
//订单总价值

using System;
using System.Collections.Generic;
using System.Text;

namespace OrderWork
{
    class Order
    {
        public int orderID = 0;
        public int[] dateTime = {0, 0, 0};     //年、月、日
        public string address = null;
        public string cusName = null;
        public int cusID = 0;
        public List<OrderItem> orderItems = new List<OrderItem>();        //订单明细
        public double OrderPrice       //订单总价值
        {
            get
            {
                double sum = 0;
                foreach(OrderItem orderItem in orderItems)
                {
                    //价格 = 单价 * 货物数量
                    sum += orderItem.goodsPrice * orderItem.goodsNum;
                }
                return sum;
            }
        }

        public Order() { }
        public Order(int orderID, int[] dateTime, string address, string cusName, int cusID)
        {
            this.address = address;
            this.dateTime = dateTime;
            this.orderID = orderID;
            this.cusName = cusName;
            this.cusID = cusID;
        }

        //增加订单明细
        public void AddOrderItem(OrderItem orderItem)
        {
            orderItems.Add(orderItem);
        }

        public override string ToString()   //重写ToString
        {
            return "订单号为：" + orderID + "\n订单日期为；" + dateTime[0] + "-" + dateTime[1] + "-" + dateTime[2] + "\n地址为：" + address + "\n顾客姓名为：" + cusName + "\n顾客ID为：" + cusID + "\n";
        }

        public override bool Equals(object obj)    //重写Equals
        {
            Order order = obj as Order;
            if (order == null) return false;
            return this.orderID == orderID;
        }
        public override int GetHashCode()
        {
            return (orderID != null ? StringComparer.InvariantCulture.GetHashCode(orderID) : 0);
        }
    }
}
