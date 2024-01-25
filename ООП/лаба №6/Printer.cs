using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__4
{
    public interface IPrintable
    {
        string ToString();
    }


    class Printer
    {
        public void IAmPrinting(IPrintable obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
