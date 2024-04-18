using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Demos
    {
        public void DoWhile()
        {
            bool finish;
            //do-while - sprawdza warunek po wykonaniu ciała - zapewnia, że zostanie ono wykonane co najmniej raz
            //pozwala to wyeliminować inicjalizację zminnych przed wejściem do pętli
            do
            {
                Console.WriteLine("Co chcesz zrobić?");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "exit":
                        finish = true;
                        break;
                    default:
                        finish = false;
                        Console.WriteLine(operation);
                        break;
                }
            } while (!finish);
        }

        public void While()
        {
            bool stop = false;

            //while - pętla która trwa gdy jej parametr jest true, parametr jest sprawdzany przed każdym wejściem do pętli
            // jeśli przy pierwszym wejściu parametr będzie false, to pętla się nigdy nie wykona

            while (!stop)
            //while(true) = pętla nieskończona
            {

                Console.WriteLine("Co chcesz zrobić?");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "exit":
                        stop = true;
                        break;
                    default:
                        Console.WriteLine(operation);
                        break;
                }

            }
        }


        public void Switch()
        {
            Console.WriteLine("Podaj bok kwadratu:");
            string input = Console.ReadLine();

            int side;
            bool parseSuccess = int.TryParse(input, out side);
            if (!parseSuccess)
            {
                Console.WriteLine($"Błędna wartość {input}!");
            }
            else
            {
                //switch - przyjmuje parametr, kóry jest porównywany z listą przypadkó (case)
                switch (side)
                {
                    //case - rozpatrywany przypadek
                    //wiele case'ow może być przypisanych do tego samego kodu
                    case > 0:
                        //kod wykonywany jest od case do break - nie ma potrzeby stosowaniea klamerek {}
                        //case musi kończyć się instrukją break - przerywająca wykonywanie swticha
                        Console.WriteLine($"Kwadrat ma obwód {side * 4}");
                        break;
                    case < 0:
                        Console.WriteLine("Nie mogę policzyć obwodu z ujemnego rozmiaru");
                        break;

                    //default - odpowiedniek else, czyli wykonanie kodu, jeśli nie znalezioni odpowiedniego case
                    default:
                        Console.WriteLine("Kwadrat nie istnieje");
                        break;
                }

            }


            Console.WriteLine("podaj wartość A:");
            string a = Console.ReadLine();
            float valueA;

            if (!float.TryParse(a, out valueA))
            {
                Console.WriteLine("Błędna wartość A!");
                return; //przerywa wykonywanie funkcji
            }

            Console.WriteLine("podaj wartość B:");
            string b = Console.ReadLine();
            float valueB;
            if (!float.TryParse(b, out valueB))
            {
                Console.WriteLine("Błędna wartość B!");
                return;
            }

            Console.WriteLine("Wprowadź znak operacji:");
            string operation = Console.ReadLine();

            float result;

            switch (operation)
            {
                case "+":
                    result = valueA + valueB;
                    break;
                case "-":
                    result = valueA - valueB;
                    break;
                case "*":
                    result = valueA * valueB;
                    break;
                case "/":
                    result = valueA / valueB;
                    break;
                case "^":
                    result = (float)Math.Pow(valueA, valueB);
                    break;
                default:
                    Console.WriteLine("Nieznana operacja!");
                    return;
            }
            Console.WriteLine($"{a} {operation} {b} = {result}");
        }

        public void If()
        {
            Console.WriteLine("Podaj bok kwadratu:");
            string input = Console.ReadLine();

            int side;
            //TryParse - zwraca wartość bool mówiącą czy parsowanie się powiodło
            //out - parameter wyjściowy - parametr przez który metoda może nam zwrócić jakąś dodatkową wartość (w tym przypadku jest to wynik parsowania)
            // jeśli parsowanie się nie powiodło, to w parametrze wyjściowym będzie wpisana wartość domyślna typu (dla typów liczbowych jest to 0)
            bool parseSuccess = int.TryParse(input, out side);
            if (!parseSuccess)
            {
                Console.WriteLine($"Błędna wartość {input}!");
            }
            else
            {

                //if sprawdza warunek w nawiasie i jeśli jest on prawdziwy, to wykonuje się blok kodu pod nim
                if (side > 0)
                {
                    Console.WriteLine($"Kwadrat ma obwód {side * 4}");
                }
                // jeśli poprzedni warunek nie jest spełniony, to sprawdzany jest kolejny if
                // else if - może występować wielokrotne
                else if (side < 0)
                {
                    Console.WriteLine("Nie mogę policzyć obwodu z ujemnego rozmiaru");
                }
                //else - wykonuje blok kodu w każdym innym przypadku
                else /*if(side == 0)*/
                {
                    Console.WriteLine("Kwadrat nie istnieje");
                }

                //jeżeli używany else, to tylko jeden blok kodu zostanie wykonany i sprzwdzanie warunków zakończy się w przypadku wejścia w któryś z bloków
                //jeżeli nie używany else, to każdy if będzie traktowany osobno i warunek będzie sprzwdzany niezależnie
                //wniosek else jest też łącznikiem między kolejnymi if'ami

                if (side != 0)
                {
                    Console.WriteLine("Bok jest różny od 0");
                }
                if (side == 0)
                {
                    Console.WriteLine("Bok jest równy 0");
                }

                bool result = side == 0; //== - porównanie
                result = side != 0; //!= - nierówność
                result = side > 0; //> - większe
                result = side < 0; //< - mniejsze
                result = side >= 0; //>= - większe lub równe
                result = side <= 0; //<= - mniejsze lub równe

                result = side > 0 || side == 0; // || - logiczne lub (OR)
                result = side > 0 && side <= 10; // || - logiczne i (AND)


                if (result)
                {
                    Console.WriteLine("Bok kwadratu jest z przedziału (0;10>");
                }

                //! - negacja - zaprzeczenie tego co występuje po wykrzykniku
                if (!result)
                {
                    Console.WriteLine("Bok kwadratu nie jest z przediały (0:10>");
                }
            }
        }

        public void Lists()
        {
            //tworzymy nową listę. Lista po inicjalizacji jest pusta.
            List<string> strings = new List<string>();
            //List<string> strings = new ();

            //dodajemy nowy element do listy, rozmiar tablicy się zwiększa
            strings.Add("!");
            strings.Add("ala");
            strings.Add("kota");

            //stawiamy element na konkretny indeks listy - pozostałe ementy przesuwają się
            strings.Insert(2, "ma");

            strings.Add("!");
            strings.Add("!");

            //usuwamy element pod indeksem 2 - rozmiar listy się zmniejsza
            strings.RemoveAt(2);
            //usuwamy element wg wartości - jeśli występuję więcej takich elementów, to usuwany jest pierwszy w kolejności
            strings.Remove("!");

            //w listach odwołujemy się do elementów po indeksach (tak jak w tablicach)
            strings[strings.Count - 1] = "?";


            Console.WriteLine(strings[1]);

            //przekształcenie tablicy do listy
            strings = Console.ReadLine().Split().ToList();


            Console.WriteLine($"Lista ma rozmiar: {strings.Count}");
        }

        public void Arrays()
        {
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


            bool isEqual = words[0] == words.First();
            Console.WriteLine(isEqual);
            isEqual = words[words.Length - 1] == words.Last();
            Console.WriteLine(isEqual);
        }

        public void Numbers()
        {
            int a = 11;
            int b = 4;

            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
            c = a - b;
            Console.WriteLine($"{a} - {b} = {c}");
            c = a * b;
            Console.WriteLine($"{a} * {b} = {c}");
            c = a / b; // część dziesiętna jest ucięta
            Console.WriteLine($"{a} / {b} = {c}");
            c = a % b; //reszta z dzielenia
            Console.WriteLine($"{a} % {b} = {c}");

            float aa = 11;
            float bb = 3.14f;
            float cc = aa + bb;
            Console.WriteLine($"{aa} + {bb} = {cc}");
            cc = aa - bb;
            Console.WriteLine($"{aa} - {bb} = {cc}");
            cc = aa * bb;
            Console.WriteLine($"{aa} * {bb} = {cc}");
            cc = aa / bb;
            Console.WriteLine($"{aa} / {bb} = {cc}");

            //aby wynik był poprawny przy dzieleniu dwóch intów należy jako pierwszą operację "przekształcić" int na float
            //możemy to zrobić poprzez wykonanie jako pierwszą operację mnożenia przez typ o większej prezycji
            cc = 1f * a / b;
            Console.WriteLine($"{a} / {b} = {cc}");

            //lub poprzez rzutowanie (czyli potraktowanie jednego typu jako inny (podany w nawiasie))
            cc = (float)a / b;
            Console.WriteLine($"{a} / {b} = {cc}");

            //kolejność działań zgodna z zasadami matematyki
            c = a + a * a;
            Console.WriteLine($"{a} + {a} * {a} = {c}");
            c = (a + a) * a;
            Console.WriteLine($"({a} + {a}) * {a} = {c}");


            Console.WriteLine($"short min:{short.MinValue} max:{short.MaxValue}");
            Console.WriteLine($"int min:{int.MinValue} max:{int.MaxValue}");
            Console.WriteLine($"long min:{long.MinValue} max:{long.MaxValue}");

            Console.WriteLine($"float min:{float.MinValue} max:{float.MaxValue}");
            Console.WriteLine($"double min:{double.MinValue} max:{double.MaxValue}");
            Console.WriteLine($"decimal min:{decimal.MinValue} max:{decimal.MaxValue}");


            Console.WriteLine(5 / 3.3f); //f - float
            Console.WriteLine(5 / 3.3d); //d - double
            Console.WriteLine(5 / 3.3m); //m - decimal

            //Math to klasa zawierające funkcje przydatne w obliczeniach matematycznych
            //domyślne zachowanie funkcji zaokrąglającej powoduje zaokrąglanie do wartości parzystej
            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(3.5));

            //używamy zaokrąglania znanego ze szkoły
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(3.5, MidpointRounding.AwayFromZero));


            //formatowanie liczb
            Console.WriteLine($"{9:0#}");
            Console.WriteLine($"{19:0#}");

            Console.WriteLine($"{1f / 3f:f2}");


            Console.WriteLine("Podaj pierwszy bok prostokąta:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Podaj drugi bok prostokąta:");
            string input2 = Console.ReadLine();

            //parsowanie/konwersja string na int
            //int sideA = int.Parse(input1);
            //int sideB = int.Parse(input2);

            //parsowanie/konwersja string na float
            float sideA = float.Parse(input1);
            float sideB = float.Parse(input2);

            float area = sideA * sideB;

            Console.WriteLine($"Pole powierzchni to {area}");
        }

        public void Strings()
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
