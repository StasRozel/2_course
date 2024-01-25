using System;

namespace лаба__7
{
    static class StatisticOperation
    {
        static CustomList<int> list = new CustomList<int>();

        static CustomList<int> AddedElements()
        {
            for (int i = 0; i < 10; i++)
            {
                list.AddElement(i);
            }

            return list;
        }

        public static int Sum()
        {
            StatisticOperation.AddedElements();
            int sum = 0;
            foreach (var item in list.data) 
            {
                sum += item;
            }
            return sum;
        }

        public static int MinMax()
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (var item in list.data)
            {
                if (min > item)
                {
                    min = item;
                }
                if (max < item)
                {
                    max = item;
                }
            }

            return max-min;
        }

        public static int CountElement()
        {
            return list.data.Count;
        }

        public static int CharCount(this string str)
        {
            int counter = 0;

            string[] words = str.Split(' ');

            foreach (string word in words)
            {
                if(!Char.IsLower(word[0]))
                {
                    counter++;
                }
            }

            return counter;
        }

        public static bool CheckElementDouble(this CustomList<string> str)
        {

            for (int i = 0; i < str.data.Count; i++)
            {
               for (int j = 1 + i; j < str.data.Count; j++)
                {
                    if (str.data[i] == str.data[j])
                    {
                        return true;
                    }
                    
                }
            }

            return false;
        }
    }
}
