using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__8
{
    class Programmer
    {
       public delegate void DeleteBeginAndEndElement(string? message);
       public delegate void RandomLineMovement(string? message);
        
       public event DeleteBeginAndEndElement? DeleteEvent;
       public event RandomLineMovement? MutationEvent;
        
       public void DeleteBegin(List<string> str)
       {
            str.RemoveAt(0);
            DeleteEvent?.Invoke("Удален первый элемент");
       }

        public void DeleteEnd(List<string> str)
        {
            str.RemoveAt(str.Count-1);
            DeleteEvent?.Invoke("Удален последний элемент");
        }

        public void Mutation(List<string> str, int index, string newStr)
        {
            str[index] = newStr;
            MutationEvent?.Invoke($"Замена {index} строки");
        }

    }
}
