Console.Clear();
Console.Write("Введите любое число: ");
int n = int.Parse(Console.ReadLine()!);
int i = 0, m = n;
    while (n > 0)
    {
    i += n % 10;
    n /= 10;
    }
Console.WriteLine($"Сумма цифр в числе {m} равна {i}");

