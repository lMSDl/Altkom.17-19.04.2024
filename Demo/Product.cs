using System;

namespace Demo
{
    internal class Product
    {
        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }


        public string Name { get; set; }
        public float Price { get; set; }

        public string GetDescription()
        {
            string description = $"{Name} - {Price}zł";
            return description;
        }


        /*public void FillProduct()
        {
            Console.WriteLine("Podaj nazwę produktu:");
            Name = Console.ReadLine();


            Console.WriteLine("Podaj cenę:");
            string priceString = Console.ReadLine();
            float price = float.Parse(priceString);
            Price = price;
        }*/
    }
}
