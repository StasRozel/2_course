﻿namespace лаба__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "s";
            Console.WriteLine(str1.GetType().Name);
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            CustomList<string> list4 = new CustomList<string>();
            list4.AddElement("hello1");
            list4.AddElement("world");
            list4.AddElement("lol");
            list4.AddElement("lol");
            list4.AddElement("hello");
            list4.AddElement("kek");

            string str = "Hello world Hello LOL lol Kek";

            list.AddElement(1);
            list2.AddElement(1);
            list2.AddElement(2);
            list2.AddElement(3);
            list2.AddElement(4);
            list3.AddElement(5);
            list3.AddElement(6);
            list3.AddElement(7);
            list.Print();
            list2.Print();
            --list2;
            list2 = list2 + 5;
            list2.Print();
            list2 = list2 * list3;
            list2.Print();

            Console.WriteLine(list != list2);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(StatisticOperation.Sum());
            Console.WriteLine(StatisticOperation.MinMax());
            Console.WriteLine(StatisticOperation.CountElement());
            Console.WriteLine(str.CharCount());
            
            Console.WriteLine(list4.CheckElementDouble());
            Console.WriteLine("-----------------------------------------");

            File.AppendAllText("info.txt", list4.ToString());

            string fileInfo = File.ReadAllText("info.txt");

            Console.WriteLine(fileInfo);

            Console.WriteLine("-----------------------------------------");

            
        }
    }
}