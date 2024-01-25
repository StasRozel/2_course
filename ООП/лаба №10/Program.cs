namespace лаба__10
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] month = { "Januar", "Februar", "March",
                               "April", "May", "June",
                               "Jule", "August", "September",
                               "October", "November", "December" };

            var monthNLength = from m in month
                               where m.Length == 4
                               select m;

            Console.WriteLine("Сортировка по количеству символов: ");
            foreach (var item in monthNLength)
            {
                Console.WriteLine(item);
            }

            var monthOrdered = from m in month
                               orderby m
                               select m;

            Console.WriteLine("Вывод в алфавитном порядке: ");
            foreach (var item in monthOrdered)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Только месяцы зимы и лета");
            var zimaLeto = month.Where(p => p == "Januar" || p == "Februar" || p == "December" || p == "June" || p == "Jule" || p == "August");

            foreach (var item in zimaLeto)
            {
                Console.WriteLine(item);
            }

            var monthCheckedU = from m in month
                                where m.Length >= 4 && m.Contains("u")
                                select m;

            Console.WriteLine("Сортирвка по длине больше 4 и есть ли бувка u: ");
            foreach (var item in monthCheckedU)
            {
                Console.WriteLine(item);
            }

            List<Product> products = new List<Product>
            {
                new Product("Бумага", "ООО Бумага", 576575, 120, "нет", 140),
                new Product("Бумага", "ООО Бумага", 576576, 140, "нет", 120),
                new Product("Бумага", "ООО Бумага", 576576, 160, "нет", 150),
                new Product("Тетради", "ООО Бумага", 576577, 10, "нет", 350),
                new Product("Колбаса", "Ферма", 576080, 80, "месяц", 150),
                new Product("Колбаса Высший сорт", "Ферма", 576435, 90, "месяц", 150),
                new Product("Чипсы. С сметаной и зеленью", "Lays", 576123, 40, "12 месяцев", 200),
                new Product("Чипсы. С сыром", "Lays", 576323, 40, "12 месяцев", 200),
                new Product("Холодильник" , "Atlant", 576201, 1340, "нет", 50),
                new Product("Конфеты", "Коммунарка", 576875, 30, "2 месяца", 340),
                new Product("Наушники", "MI", 576575, 120, "нет", 100),
            };

            List<Product> productNew = new List<Product>()
            {
                new Product("Хлеб", "ХлебЗавод", 576435, 20, "3 суток", 300),
                new Product("Масло", "Молочный завод", 576323, 30, "2 недели", 300),

            };

            var productSort = from m in products
                              orderby m.GetName
                              select m;

            Console.WriteLine("Вывод в алфавитном порядке: ");
            foreach (var item in productSort)
            {
                Console.WriteLine(item.GetName);
            }

            var chekedProductAll = products.All(x => x.GetPrice > 52);

            Console.WriteLine("Проверка, все ли элементы подходят по условию: ");
            Console.WriteLine(chekedProductAll);

            Console.WriteLine("Вывод одного наименования: ");

            var printProductByName = products
                .Where(p => p.GetName == "Бумага");

            foreach (var item in printProductByName)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Вывод одного наименования с ценой не превышающий заданную: ");
            var printProductByNameAndPrice = products.Where(p => p.GetName == "Бумага" && p.GetPrice < 141);

            foreach (var item in printProductByNameAndPrice)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Вывод элементов с ценой не превышающий заданную: ");

            var printProductByPrice = products.Where(p => p.GetPrice < 120);

            foreach (var item in printProductByPrice)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Максимальная цена: ");
            var printProductMaxPrice = products.Max(p => p.GetPrice);

            Console.WriteLine(printProductMaxPrice);

            Console.WriteLine("Сортировка по производителю и количеству: ");

            var printProductByProducer = products
                                            .OrderBy(p => p.GetProducer)
                                            .ThenBy(p => p.GetAmount);

            foreach (var item in printProductByProducer)
            {
                Console.WriteLine(item.ToString());
            }

            var megaRequest = from p in products
                              where p.GetName != "Бумага"
                              orderby p.GetPrice
                              group p by p.GetProducer;
            // select p;

            foreach (var item in megaRequest)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine("Вывод элементов c заменой параметров по совпавшим UPC: ");
            var joinProduct = from pN in productNew
                              join p in products on pN.GetUpc equals p.GetUpc
                              select new 
                              { 
                                  Name = pN.GetName, 
                                  Producer = pN.GetProducer, 
                                  UPC = p.GetUpc, 
                                  Price = pN.GetPrice, 
                                  ShelfLife = pN.GetShelfLife, 
                                  Amount = pN.GetAmount 
                              };

            foreach (var item in joinProduct) {
                Console.WriteLine(item.ToString());
            }
        }
    }
}