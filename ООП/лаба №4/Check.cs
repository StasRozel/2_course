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
            NamesProduct.Add(name);
            PricesProduct.Add(price);
        }

        public override void Print() 
        {
            Console.WriteLine(Name);
            Console.WriteLine("-------------------------");
            for (int i = 0; i < NamesProduct.Count; i++)
            {
                
                Console.Write($"{NamesProduct[i]} ");
                Console.Write($"{PricesProduct[i]}руб\n");
            }
            Console.WriteLine("-------------------------");
            Console.Write($"{CalsSumCheck(PricesProduct)}руб");
        }

        public override string ToString()
        {

            return $"DocumentId: {DocumentId}, OrganizationId: {OrganizationId}, " +
                $"OrganizationName: {OrganizationName}, Name: {Name}, Date: {DatePrint()}";

        }
    }
}
