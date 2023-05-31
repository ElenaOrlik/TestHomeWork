Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
n = Math.Abs(n); // Модуль числа
for (int i = 1; i <= n; i++)
    Console.Write($"{i * i * i} ");