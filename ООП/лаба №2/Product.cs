using System;
using System.Security.Cryptography.X509Certificates;

namespace lab__2
{
    partial class Product
    {

        public string SetName
        {
            set { name = value; }
        }

        public int SetUpc
        {
            set { upc = value; }
        }

        public int SetPrice
        {
            set { price = value; }
        }

        public string SetShelfLife
        {
            set { shelfLife = value; }
        }

        private int SetAmount
        {
            set { amount = value; }
        }

        public string GetName
        {
            get { return name; }
        }

        public int GetUpc
        {
            get { return upc; }
        }

        public int GetPrice
        {
            get { return price; }
        }

        public string GetShelfLife
        {
            get { return shelfLife; }
        }

        public int GetAmount
        {
            get { return amount; }
        }
    }


     partial class Product
     {
        private static int count = 0;
        private static readonly Guid id = Guid.NewGuid();
        private string name { get; set; }
        private int upc { get; set; }
        private int price { get; set; }
        private string shelfLife { get; set; }
        private int amount { get; set; }
        private const int qr = 0;

        private Product(int Upc)
        {
            name = "-";
            upc = Upc;
            price = 0;
            shelfLife = "-";
            amount = 0;
        }

        public Product(string NameProduct = "", int Upc = 0, int Price = 0, string ShelfLife = "", int Amount = 0)
        {
            name = NameProduct;
            upc = Upc;
            price = Price;
            shelfLife = ShelfLife;
            amount = Amount;
            count++;
        }


        public bool Find(string nameProduct)
        {
            return (nameProduct == name) ? true : false; 
        }

        public bool FindAndPrice(string nameProduct, int priceProduct)
        {
            return (nameProduct == name && priceProduct > price) ? true : false;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"UPC: {upc}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Shelf life: {shelfLife}");
            Console.WriteLine($"Amount: {amount}");
        }

        public static int PrintCounter()
        {
            return count;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            Product product = (Product) obj;

            return product.name == this.name;
        }

        public override int GetHashCode()
        {
            return (upc * price);
        }

        public override string ToString()
        {
            return $"Name: {name} UPC: {upc} Price: {price} Shelf life: {shelfLife} Amount: {amount}";
        }

        public int AllSum(ref int amountUser, ref int priceUser, out int result)
        {
            result = amountUser * priceUser;
            return result;
        }
    }
}
