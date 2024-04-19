using Demo;
using System;

Product myProduct = new Product();

Console.WriteLine("Podaj nazwę produktu:");
myProduct.Name = Console.ReadLine();


Console.WriteLine("Podaj cenę:");
string priceString = Console.ReadLine();
float price = float.Parse(priceString);
myProduct.Price = price;

Console.WriteLine($"{myProduct.Name} - {myProduct.Price}zł");