using ConsoleApp;
using System.IO.Pipes;

Demos demo = new Demos();
//demo.Strings();
//demo.Numbers();
//demo.Arrays();
//demo.Lists();
//demo.If();
//demo.Switch();


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
} while(!finish);


Console.WriteLine(  );
