/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int num1 = new int();
int num2 = new int();
Console.WriteLine ("Enter first number");
    num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("enter second number");
    num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine ($"max = {num1}");
}
else
{
    Console.WriteLine ($"max = {num2}");
}