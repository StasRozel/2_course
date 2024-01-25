namespace лаба__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document[] documents = new Document[3];

            Receipt receipt = new Receipt();

            receipt.DocumentId = 288782365;
            receipt.Name = "Школьные товары";
            receipt.OrganizationName = "ErichKrause";
            receipt.OrganizationId = 6346341;

            receipt.day = 20;
            receipt.month = 09;
            receipt.year = 2023;

            receipt.AddProduct(100, "notepad", 20);
            receipt.AddProduct(300, "tetradka", 1);
            receipt.AddProduct(100, "ruchka", 1);
            receipt.AddProduct(100, "penal", 10);

            documents[0] = receipt;

            receipt.Print();

            Console.WriteLine("=======================================");

            Console.WriteLine(receipt.ToString());

            Console.WriteLine("\n=======================================");

            Check check = new Check();

            check.Name = "Чек продуктового магазина";
            check.AddProduct("Хлеб", 2);
            check.AddProduct("Молоко", 3);
            check.AddProduct("Батон", 1);
            check.AddProduct("Масло", 5);

            documents[1] = check;

            check.Print();

            Console.WriteLine("=======================================");

            

            Console.WriteLine("\n=======================================");

            Invoice invoice = new Invoice();

            invoice.DocumentId = 7513646;
            invoice.Name = "Кредит";
            invoice.OrganizationName = "НеОбманТочкаРу";
            invoice.OrganizationId = 4543166;                   
            invoice.day = 20;
            invoice.month = 9;
            invoice.year = 2023;

            invoice.AddInfo("Ivan Ivanov", "New-York", 2000000);

            documents[2] = invoice;

            invoice.Print();

            Console.WriteLine("=======================================");

            Console.WriteLine(invoice.ToString());

            Console.WriteLine("=======================================");

            foreach (Document doc in documents)
            {
                Console.WriteLine(doc.ToString());
                Console.WriteLine("---------------------------------------");
            }

        }
    }
}