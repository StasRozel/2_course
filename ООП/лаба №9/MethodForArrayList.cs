using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__9
{
    static class MethodForArrayList
    {
        public static void Print(this ArrayList arr)
        {
            foreach (var obj in arr)
            {
                Console.WriteLine(obj);
            }
        }

        public static void DeleteN(this ArrayList arr, int start, int end)
        {
            for (int i = start; i < end - 1; i++)
            {
                arr.RemoveAt(start + 1);
            }
        }
    }
}
