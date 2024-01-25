using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__4
{
    sealed class Check : Document
    {
        private List<string> NamesProduct = new List<string>();
        private List<int> PricesProduct = new List<int>();
        private bool flagException = false;

        public Check(int DocId, string OrgName, int OrgId, string Name)
        {
            DocumentId = DocId;
            OrganizationName = OrgName;
            OrganizationId = OrgId;
            DocumentName = Name;
        }
        public DateTime GetDateTime()
        {
            return date;
        }

        private int CalsSumCheck(List<int> prices)
        {
            int sumCheck = 0;

            for (int i = 0; i < prices.Count; i++)
            {
                sumCheck += prices[i];
            }

            return sumCheck;
        }

        public void AddProduct(string name, int price)
        {
            try
            {
                if (name != "")
                {
                    NamesProduct.Add(name);
                }
                else
                {
                    throw new AddedCheckExcepiton("Ошибка: Нет названия продукта");
                }
                if (price >= 0)
                {
                    PricesProduct.Add(price);
                }
                else
                {
                    throw new AddedCheckExcepiton("Ошибка: Цена должна быть больше нуля");
                }
            }
            catch (AddedCheckExcepiton ex)
            {
                flagException = true;
                Console.WriteLine(ex.Message);
            }
        }

        public override void Print()
        {
            if (!flagException)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine(DocumentId);
                Console.WriteLine("-------------------------");
                Console.WriteLine($"{OrganizationName} : {OrganizationId}");
                Console.WriteLine(DocumentName);
                Console.WriteLine("-------------------------");
                for (int i = 0; i < NamesProduct.Count; i++)
                {

                    Console.Write($"{NamesProduct[i]} ");
                    Console.Write($"{PricesProduct[i]}руб\n");
                }
                Console.WriteLine("-------------------------");
                Console.WriteLine($"{CalsSumCheck(PricesProduct)}руб");
                Console.WriteLine("-------------------------");
                Console.WriteLine(date.ToShortDateString());
            }
        }

        public override string ToString()
        {

            return $"DocumentId: {DocumentId}, OrganizationId: {OrganizationId}, " +
                $"OrganizationName: {OrganizationName}, Name: {DocumentName}, Date: {date.ToShortDateString()}";

        }
    }
}
