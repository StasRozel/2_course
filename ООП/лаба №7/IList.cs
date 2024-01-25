using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__7
{
    interface IList<T>
    {
        void AddElement(T element);
        void Delete(int index);
        void Print();
    }
}
