using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace лаба__7
{
    internal class CustomList<T> : IList<T> where T : struct
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
            try
            {
                string type = element.GetType().Name;
                if (type == "Int32" || type == "String")
                {
                    data.Add(element);
                } else
                {
                    throw new Exception("Ошибка: можно ввести только int или string");
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);   
            }
            
        }

        public void Delete(int index) {
            try
            {
                if (index.GetType().Name == "Int32")
                {
                    data.RemoveAt(index);
                } else
                {
                    throw new IndexOutOfRangeException();
                }
            } catch (IndexOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void Print()
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            string info = "";
    
            foreach (var item in data)
            {
                info += item + " ";
            }
           
            return info;
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

        //public Production production = new Production("Integral");

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
