using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS300.Queues
{
    public class LinkedQueue<T> : IQueue<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _size;

        public LinkedQueue()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }

        public int Count
        {
            get
            {
                return _size;
            }
        }
        public void Enqueue(T val)
        {
            //create a new node
            Node<T> temp = new Node<T>(val);
            if (_size == 0)
            {
                //if the list is empty, temp is the head and tail
                _head = temp;
                _tail = temp;
            }
            else
            {
                //otherwise, add temp after the tail
                _tail.Next = temp;
                //we have a new tail
                _tail = temp;
            }
            _size++;
        }
        public T Dequeue()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException();
            }
            //get the data in the first node
            T val = _head.Data;
            //move the head down one to remove that node
            _head = _head.Next;
            //if we removed the last node, we must update tail
            if (_head == null) _tail = null;
            _size--;
            return val;
        }
        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException();
            }
            return _head.Data;
        }

        private class Node<X>
        {
            private X _data;
            private Node<X> _next;

            public Node(X data)
            {
                _data = data;
                _next = null;
            }

            public X Data
            {
                get { return _data; }
                set
                {
                    _data = value;
                }
            }

            public Node<X> Next
            {
                get { return _next; }

                set { _next = value; }
            }
        }

    }
}
