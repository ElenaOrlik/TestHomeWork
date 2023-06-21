int FunctionA(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if (b == 0 && a > 0)
    {
        return FunctionA(a - 1, 1);
    }
    else
    {
        return (FunctionA(a - 1, FunctionA(a, b - 1)));
    }
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Ответ: {FunctionA(n, m)}");