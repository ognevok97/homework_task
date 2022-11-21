/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int num1 = new int();
int num2 = new int();
int num3 = new int();
Console.WriteLine ("Enter first number");
    num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("enter second number");
    num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("enter third number");
    num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if  (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine ($"max = {max}");