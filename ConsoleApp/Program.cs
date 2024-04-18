using ConsoleApp;
using System.IO.Pipes;

Demos demo = new Demos();
//demo.Strings();
//demo.Numbers();
//demo.Arrays();
//demo.Lists();
//demo.If();
//demo.Switch();


//I - inicjalizacja pętli - wykonuje się tylko raz na początku
//II - warunek kontynuacji pętli - wykonuje się przed każdym wykonaniem ciała
//III - ciało pętli
//IV - akcja po wykonaniu ciała - najczęsciej inkrementacja licznika
//for(I ; II ; IV)
//{ III }

for (int i = 0; i < 5; i++ /*i = i + 1*/)
{
    Console.WriteLine(i);
}


//pętla nieskończona - odpowiednik while(true)
/*for(; ; )
{
    Console.Write("*");
}*/

int value = 5;
for (; value > 0; value--/*value = value - 1*/)
{
    Console.WriteLine( value );
}
Console.WriteLine("---");
value = 0;
for (; value < 5;)
{
    Console.WriteLine(++value); //wartość wzrasta przed wyświetleniem
}

value = 0;
for (; value < 5;)
{
    Console.WriteLine(value++); //wartość wzrasta po wyświetleniu
}


string input = Console.ReadLine();
string[] splittedInput = input.Split();

for (int i = splittedInput.Length - 1; i >= 0; i--)
{
    Console.WriteLine(splittedInput[i]);
}