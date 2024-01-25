using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace лаба__4
{
    class AccountingController
    {
        public int AllSumProduct(List<Document> document, string nameProduct)
        {
            int sum = 0;
            for (int i = 0; i < document.Count; i++)
            {
                if (document[i].GetType().ToString() == "лаба__4.Receipt")
                {
                    Receipt? receipt = document[i] as Receipt;
                    for (int j = 0; j < receipt.GetNameProduct.Count; j++)
                    {
                        string product = receipt.GetNameProduct[j];

                        if (product == nameProduct)
                        {
                            sum += receipt.GetPriceProduct[j];
                        }
                    }
                }
            }

            return sum;
        }

        public void PrintAllCheck(List<Document> document)
        {
            for (int i = 0; i < document.Count; i++)
            {
                if (document[i].GetType().ToString() == "лаба__4.Check")
                {
                    Console.WriteLine(document[i]);
                }
            }
        }

        public void PrintDocumentDate(List<Document> document, DateTime dateStart, DateTime dateEnd)
        {
            for (int i = 0; i < document.Count; i++)
            {
                switch (document[i].GetType().ToString())
                {
                    case "лаба__4.Receipt":
                        Receipt? receipt = document[i] as Receipt;
                        if (receipt.GetDateTime() > dateStart && receipt.GetDateTime() < dateEnd)
                        {
                            Console.WriteLine(document[i]);
                        }
                        break;
                    case "лаба__4.Check":
                        Check? check = document[i] as Check;
                        if (check.GetDateTime() > dateStart && check.GetDateTime() < dateEnd)
                        {
                            Console.WriteLine(document[i]);
                        }
                        break;
                    case "лаба__4.Invoice":
                        Invoice? invoice = document[i] as Invoice;
                        if (invoice.GetDateTime() > dateStart && invoice.GetDateTime() < dateEnd)
                        {
                            Console.WriteLine(document[i]);
                        }
                        break;
                }
            }
        }
    }
}
