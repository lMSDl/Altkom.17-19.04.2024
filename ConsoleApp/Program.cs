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
Person somePerson = new Person("Adam", "Adamski", 50);

Console.WriteLine(somePerson.GetType().Name);
Console.WriteLine(somePerson.GetType().Namespace);
Console.WriteLine(somePerson.GetType().FullName);


//somePerson.name = "Adam";
//somePerson.SetName("Adam");


somePerson.Age = 50;
somePerson.LastName = "adamski";

Console.WriteLine(somePerson.GenerateInfo());

Person anotherPerson = new Person("Ewa", "Ewowska", 50);
/*anotherPerson.SetName("Ewa");
Console.WriteLine(anotherPerson.GenerateInfo());
anotherPerson.Age = 50;
Console.WriteLine(anotherPerson.GenerateInfo());
anotherPerson.LastName = "Ewowska";
Console.WriteLine(anotherPerson.GenerateInfo());*/

//Console.WriteLine($"{anotherPerson.GetName()} {anotherPerson.LastName}");
Console.WriteLine(  anotherPerson.GenerateInfo() );




Car car = new Car("Skoda", "Octavia", 2022);

Console.WriteLine(  car.GetInformations() );
car.Fuel(0.5f);
Console.WriteLine(car.GetInformations());
car.Fuel(0.6f);
Console.WriteLine(car.GetInformations());
car.Drive(100);
Console.WriteLine(car.GetInformations());
car.Drive(623);
Console.WriteLine(car.GetInformations());
car.Drive(500);
Console.WriteLine(car.GetInformations());
