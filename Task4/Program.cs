﻿Console.Clear();
Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число 1: ");
int c = int.Parse(Console.ReadLine());
if(a > b)
{
    if(a > c )
        Console.Write($"максимальное из этих чисел: {a} ");
    else 
        Console.Write($"максимальное из этих чисел: {c} ");
}
else
{
    if(b > c)
        Console.Write($"максимальное из этих чисел: {b} ");
    else
        Console.Write($"максимальное из этих чисел: {c} ");
}