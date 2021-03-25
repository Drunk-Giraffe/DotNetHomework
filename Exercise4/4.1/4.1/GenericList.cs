using System;
using System.Collections.Generic;
using System.Text;

namespace _4._1
{
    public class GenericList<T>
    {

        protected Node<T> head;
        protected Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
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
            Node < T > n= head;
            while(n!=null)
            {
                action(n.Data);
                n = n.Next;
            }
        }
    }
}
