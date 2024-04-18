using ConsoleApp;

//Demos demo = new Demos();
//demo.Strings();
//demo.Numbers();


int a = 5;
int b = 10;
int c = 15;


//deklaracja tablicy przechowującej dane typu int
//[] - tablica
int[] array;

//inicjalizujemy zmienną nową tablicą typu int o rozmiarze 3
//tablica wypełniana jest wartościami domyślnymi zadeklarowanego typu (dla int jest to 0)
array = new int[3];

Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);

//tablice są indeksowane od 0 (minimalny indeks)
//odwołujemy się do pierwszgo elemntu tablicy, czyli pod indeks 0
array[0] = a;
array[1] = 10;
//maksymalny indeks tablicy to rozmiar minus 1 (3 - 1 = 2)
//array[2] = c;
array[array.Length - 1] = c;

Console.WriteLine(array[1]);
Console.WriteLine(array[2]);
Console.WriteLine(array[0]);

Console.WriteLine($"Tablica ma rozmiar {array.Length}");


string[] stringArray = new string[2];

stringArray[0] = Console.ReadLine();
stringArray[1] = Console.ReadLine();

array[0] = int.Parse(stringArray[0]);
array[1] = int.Parse(stringArray[1]);

Console.WriteLine($"Pole to: {array[0] * array[1]}");


Console.WriteLine("Napisz coś:");
string input = Console.ReadLine();

//tablica zwracana jako rezultat wywołania metody
//metoda split dzieli string na części wg wskazanego separatora

//string[] words = input.Split(" ");
string[] words = input.Split(); //bez parametru, działa jak powyżej

Console.WriteLine($"Wpisałeś {words.Length} słów");
