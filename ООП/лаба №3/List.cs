using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace лаба__3
{
    internal class CustomList<T>
    {
        public List<T> data;

        public CustomList()
        {
            data = new List<T>();
        }

        private CustomList(List<T> data)
        {
            this.data = data;
        }

        public void AddElement(T element)
        {
            data.Add(element);
        }

        public void Display()
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private void RemoveAtElement(int index) 
        {
            data.RemoveAt(index);
        }

        private void InsertBeginElement(int index, T item)
        {
            data.Insert(index, item);
        }

        private void JoinLists(CustomList<T> list)
        {
            foreach (var item in list.data)
            {
                this.data.Add(item);
            }
        }

        public static CustomList<T> operator *(CustomList<T> counter1, CustomList<T> counter2)
        {
            counter1.JoinLists(counter2);
            return new CustomList<T>(counter1.data);
        }

        public static CustomList<T> operator +(CustomList<T> counter1, T item)
        {
            counter1.InsertBeginElement(0, item);
            return new CustomList<T>(counter1.data);
        }

        public static bool operator !=(CustomList<T> counter1, CustomList<T> counter2)
        {
            return counter1.data != counter2.data;
        }

        public static bool operator ==(CustomList<T> counter1, CustomList<T> counter2)
        {
            return counter1.data == counter2.data;
        }

        public static CustomList<T> operator --(CustomList<T> counter1)
        {
            counter1.RemoveAtElement(0);
            return new CustomList<T>(counter1.data) ;
        }

        public Production production = new Production("Integral");

        class Developer
        {
            private Guid id = new Guid();
            private string fullName;
            private string department;

            public Developer(string fullNameUser, string departmentUser)
            {
                fullName = fullNameUser;
                department = departmentUser;
            }
        }


    }
}
