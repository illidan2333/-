using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._28test
{
    class Node<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList() { head = tail = null; }
        public Node<T> Head { get => head; }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            for (Node<T> x = head; x != null; x = x.Next)
            {
                action(x.Data);
            }
        }
    }
}
