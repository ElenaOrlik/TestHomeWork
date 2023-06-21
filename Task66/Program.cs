int summa(int a, int b)
{
    if (a == b)
    return b;
    else return a + summa(a + 1, b);
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {n} до {m} равна {summa(n, m)}");