using ConsoleApp;
using System.IO.Pipes;

Demos demo = new Demos();
//demo.Strings();
//demo.Numbers();
//demo.Arrays();
//demo.Lists();
//demo.If();
//demo.Switch
//demo.For();


float[] numbers;
bool exit;
do
{
    exit = true;
    Console.WriteLine("Wypisz jakieś liczby:");
    string input = Console.ReadLine();

    string[] splittedInput = input.Split();

    numbers = new float[splittedInput.Length];

    for (int i = 0; i < splittedInput.Length; i++)
    {
        float value;
        if (float.TryParse(splittedInput[i], out value))
        {
            numbers[i] = value;
        }
        else
        {
            Console.WriteLine("Błędne dane");
            exit = false;
            break; //przerywa wykonywanie pętli
        }
    }
} while (!exit);

for (int i = 0; i < numbers.Length; i++)
{
    float number = numbers[i];
    Console.Write(number);
}

//foreach zastępuje powyższy sposób iteracji po tablicy
//foreach - pozwala przejsc po wszystkich elementach tablicy
foreach (float number in numbers)
{
    Console.Write(number);
}