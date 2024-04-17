using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class StringDemo
    {

        public void Run()
        {
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

            //Lenth - właściwość (brak nawiasów odróżnia ją od metody) - przetrzymuje dane o długości stringa
            output = $"Długość dotychczasowej zawartości zmiennej \"output\" to \t {output.Length}"; //ukośnik opadający aktywuje znak specjalny/zastrzeżony
            Console.WriteLine(output);

            output = $"Długość dotychczasowej zawartości zmiennej output to {output.Count()}";
            Console.WriteLine(output);

            //stringów nie możemy edytować, żeby zmienić wartość należy wytworzyć nowego stringa i przypisać pod zmienną
            //zastąpienie części znaków - czułe na wielkość liter
            output = output.Replace("dotychczasowej", "tymczasowej");
            Console.WriteLine(output);
            //zastąpienie części znaków - niezależne od wielkości liter
            output = output.Replace("Dotychczasowej", "tymczasowej", StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(output);

            //wycinanie "podstringów"
            output = output.Substring(0, output.Length - 6 - 2); //obliczamy ile znaków usunąć z końca
            Console.WriteLine(output);

            string someString = "ala ma kota";
            string anotherString = "Ala ma kota";

            bool isEqual;

            //= operator przypisania
            // == - operator porównania, dla string działa tak samo jak Equals
            isEqual = someString == anotherString;
            Console.WriteLine(isEqual);

            //Equals porównuje czy obiekty są tym samym obiektem. Produktem metody jest zmienna bool (prawda/fałsz)
            isEqual = someString.Equals(anotherString);
            Console.WriteLine(isEqual);

            //porównanie z ignorowaniem wielkości znaków
            isEqual = someString.Equals(anotherString, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(isEqual);


            name = Console.ReadLine();

            //usuwanie białych znaków z początku i/lub końca
            Console.WriteLine($"*{name}*");
            Console.WriteLine($"*{name.Trim()}*");
            Console.WriteLine($"*{name.TrimEnd()}*");
            Console.WriteLine($"*{name.TrimStart()}*");

            //usuwanie wskazanego znaku przez sparametryzowanie metody wskazanym znakiem
            Console.WriteLine($"*{name.Trim().Trim('ł')}*");
        }

    }
}
