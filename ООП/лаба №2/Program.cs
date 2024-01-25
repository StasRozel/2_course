namespace lab__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product telefon = new Product("Телефон", 542123, 451, "до победы", 100);
            Product tablet = new Product("Планшет", 542233, 600, "до конца", 70);

            tablet.SetPrice = 1200;

            var holodos = new Product("Холодильник Atlant", 532453, 1200, "до свидания", 110);
            int result;
            int amount = holodos.GetAmount;
            int price = holodos.GetPrice;
            holodos.AllSum(ref amount, ref price, out result);

            Console.WriteLine(result);

            telefon.Print();
            tablet.Print();

            Console.WriteLine(telefon.Equals(telefon));
            Console.WriteLine(tablet.GetHashCode());
            Console.WriteLine(telefon.ToString());


            Console.WriteLine("-------------------------------------------------");

            Product[] products = new Product[] {
                new Product("Ноутбук", 513423, 1330, "до начало", 65),
                new Product("Холодильник", 513423, 1330, "до конца", 65),
                new Product("Холодильник", 51223, 3300, "до конца", 45),
                new Product("Мышка", 513423, 1330, "до конца", 65)
            };

            Console.WriteLine(Product.PrintCounter());
            foreach (Product product in products)
            {
                if (product.Find("Мышка"))
                {
                    product.Print();
                }

                if (product.FindAndPrice("Холодильник", 4400))
                {
                    product.Print();
                }
                
            }

            
        }
    }
}