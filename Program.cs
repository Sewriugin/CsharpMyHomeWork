// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/* Задача 1:
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
1) a = 5 b = 7 -> max = 7; 2) a = 2 b = 10 -> max = 10; 3) a = -9 b = -3 -> max = -3
System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b) max = a;
else max = b;
Console.WriteLine("max = " + max);
*/

/* Задача 2:
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
1) 2, 3, 7 -> 7; 2) 44 5 78 -> 78; 3) 22 3 9 -> 22
System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b & a > c) max = a;
else 
if (b > c) max = b;
else max = c;
Console.WriteLine("max = " + max);
*/

/* Задача 3:
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
1) 4 -> да; 2) -3 -> нет; 3) 7 -> нет
System.Console.Write("Введите число: ");
double a = Convert.ToInt32(Console.ReadLine());
double result = a % 2;
if (result == 0) 
{
    double evenNumber = a / 2;
    Console.WriteLine("Число является чётным");
}
else 
{
    double oddNumber = a / 2;
    Console.WriteLine("Число является нечётным");
}
*/

/*
Задача 4:
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
1) 5 -> 2, 4; 2) 8 -> 2, 4, 6, 8
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int num = 0;
System.Console.WriteLine("Чётные числа из диапазона от 1 до N: ");
while (num < N)
{
    num++;
    if (num % 2 == 0) System.Console.Write(num + " ");
}
System.Console.WriteLine();
System.Console.WriteLine();
*/
