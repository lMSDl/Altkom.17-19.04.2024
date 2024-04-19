//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa
//namespace zaciągamy używając "using"
namespace ConsoleApp.Models
{

    //pełna nazwa klasy to <namespace>.<nazwa>
    // <modyfikator dostępu> class <nazwaKlasy>

    //public - modyfikator dostępu - oznacza, że z klasy można korzystać wszędzie
    //internal - modyfikator dostępu - oznacza, że z klasy można korzystać tylko w projekcie "rodzimym"
    //class - szablon opisujący zachowania i cechy obiektów (instancji klas), które są wytwarzane na jej podstawie
    public class Person
    {
        //metoda konstrukcyjna  (konstruktor) - bezparametrowy
        //brak określenia typu zwracanego i nazwa taka sama jak nazwa klasy
        //metody konstrukcyjne są potrzebne, aby wstępnie skonfugorować obiekt
        //jeśli klasa nie ma żadnego zdefiniowanego konstruktora, to konstruktor bezparametrowy jest generowany automatycznie
        public Person()
        {
        }

        //konstruktor parametrowy - służy do zapewnienia klasie wartości początkowych przekazanych jako parametry
        //jeśli w klasie występuje jakiś konstuktor parametrowy, to konstuktor bezparametrowy nie zostanie automatycznie wygenerowany
        //chcąc posiadać jednocześnie konstruktor parametrowy i bezparametrowy musimy go jawnie utworzyć
        public Person(string name, string lastName, int age)
        {
            this.name = name; //w przypadku konfliktu nazw pola i parametru stosujemy "this", żeby wskazać która z nazw to pole "tej" klasy
            this.lastName = lastName;
            Age = age;
        }

        public Person(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }


        //pole klasy (field)
        //private - oznacza dostęp tylko dla elementów danej klasy
        //pola zazwyczaj są prywatne ze względu na hermetyzację, a dostęp realizowany jest przez metody dostępowe (getter i setter)
        private string name;

        //setter - do ustawiania wartości imienia - metoda przyjmuje parametr, który zostaje wpisany w odpowiednie pole (można dodać kod "obróbki danych")
        //void - metoda nic nie zwaraca
        public void SetName(string value)
        {
            name = value;
        }

        //getter dobrania wartości pola _imie - metoda zwraca typ zgodny z typem pola
        //string - metoda zwraca string
        public string GetName()
        {
            //instukcja zwracająca wynik działania metody - obowiązkowy gdy zadeklarowaliśmy, że klasa coś zwraca (jest inna niż void)
            return name;
        }

        //Property - właściwość

        //auto-property
        //właściwość integruje w sobie pole i metody dostępowe (getter i setter)
        //jest możliwość zmiany modyfikatora dostępu dla getter lub setter (osobno)
        public int Age { /*private*/ get; set; }

        //backfield do full-property - pozwala na dodatkowy kod w setterze i getterze
        private string lastName;
        //full-property
        public string LastName {
            //getter dla property
            get
            {
                return lastName?.ToUpper();
            }
            //setter dla property - posiada niejawny parametr o nazwie value
            set
            {
                lastName = value;
            }
        }


        //<modyfikator dostępu> <typ zwracany> <nazwa metody>()
        public string GenerateInfo()
        {
            string info = $"{name} {LastName}, wiek {Age}";
            return info;
        }

    }
}
