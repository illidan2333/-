/*
写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、
查询订单（按照订单号、商品名称、客户等字段进行查询）功能。

提示：主要的类有Order（订单）、OrderItem（订单明细项），OrderService（订单服务），
订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。

要求：
（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


//主要实现功能，增删查改
namespace OrderWork
{
    class OrderService
    {
        public List<Order> orders = new List<Order>();

        //增加订单
        //一个订单可能包括多个货物
        public void AddOrder(Order order)
        {
            //先判断是否有相同的订单（根据订单号）
            foreach(Order od in orders)
            {
                if(od.orderID == order.orderID)
                {
                    Console.WriteLine("已经存在该订单号！");
                    Console.Read();
                    return;
                }
            }
            orders.Add(order);
        }

        //删除订单（根据订单号）
        public void DeletOrder(int odID)
        {         
            for(int i = 0; i < orders.Count; i++)
            {
                Order od = orders[i];
                if(odID == od.orderID)
                {
                    orders.Remove(od);
                    return;
                }
            }
            Console.WriteLine("无此订单号！");
            return;
        }

        //查询订单（通过订单号）  直接调用ToString方法即可
        public void QueryOrder(int odID)
        {
            foreach(Order od in orders)
            {
                if(odID == od.orderID)
                {
                    Console.WriteLine(od.ToString());
                    if(od.orderItems == null)
                    {
                        return;
                    }
                    foreach(OrderItem odi in od.orderItems)
                    {
                        Console.WriteLine(odi.ToString());
                    }
                    Console.WriteLine("总价格为：" + od.OrderPrice);
                    return;
                }
            }
            Console.WriteLine("没有查询到此订单号！");
            return;
        }

        //Linq语句
        public string QueryLinqOrder(int odID)
        {
            var od3 = from o in orders
                        where o.orderID == odID
                        select o;
            return od3.ToString();
        }

        //显示全部订单
        public void AllOrders()
        {
            Console.WriteLine("显示————————————————开始");
            foreach (Order od in orders)
            {
                Console.WriteLine(od.ToString());
                foreach(OrderItem odi in od.orderItems)
                {
                    Console.WriteLine(odi.ToString());
                }
                Console.WriteLine("————————————————————");
            }
            Console.WriteLine("显示————————————————结束");
        }

        //修改订单(通过订单号)
        public void RevisedOrder(int odID)
        {
            foreach(Order od in orders)
            {
                if(odID == od.orderID)
                {
                    Console.WriteLine("请输入你想要改的订单信息");
                    Console.WriteLine("1.订单时间\t2.订单地址\t3.订单顾客\t4.订单货物\t0.退出");
                    int go = 1;     //控制while循环
                    string key = null;
                    while(go == 1)
                    {
                        Console.Write("请输入: ");
                        key = Console.ReadLine();
                        char a = Convert.ToChar(key);
                        switch (a)
                        {
                            case '1':   //od.dateTime
                                int year = 0, month = 0, day = 0;
                                Console.WriteLine("请输入新的年-月-日");
                                year = int.Parse(Console.ReadLine());
                                month = int.Parse(Console.ReadLine());
                                day = int.Parse(Console.ReadLine());
                                od.dateTime[0] = year;
                                od.dateTime[1] = month;
                                od.dateTime[2] = day;
                                break;

                            case '2':    //od.address
                                Console.WriteLine("请输入你要修改的地址：");
                                string newAdress = Console.ReadLine();
                                od.address = newAdress;
                                break;

                            case '3':       //od.custom...
                                Console.WriteLine("请输入你要修改的顾客信息：（名称 和 ID）");
                                string newCustomName = Console.ReadLine();
                                int newCustomID = int.Parse(Console.ReadLine());
                                od.cusName = newCustomName;
                                od.cusID = newCustomID;
                                break;
                            case '4':       //货物
                                Console.WriteLine("接下来要修改货物信息\na.添加货物\tb.清空原货物\tc.删除货物\t0.退出货物选项");
                                int go2 = 1;    //作用和上面的go一样
                                while(go2 == 1)
                                {
                                    Console.Write("请输入执行货物的操作：");
                                    string b = Console.ReadLine();
                                    switch (b)
                                    {
                                        case "a":
                                            Console.WriteLine("请输入添加的货物的基本信息：（货物名称，货物价格，货物数量）");
                                            OrderItem odi;
                                            string newGoodsName = Console.ReadLine();
                                            double newGoodsPrice = double.Parse(Console.ReadLine());
                                            int newGoodsNum = int.Parse(Console.ReadLine());
                                            odi = new OrderItem(newGoodsName, newGoodsPrice, newGoodsNum);
                                            od.orderItems.Add(odi);
                                            break;
                                        case "b":
                                            od.orderItems.Clear();
                                            break;
                                        case "c":
                                            Console.WriteLine("请输入你要删除的货物名称：");
                                            string DeletGoodsName = Console.ReadLine();
                                            foreach(OrderItem odi2 in od.orderItems)
                                            {
                                                if(DeletGoodsName == odi2.goodsName)
                                                {
                                                    od.orderItems.Remove(odi2);
                                                }
                                            }
                                            break;
                                        case "0":
                                            go2 = 0;
                                            break;
                                    }
                                }
                                break;
                            case '0':
                                go = 0;
                                break;
                        }
                    }
                }
            }
            Console.WriteLine("没有该订单号，无法修改！");
            return;
        }

    }
}
