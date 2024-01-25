using System.Diagnostics;

namespace лаба__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = 10;
            y = 10;
            z = 10;

            Console.WriteLine(x + y + z);
            try
            {
                Receipt receipt = new Receipt(288782365, "ErichKrause", 6346341, "Школьные товары");
                DateTime dateTime = new DateTime(2024, 12, 12);
                receipt.AddProduct(100, "Блокнот", -20);

                Invoice invoice = new Invoice(7513646, "НеОбманТочкаРу", 4543166, "Кредит");
                invoice.AddInfo("Ivan Ivanov", "New-York", -2000000);
                invoice.Print();

                receipt.Print();
                if (dateTime > DateTime.Now)
                {
                    throw new CreateDateException("Введеная дата больше текущей");
                } else
                {
                    Console.WriteLine("Вы успешно установили дату");
                }
            } catch (CreateDateException ex) {
                Console.WriteLine(ex.Message);
            }  finally
            {
                Check check = new Check(23412, "ООО Евроопт", 532141, "Платежный документ");

                check.GetDate(20, 9, 2023);

                check.AddProduct("Хлеб", 2);
                check.AddProduct("Молоко", 3);
                check.AddProduct("Батон", 1);
                check.AddProduct("Масло", 5);

                check.Print();
            }
            Debugger.Launch();

            DateTime dateTime1 = new DateTime(2026, 12, 12);
            Debug.Assert(dateTime1 < DateTime.Now, "Дата превышает сегодняшнюю");

            Check check1 = new Check(23412, "ООО Евроопт", 532141, "Платежный документ");

            Debugger.Break();

            check1.GetDate(20, 9, 2023);

            check1.AddProduct("Хлеб", 2);
            check1.AddProduct("Молоко", 3);
            check1.AddProduct("Батон", 1);
            check1.AddProduct("Масло", 5);

            check1.Print();

            //Document[] documents = new Document[3];


            //Receipt receipt1 = new Receipt(288783453, "Лидский квас", 6356532, "Напитки");
            //Receipt receipt2 = new Receipt(232445234, "Horizont", 6234234, "Телевизоры");



            //receipt1.GetDate(20, 10, 2023);

            //receipt2.GetDate(20, 10, 2023);

            //
            //receipt.AddProduct(300, "Тетрадь", 1);
            //receipt.AddProduct(100, "Ручка", 1);
            //receipt.AddProduct(100, "Пенал", 10);

            //receipt1.AddProduct(100, "Лидский квас Темный 1л", 2);
            //receipt1.AddProduct(300, "Лидский квас Светлый 1л", 2);
            //receipt1.AddProduct(100, "Лидский квас Светлый 2л", 3);
            //receipt1.AddProduct(100, "Тетрадь", 3);

            //receipt2.AddProduct(100, "Ноутбук", 2000);
            //receipt2.AddProduct(300, "Тетрадь", 100);
            //receipt2.AddProduct(100, "Клавиатура", 100);
            //receipt2.AddProduct(100, "Процессор", 1000);

            //documents[0] = receipt;

            //receipt.Print();

            //Console.WriteLine("=======================================");

            //Console.WriteLine(receipt.ToString());

            //Console.WriteLine("\n=======================================");



            //Console.WriteLine(check.ToString());

            //Console.WriteLine("\n=======================================");

            //Invoice invoice = new Invoice(7513646, "НеОбманТочкаРу", 4543166, "Кредит");

            //invoice.AddInfo("Ivan Ivanov", "New-York", 2000000);

            //documents[2] = invoice;

            //invoice.Print();

            //Console.WriteLine("=======================================");

            //Console.WriteLine(invoice.ToString());

            //Console.WriteLine("=======================================");

            //foreach (Document doc in documents)
            //{
            //    Console.WriteLine(doc.ToString());
            //    Console.WriteLine("---------------------------------------");
            //}

            //Console.WriteLine("=======================================");

            //AccountingContainer accounting = new AccountingContainer();

            //accounting.AddDocument(invoice);
            //accounting.AddDocument(check);
            //accounting.AddDocument(receipt);
            //accounting.AddDocument(receipt1);
            //accounting.AddDocument(receipt2);

            //accounting.PrintAllDocuments();

            ////accounting.RemoveDocument(invoice);

            ////accounting.PrintAllDocuments();

            //Console.WriteLine("=======================================");

            //AccountingController accountingController = new AccountingController();

            //List<Document> arr1 = accounting.GetAllDocuments;

            //Console.WriteLine(accountingController.AllSumProduct(arr1, "Тетрадь"));

            //Console.WriteLine("=======================================");

            //accountingController.PrintAllCheck(arr1);

            //Console.WriteLine("=======================================");

            //DateTime dateStart = new DateTime(2023, 6, 1);
            //DateTime dateEnd = new DateTime(2023, 10, 1);

            //accountingController.PrintDocumentDate(arr1, dateStart, dateEnd);

        }
    }
}