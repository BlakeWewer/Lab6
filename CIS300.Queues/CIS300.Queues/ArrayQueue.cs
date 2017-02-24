using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS300.Queues
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private T[] _arr = new T[10];
        private int _front = 0;
        private int _size = 0;

        public ArrayQueue()
        {

        }

        public int Count
        {
            get
            {
                return _size;
            }
        }
        private void Resize()
        {
            T[] big = new T[2 * _arr.Length];
            //copy from _front into the first half of big
            Array.Copy(_arr, _front, big, 0, _arr.Length - _front);
            //copy from spot 0 in _arr into the second half of big
            Array.Copy(_arr, 0, big, _arr.Length - _front, _front);
            _front = 0;
        }
        public void Enqueue(T val)
        {
            //resize if necessary
            if (_arr.Length == _size) Resize();
            //add new element
            int back = (_front + _size) % _arr.Length;
            _arr[back] = val;
            _size++;
        }
        public T Dequeue()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException();
            }
            //index 0 is the front of the queue
            T val = _arr[_front];
            _arr[_front] = default(T);
            _front++;
            _size--;
            if (_front == _arr.Length)
            {
                _front = 0;
            }
            return val;
        }
        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException();
            }
            return _arr[_front];
        }
    }

}
