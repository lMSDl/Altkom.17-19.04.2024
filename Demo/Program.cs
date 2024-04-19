using Demo;
using System;

Console.WriteLine("Ile produktów chcesz utworzyć?");
int count = int.Parse(Console.ReadLine());

Product[] products = new Product[count];
for (int i = 0; i < count; i++)
{
    products[i] = new Product();
    FillProduct(products[i]);
}


foreach (Product product in products)
{
    Console.WriteLine(product.GetDescription());
}

Product myProduct = new Product();
FillProduct(myProduct);


void FillProduct(Product productToFill)
{
    Console.WriteLine("Podaj nazwę produktu:");
    productToFill.Name = Console.ReadLine();


    Console.WriteLine("Podaj cenę:");
    string priceString = Console.ReadLine();
    float price = float.Parse(priceString);
    productToFill.Price = price;
}
