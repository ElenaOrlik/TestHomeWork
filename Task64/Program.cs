string printNumbers(int a, int b)
{
    if (a == b)
        return $" {b}";
    return $" {b}"+ printNumbers (a, b - 1);
}


Console.Clear();
int m = 1;
Console.WriteLine( $"1-ое число равно: {m}");
Console.Write("Введите 2-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNumbers(m, n));