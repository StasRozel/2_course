namespace лаба__15
{
    class Program
    {
        static void Eratosthenes(int n)
        {
            Dictionary<bool, int> numbers = new Dictionary<bool, int>();


            for (int i = 2; i <= n; i++) {
                numbers[true] = i;
            }

            foreach (var item in numbers)
                Console.WriteLine(item);

            int j = 0;
            foreach (var item in numbers)
            {
                int p = item.Value;

                foreach (var item1 in numbers)
                {
                    int num = item1.Value;
                    if (num % p == 0)
                    {
                        item1[false] = false;
                    }
                }
            }
            Console.WriteLine("-----------------------------------------");

            foreach (var item in numbers)
                Console.WriteLine(item);

        }
        static void Main(string[] args)
        {
            Eratosthenes(100);
        }
    }
}