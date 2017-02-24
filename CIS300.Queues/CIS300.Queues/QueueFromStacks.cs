using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS300.Queues
{
    public class QueueFromStacks<T> : IQueue<T>
    {
        private Stack<T> _oldElem, _newElem;

        public QueueFromStacks()
        {
            _oldElem = new Stack<T>();
            _newElem = new Stack<T>();
        }
        
        public int Count
        {
            get
            {
                return _oldElem.Count + _newElem.Count;
            }
        }

        public T Dequeue()
        {
            if(_oldElem.Count > 0)
            {
                return _oldElem.Pop();
            }
            else
            {
                while(0 < _newElem.Count)
                {
                    _oldElem.Push(_newElem.Pop());
                }
               return _oldElem.Pop();
            }
        }

        public void Enqueue(T val)
        {
            _newElem.Push(val);
        }

        public T Peek()
        {
            if (_oldElem.Count > 0)
            {
               return  _oldElem.Peek();
            }
            else
            {
                while (0 < _newElem.Count)
                {
                    _oldElem.Push(_newElem.Pop());
                }
                return _oldElem.Peek();
            }
        }
    }
}
