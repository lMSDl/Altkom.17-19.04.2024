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
                return lastName.ToUpper();
            }
            //setter dla property - posiada niejawny parametr o nazwie value
            set
            {
                lastName = value;
            }
        }

    }
}
