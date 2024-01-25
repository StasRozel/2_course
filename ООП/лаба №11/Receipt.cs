﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__4
{
    sealed class Receipt : Document
    {
        private List<int> AmountsProduct = new List<int>();
        private List<string> NamesProduct = new List<string>();
        private List<int> PricesProduct = new List<int>();
        private List<int> SumsProduct = new List<int>();
        private bool flagExceptin = false;

        private Sings signature = Sings.Signature;
        private Sings watermark = Sings.Watermark;
        private Sings seal = Sings.Seal;

        public Receipt(int DocId, string OrgName, int OrgId, string Name)
        {
            DocumentId = DocId;
            OrganizationName = OrgName;
            OrganizationId = OrgId;
            DocumentName = Name;
        }

        public List<string> GetNameProduct
        {
            get
            {
                return NamesProduct; 
            }
        }

        public List<int> GetPriceProduct
        {
            get
            {
                return PricesProduct;
            }
        }

        public DateTime GetDateTime()
        {
            return date;
        }

        private int calcSum(int amount, int price)
        {
            return amount * price;
        }

        public void AddProduct(int amount, string name, int price)
        {
            try
            {
                if (amount > 0)
                {
                    AmountsProduct.Add(amount);
                } else
                {
                    throw new AddedProductException("Ошибка: Количество предметов меньше нуля");
                }
                if (name != "")
                {
                    NamesProduct.Add(name);
                } else
                {
                    throw new AddedProductException("Ошибка: Нужно ввести имя продукта");
                }
                if (price > 0)
                {
                    PricesProduct.Add(price);
                } else
                {
                    throw new AddedProductException("Ошибка: Цена отрицательная");
                }
                if (amount > 0 && price > 0)
                {
                    SumsProduct.Add(calcSum(amount, price));
                } else
                {
                    throw new AddedProductException("Ошибка: Цена или количество отрицательные, сумма не рассчитана");
                }
            } catch (AddedProductException ex) 
            {
                flagExceptin = true;
                Console.WriteLine(ex.Message);
            } 
        }


        public override void Print()
        {
            if (!flagExceptin)
            {
                Console.WriteLine($"Номер документа: {DocumentId}");
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Индификационный номер: {OrganizationId}");
                Console.WriteLine($"Организация: {OrganizationName}");
                Console.WriteLine($"Название товара: {DocumentName}");
                Console.WriteLine("-------------------------");
                for (int i = 0; i < AmountsProduct.Count; i++)
                {
                    Console.Write($"| {i + 1} |");
                    Console.Write($" {AmountsProduct[i]} ");
                    Console.Write($"{NamesProduct[i]} ");
                    Console.Write($"{PricesProduct[i]} ");
                    Console.Write($"{SumsProduct[i]}\n");
                }
                Console.WriteLine("-------------------------");
                Console.WriteLine(date.ToShortDateString());
            }
            
        }

        public override string ToString()
        {

            return $"DocumentId: {DocumentId}, OrganizationId: {OrganizationId}, " +
                $"OrganizationName: {OrganizationName}, AmountsProduct: {String.Join(", ", AmountsProduct)}, NamesProduct: {String.Join(", ", NamesProduct)}," +
                $"PricesProduct: {String.Join(", ", PricesProduct)}, SumsProduct: {String.Join(", ", SumsProduct)}, Name: {DocumentName}, Date: {date.ToShortDateString()}";
        }

    }
}
