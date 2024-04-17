﻿
//wywołanie funkcji statycznej z klasy Console, która nie przyjmuje parametrów
Console.WriteLine();


//wywołanie funkcji statycznej z klasy Console z parametrem
Console.WriteLine("Hello, World!");
Console.Write("Hello, World!"); //WriteLine stawia znak nowej linii na koniec (enter), a funkcja Write - nie

//deklaracja zmiennej o typie string (ciąg/łańcuch znaków) i nazwie helloVariable
string helloVariable;

//nie możemy używać niezainicjalizowanej zmiennej
//Console.WriteLine(helloVariable);

//inicjalizacja zmiennej - pierwsze przypisanie wartości
helloVariable = "Hello";

//przekazujemy naszą zmienną jako parametr funkcji
Console.WriteLine(helloVariable);

//deklaracja z inicjalizacją
string target = "World";
Console.WriteLine(target);

//zmiana wartości - każde kolejne przypisanie wartości
helloVariable = "Hi";