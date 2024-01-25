using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace лаба__9
{

    class Program
    {

        static void Main(string[] args)
        {

            string[] namesGamers = { "Stas", "Matwey", "Vlad", "Lexa", "Maksim" };

            var games = new BlockingCollection<Game>(10);

            for (int i = 0; i < 5; i++)
            {
                games.Add(new Game(namesGamers[i]));
            }

            Console.WriteLine("Вывод всей коллекции: ");

            foreach (var item in games)
            {
                Console.WriteLine(item.nameCharaster);
            }

            Console.WriteLine("Вывод искомого элемента: ");

            foreach (var item in games)
            {
                if ("Vlad" == item.nameCharaster)
                {
                    Console.WriteLine(item.nameCharaster);
                }
            }

            Console.WriteLine("Вывод удаленного элемента: ");
            int j = 0;
            while (j <= games.Count)
            {
                var item = games.Take();

                if (item.nameCharaster == "Lexa")
                {
                    Console.WriteLine(item.nameCharaster);
                }
                else
                {
                    games.Add(item);
                }

                j++;
            }

            Console.WriteLine("______________2___________");

            ArrayList arr = new ArrayList() { 1, 's', "string", 5.2, "...", 12, 11 };

            arr.Print();

            arr.DeleteN(0, 4);

            Console.WriteLine("После удаления: ");

            arr.Print();

            arr.Insert(2, "Stas");

            arr.AddRange(games);

            arr.Print();

            List<Game> list = new List<Game>();
            int amount = games.Count;

            for (int i = 0; i < amount; i++)
            {
                Game item;
                games.TryTake(out item);
                list.Add(item);
            }

            list.ForEach(item => { Console.WriteLine(item.nameCharaster); });

            Console.WriteLine("_____________3___________");

            ObservableCollection<Game> people = new ObservableCollection<Game>();

            people.CollectionChanged += SuccessfulWithDrawal;

            void SuccessfulWithDrawal(object? sender, NotifyCollectionChangedEventArgs e)
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        Console.WriteLine("Элемент добавлен");
                        break;
                    case NotifyCollectionChangedAction.Remove:
                        Console.WriteLine("Элемент удален");
                        break;
                    case NotifyCollectionChangedAction.Replace:
                        Console.WriteLine("Элемент изменен");
                        break;
                }
            };

            people.Add(new Game(namesGamers[0]));
            people.Add(new Game(namesGamers[1]));
            people.Add(new Game(namesGamers[2]));

            foreach (var item in people)
            {
                Console.WriteLine(item.nameCharaster);
            }

            people.RemoveAt(1);

            foreach (var item in people)
            {
                Console.WriteLine(item.nameCharaster);
            }
        }
    }
}