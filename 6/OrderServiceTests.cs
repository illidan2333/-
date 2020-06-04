using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddOrderTest()
        {
            Order order = new Order(1, DateTime.Now, "1", "1");
            List<Order> testsOrders = new List<Order>();
            testsOrders.Add(order);
            OrderService.AddOrder(order);
            CollectionAssert.AreEqual(testsOrders, OrderService.orders);
        }

        [TestMethod()]
        public void AddOrderItemTest()
        {
            Order order = new Order(1, DateTime.Now, "1", "1");
            Order testOrder = new Order(1, DateTime.Now, "1", "1");
            OrderItem orderItem = new OrderItem("1", 1, 1);
            testOrder.orderItems.Add(orderItem);
            OrderService.AddOrderItem(order, orderItem);
            Assert.AreEqual(testOrder, order);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            Order order = new Order(1, DateTime.Now, "1", "1");
            OrderService.orders.Add(order);
            bool isOk = OrderService.DeleteOrder(1);
            Assert.IsTrue(isOk);
            Assert.AreEqual(OrderService.orders.Count, 0);
        }



        [TestMethod()]
        public void DeleteOrderTest1()
        {
            Order order = new Order(1, DateTime.Now, "1", "1");
            OrderService.orders.Add(order);
            bool isOk = OrderService.DeleteOrder(2);
            Assert.IsFalse(isOk);
            Assert.AreEqual(OrderService.orders.Count, 1);
        }

        [TestMethod()]
        public void ModifyOrderTest()
        {
            Order oldOrder = new Order(1, DateTime.Now, "1", "1");
            Order newOrder = new Order(2, DateTime.Now, "1", "1");
            List<Order> testOrders = new List<Order>();
            OrderService.orders.Add(oldOrder);
            testOrders.Add(newOrder);
            OrderService.ModifyOrder(1, newOrder);
            CollectionAssert.AreEqual(testOrders, OrderService.orders);
        }

        [TestMethod()]
        public void ModifyOrderTest1()
        {
            Order oldOrder = new Order(1, DateTime.Now, "1", "1");
            Order newOrder = new Order(2, DateTime.Now, "1", "1");
            List<Order> testOrders = new List<Order>();
            OrderService.orders.Add(oldOrder);
            testOrders.Add(oldOrder);
            OrderService.ModifyOrder(2, newOrder);
            CollectionAssert.AreEqual(testOrders, OrderService.orders);
        }

        [TestMethod()]
        public void EnquiryOrderTest()
        {
            Order order = new Order(1, DateTime.Now, "1", "1");
            Order enquiriedOrder;
            OrderService.orders.Add(order);
            bool isOk = OrderService.EnquiryOrder(1, out enquiriedOrder);
            Assert.IsTrue(isOk);
            Assert.AreEqual(order, enquiriedOrder);
        }

        [TestMethod()]
        public void EnquiryOrderTest1()
        {
            Order order = new Order(1, DateTime.Now, "1", "1");
            Order enquiriedOrder;
            OrderService.orders.Add(order);
            bool isOk = OrderService.EnquiryOrder(2, out enquiriedOrder);
            Assert.IsFalse(isOk);
            Assert.IsNull(enquiriedOrder);
        }

        [TestMethod()]
        public void EnquiryOrderByItemTest()
        {
            Order order = new Order(1, DateTime.Now, "1", "1");
            OrderItem orderItem = new OrderItem("1", 1, 1);
            order.orderItems.Add(orderItem);
            OrderService.orders.Add(order);
            List<Order> enquiriedOrders = new List<Order>();
            bool isOk;
            enquiriedOrders = OrderService.EnquiryOrderByItem("1", out isOk);
            Assert.IsTrue(isOk);
            CollectionAssert.AreEqual(enquiriedOrders, OrderService.orders);
        }

        [TestMethod()]
        public void EnquiryOrderByItemTest1()
        {
            Order order = new Order(1, DateTime.Now, "1", "1");
            OrderItem orderItem = new OrderItem("1", 1, 1);
            order.orderItems.Add(orderItem);
            OrderService.orders.Add(order);
            List<Order> enquiriedOrders = new List<Order>();
            bool isOk;
            enquiriedOrders = OrderService.EnquiryOrderByItem("2", out isOk);
            Assert.IsFalse(isOk);
            CollectionAssert.AreNotEqual(enquiriedOrders, OrderService.orders);
        }

        [TestMethod()]
        public void EnquiryOrderByCustomerTest()
        {
            Order order = new Order(1, DateTime.Now, "1", "1");
            OrderItem orderItem = new OrderItem("1", 1, 1);
            order.orderItems.Add(orderItem);
            OrderService.orders.Add(order);
            List<Order> enquiriedOrders = new List<Order>();
            bool isOk;
            enquiriedOrders = OrderService.EnquiryOrderByCustomer("1", out isOk);
            Assert.IsTrue(isOk);
            CollectionAssert.AreEqual(enquiriedOrders, OrderService.orders);
        }

        [TestMethod()]
        public void EnquiryOrderByCustomerTest1()
        {
            Order order = new Order(1, DateTime.Now, "1", "1");
            OrderItem orderItem = new OrderItem("1", 1, 1);
            order.orderItems.Add(orderItem);
            OrderService.orders.Add(order);
            List<Order> enquiriedOrders = new List<Order>();
            bool isOk;
            enquiriedOrders = OrderService.EnquiryOrderByItem("2", out isOk);
            Assert.IsFalse(isOk);
            CollectionAssert.AreNotEqual(enquiriedOrders, OrderService.orders);
        }

        [TestMethod()]
        public void SortedByOrderIDTest()
        {
            Order order1 = new Order(1, DateTime.Now, "1", "1");
            Order order2 = new Order(2, DateTime.Now, "1", "1");
            Order order3 = new Order(3, DateTime.Now, "1", "1");
            OrderService.orders.Add(order2);
            OrderService.orders.Add(order1);
            OrderService.orders.Add(order3);
            List<Order> testOrders = new List<Order>();
            testOrders.Add(order1);
            testOrders.Add(order2);
            testOrders.Add(order3);
            OrderService.SortedByOrderID();
            CollectionAssert.AreEqual(testOrders, OrderService.orders);
        }

        [TestMethod()]
        public void ExportTest()
        {
            Order order = new Order(1, DateTime.Now, "1", "1");
            OrderItem orderItem = new OrderItem("1", 1, 1);
            order.orderItems.Add(orderItem);
            OrderService.orders.Add(order);
            try
            {
                OrderService.Export();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void ImportTest()
        {
            try
            {
                OrderService.Import();
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}