using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS300.Queues
{
    public interface IQueue<T>
    {
        void Enqueue(T val);
        T Dequeue();
        T Peek();
        int Count
        {
            get;
        }
    }
}
