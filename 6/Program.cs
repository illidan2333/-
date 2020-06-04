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

namespace OrderWork
{
    class Program
    {
        static void Main(string[] arg)
        {
            int orderID = 113;
            int[] dateTime = { 2020, 4, 10 };     //年、月、日
            string address = "qwe";
            string cusName = "azar";
            int cusID = 0;
            Order od = new Order(orderID, dateTime, address, cusName, cusID);
            Order od2 = new Order(147, dateTime, address, cusName, cusID);

            string goodsName = "goods";
            int goodsPrice = 517;
            int goodsNum = 100;
            OrderItem odi = new OrderItem(goodsName, goodsPrice, goodsNum);
            OrderItem odi2 = new OrderItem("aaa", 400, 414);

            //清空
            od.orderItems.Clear();
            od2.orderItems.Clear();

            od.orderItems.Add(odi);
            od.orderItems.Add(odi2);
            od2.orderItems.Add(odi);
            od2.orderItems.Add(odi2);
            OrderService os = new OrderService();

            //清空
            os.orders.Clear();

            //加入订单操作
            Console.WriteLine("加入订单操作：");
            os.AddOrder(od);
            os.AddOrder(od2);
            Console.WriteLine("测试AddOrder方法：\n");
            foreach (Order i in os.orders)
            {
                Console.WriteLine(i.ToString());
                foreach (OrderItem j in od.orderItems)
                {
                    Console.WriteLine(j.ToString());
                }
            }
            Console.WriteLine("——加入订单操作结束——");
            Console.WriteLine("————————————————\n");

            //删除订单操作
            Console.WriteLine("删除订单操作：");
            os.DeletOrder(113);
            Console.WriteLine("测试DeletOrder方法：\n");
            foreach (Order i in os.orders)
            {
                Console.WriteLine(i.ToString());
                foreach (OrderItem j in od.orderItems)
                {
                    Console.WriteLine(j.ToString());
                }
            }
            Console.WriteLine("——删除订单操作结束——");
            Console.WriteLine("————————————————\n");

            //查询订单操作
            Console.WriteLine("查询订单操作：");
            Console.WriteLine("测试QuetyOrder方法：\n");
            os.QueryOrder(147);
            Console.WriteLine("——查询订单操作结束——");
            Console.WriteLine("————————————————\n");
            Console.Read();
            Console.WriteLine(os.QueryLinqOrder(147));

        }
    }
}

//测试程序1
/* 测试Order和OrderItem
 * 
            int orderID = 113;
            int[] dateTime = { 2020, 4, 10 };     //年、月、日
            string address = null;
            string cusName = null;
            int cusID = 0;
            Order od = new Order(orderID, dateTime, address, cusName, cusID);
            Order od2 = new Order(112, dateTime, address, cusName, cusID);
            Console.WriteLine(od.ToString());
            Console.WriteLine("od ==? od2 :" + od.Equals(od2));

            string goodsName = "goods";
            int goodsPrice = 517;
            int goodsNum = 100;
            OrderItem odi = new OrderItem(goodsName, goodsPrice, goodsNum);
            OrderItem odi2 = new OrderItem(666, goodsPrice, goodsNum);
            Console.WriteLine(odi.ToString());
            Console.WriteLine("odi ==? odi2: " + odi.Equals(odi2));

            Console.Read(); 
 */

//测试程序 --- AddOrder()
/*
           int orderID = 113;
            int[] dateTime = { 2020, 4, 10 };     //年、月、日
            string address = null;
            string cusName = null;
            int cusID = 0;
            Order od = new Order(orderID, dateTime, address, cusName, cusID);

            string goodsName = "goods";
            int goodsPrice = 517;
            int goodsNum = 100;
            OrderItem odi = new OrderItem(goodsName, goodsPrice, goodsNum);

            od.orderItems.Add(odi);
            OrderService os = new OrderService();
            os.AddOrder(od, od.orderItems);
            Console.WriteLine("测试AddOrder方法：\n");
            foreach(Order i in os.orders)
            {
                foreach(OrderItem j in od.orderItems)
                {
                    Console.WriteLine(i.ToString());
                    Console.WriteLine(j.ToString());
                }
            }

            Console.Read();
*/


//测试层序——DeletOrder()
/*
            int orderID = 113;
            int[] dateTime = { 2020, 4, 10 };     //年、月、日
            string address = "qwe";
            string cusName = "azar";
            int cusID = 0;
            Order od = new Order(orderID, dateTime, address, cusName, cusID);
            Order od2 = new Order(147, dateTime, address, cusName, cusID);

            string goodsName = "goods";
            int goodsPrice = 517;
            int goodsNum = 100;
            OrderItem odi = new OrderItem(goodsName, goodsPrice, goodsNum);
            OrderItem odi2 = new OrderItem("aaa", 400, 414);

            //清空
            od.orderItems.Clear();
            od2.orderItems.Clear();

            od.orderItems.Add(odi);
            od.orderItems.Add(odi2);
            od2.orderItems.Add(odi);
            od2.orderItems.Add(odi2);
            OrderService os = new OrderService();

            //清空
            os.orders.Clear();

            //加入订单操作
            Console.WriteLine("加入订单操作：");
            os.AddOrder(od, od.orderItems);
            os.AddOrder(od2, od2.orderItems);
            Console.WriteLine("测试AddOrder方法：\n");
            foreach (Order i in os.orders)
            {
                Console.WriteLine(i.ToString());
                foreach (OrderItem j in od.orderItems)
                {
                    Console.WriteLine(j.ToString());
                }
            }
            Console.WriteLine("——加入订单操作结束——");
            Console.WriteLine("————————————————\n");

            //删除订单操作
            Console.WriteLine("删除订单操作：");
            os.DeletOrder(113);
            Console.WriteLine("测试DeletOrder方法：\n");
            foreach (Order i in os.orders)
            {
                Console.WriteLine(i.ToString());
                foreach (OrderItem j in od.orderItems)
                {
                    Console.WriteLine(j.ToString());
                }
            }
            Console.WriteLine("——删除订单操作结束——");
            Console.WriteLine("————————————————\n");
            Console.Read();

 */

//测试程序——QueryOrder()
/*
            int orderID = 113;
            int[] dateTime = { 2020, 4, 10 };     //年、月、日
            string address = "qwe";
            string cusName = "azar";
            int cusID = 0;
            Order od = new Order(orderID, dateTime, address, cusName, cusID);
            Order od2 = new Order(147, dateTime, address, cusName, cusID);

            string goodsName = "goods";
            int goodsPrice = 517;
            int goodsNum = 100;
            OrderItem odi = new OrderItem(goodsName, goodsPrice, goodsNum);
            OrderItem odi2 = new OrderItem("aaa", 400, 414);

            //清空
            od.orderItems.Clear();
            od2.orderItems.Clear();

            od.orderItems.Add(odi);
            od.orderItems.Add(odi2);
            od2.orderItems.Add(odi);
            od2.orderItems.Add(odi2);
            OrderService os = new OrderService();

            //清空
            os.orders.Clear();

            //加入订单操作
            Console.WriteLine("加入订单操作：");
            os.AddOrder(od, od.orderItems);
            os.AddOrder(od2, od2.orderItems);
            Console.WriteLine("测试AddOrder方法：\n");
            foreach (Order i in os.orders)
            {
                Console.WriteLine(i.ToString());
                foreach (OrderItem j in od.orderItems)
                {
                    Console.WriteLine(j.ToString());
                }
            }
            Console.WriteLine("——加入订单操作结束——");
            Console.WriteLine("————————————————\n");

            //删除订单操作
            Console.WriteLine("删除订单操作：");
            os.DeletOrder(113);
            Console.WriteLine("测试DeletOrder方法：\n");
            foreach (Order i in os.orders)
            {
                Console.WriteLine(i.ToString());
                foreach (OrderItem j in od.orderItems)
                {
                    Console.WriteLine(j.ToString());
                }
            }
            Console.WriteLine("——删除订单操作结束——");
            Console.WriteLine("————————————————\n");

            //查询订单操作
            Console.WriteLine("查询订单操作：");
            Console.WriteLine("测试QuetyOrder方法：\n");
            os.QueryOrder(147);
            Console.WriteLine("——查询订单操作结束——");
            Console.WriteLine("————————————————\n");
            Console.Read();
 */

//测试程序——RevisedOrder()
/*
            int orderID = 113;
            int[] dateTime = { 2020, 4, 10 };     //年、月、日
            string address = "qwe";
            string cusName = "azar";
            int cusID = 0;
            Order od = new Order(orderID, dateTime, address, cusName, cusID);
            Order od2 = new Order(147, dateTime, address, cusName, cusID);

            string goodsName = "goods";
            int goodsPrice = 517;
            int goodsNum = 100;
            OrderItem odi = new OrderItem(goodsName, goodsPrice, goodsNum);
            OrderItem odi2 = new OrderItem("aaa", 400, 414);

            //清空
            od.orderItems.Clear();
            od2.orderItems.Clear();

            od.orderItems.Add(odi);
            od.orderItems.Add(odi2);
            od2.orderItems.Add(odi);
            od2.orderItems.Add(odi2);
            OrderService os = new OrderService();

            //清空
            os.orders.Clear();

            //加入订单操作
            Console.WriteLine("加入订单操作：");
            os.AddOrder(od, od.orderItems);
            os.AddOrder(od2, od2.orderItems);
            Console.WriteLine("测试AddOrder方法：\n");
            foreach (Order i in os.orders)
            {
                Console.WriteLine(i.ToString());
                foreach (OrderItem j in od.orderItems)
                {
                    Console.WriteLine(j.ToString());
                }
            }
            Console.WriteLine("——加入订单操作结束——");
            Console.WriteLine("————————————————\n");

            //删除订单操作
            Console.WriteLine("删除订单操作：");
            os.DeletOrder(113);
            Console.WriteLine("测试DeletOrder方法：\n");
            foreach (Order i in os.orders)
            {
                Console.WriteLine(i.ToString());
                foreach (OrderItem j in od.orderItems)
                {
                    Console.WriteLine(j.ToString());
                }
            }
            Console.WriteLine("——删除订单操作结束——");
            Console.WriteLine("————————————————\n");

            //查询订单操作
            Console.WriteLine("查询订单操作：");
            Console.WriteLine("测试QuetyOrder方法：\n");
            os.QueryOrder(147);
            Console.WriteLine("——查询订单操作结束——");
            Console.WriteLine("————————————————\n");

            //修改订单操作
            Console.WriteLine("修改订单操作：");
            os.RevisedOrder(147);
            Console.WriteLine("测试RevisedOrder方法：\n");
            foreach (Order i in os.orders)
            {
                Console.WriteLine(i.ToString());
                foreach (OrderItem j in od.orderItems)
                {
                    Console.WriteLine(j.ToString());
                }
            }
            Console.WriteLine("——修改订单操作结束——");
            Console.WriteLine("————————————————\n");

            Console.Read();
 */

//最终程序——
/*
            Console.WriteLine("这是一个订单增删查改控制台程序！");
            Console.WriteLine("规则：通过订单服务，先增加订单，再通过订单服务里的修改服务，向订单增加货物");
            Console.WriteLine("——————启动————————");
            Console.WriteLine("1.增加订单\t2.删除订单\t3.查询订单\t4.修改订单\t5.显示目前所有订单\t6.显示订单总价值\t0.退出");
            OrderService ods = new OrderService();
            int go = 1;     //用来控制while语句
            while(go == 1)
            {
                Console.WriteLine("请输入：");
                string b = Console.ReadLine();
                switch(b)
                {
                    case "0":
                        go = 0;
                        break;
                    case "1":
                        Order od = new Order();
                        Console.WriteLine("请依次输入：（订单号、订单时间、订单地址、订单顾客、订单货物");
                        Console.WriteLine("请输入订单号：");
                        od.orderID = int.Parse(Console.ReadLine());
                        Console.WriteLine("订单时间：(年月日)");
                        od.dateTime[0] = int.Parse(Console.ReadLine());
                        od.dateTime[1] = int.Parse(Console.ReadLine());
                        od.dateTime[2] = int.Parse(Console.ReadLine());
                        Console.WriteLine("订单地址：");
                        od.address = Console.ReadLine();
                        Console.WriteLine("订单顾客：（姓名， ID）");
                        od.cusName = Console.ReadLine();
                        od.cusID = int.Parse(Console.ReadLine());
                        Console.WriteLine("订单货物：（货物名称、货物价格、货物数量）");
                        OrderItem odi = new OrderItem();
                        //一个订单可以有多个货物
                        int go2 = 1;   //控制while循环
                        while(go2 == 1)
                        {
                            Console.Write("请输入：");
                            Console.WriteLine("请输入货物名称：");
                            odi.goodsName = Console.ReadLine();
                            Console.WriteLine("请输入货物价格：");
                            odi.goodsPrice = double.Parse(Console.ReadLine());
                            Console.WriteLine("请输入货物数量：");
                            odi.goodsNum = int.Parse(Console.ReadLine());
                            od.orderItems.Add(odi);

                            Console.WriteLine("按下1继续向该订单增加货物\n按下0则不再向该订单增加货物");
                            go2 = int.Parse(Console.ReadLine());
                        }
                        ods.AddOrder(od);
                        break;
                    case "2":   //删除订单
                        Console.WriteLine("请输入所要删除的订单的订单号：");
                        int deletOrderID = int.Parse(Console.ReadLine());
                        ods.DeletOrder(deletOrderID);
                        break;
                    case "3":      //查询订单
                        Console.WriteLine("请输入你要查询的订单号：");
                        int newOrderID2 = int.Parse(Console.ReadLine());
                        ods.QueryOrder(newOrderID2);
                        break;
                    case "4":       //修改订单
                        Console.WriteLine("请输入你要修改的订单号：");
                        int newOrderID3 = int.Parse(Console.ReadLine());
                        ods.RevisedOrder(newOrderID3);
                        break;
                    case "5":
                        Console.WriteLine("显示当前所有订单号：");
                        ods.AllOrders();
                        break;
                    case "6":
                        double allPrice = 0;
                        foreach(Order od2 in ods.orders)
                        {
                            allPrice += od2.OrderPrice;
                        }
                        Console.WriteLine("显示订单的总价值：" + allPrice);
                        break;
 */
