﻿using ConsoleApp;

//StringDemo demo = new StringDemo();
//demo.Run();


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
float bb = 4.0f;
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

Console.WriteLine($"{1f/3f:f2}");