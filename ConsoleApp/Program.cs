using ConsoleApp;

//Demos demo = new Demos();
//demo.Strings();
//demo.Numbers();
//demo.Arrays();

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