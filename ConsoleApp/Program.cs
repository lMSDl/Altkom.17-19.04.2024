
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
helloVariable = Console.ReadLine(); // Console.ReadLine() - pobranie danych z konsoli, zatwierdzamy enterem

string output;

//łączenie stringów za pomocą operatora +
output = helloVariable + " " + target; // łączenie stringów to "wyprodukowanie" nowego stringa na podstawie połączenia innych

Console.WriteLine(helloVariable);
Console.WriteLine(target);
Console.WriteLine(output);

Console.WriteLine("Podaj imię:");
string name = Console.ReadLine();

string format = "{0} {1}!"; //wartości w nazwiasach oznaczają indeks parametru, który ma być wstawiony w to miejsce
output = string.Format(format, helloVariable, name); //łączenie stringów za pomocą funkcji format
Console.WriteLine(output);

output = "{helloVariable} {name}!";
Console.WriteLine(output);

output = $"{helloVariable} {name}!"; //łączenie wykorzystujące interpolację (string interpolowany)
Console.WriteLine(output);
