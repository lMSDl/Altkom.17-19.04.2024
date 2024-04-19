using ConsoleApp;
using ConsoleApp.Models;
using System.IO.Pipes;

Demos demo = new Demos();
//demo.Strings();
//demo.Numbers();
//demo.Arrays();
//demo.Lists();
//demo.If();
//demo.Switch
//demo.For();
//demo.Foreach();

//new - wytwarzamy nowy obiekt (instancję) klasy Person
Person somePerson = new Person();

Console.WriteLine(somePerson.GetType().Name);
Console.WriteLine(somePerson.GetType().Namespace);
Console.WriteLine(somePerson.GetType().FullName);


//somePerson.name = "Adam";
somePerson.SetName("Adam");


Console.WriteLine(  somePerson.GetName() );

somePerson.Age = 50;
Console.WriteLine(  somePerson.Age);

somePerson.LastName = "adamski";
Console.WriteLine(somePerson.LastName);