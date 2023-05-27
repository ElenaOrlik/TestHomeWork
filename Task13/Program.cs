Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 100)
{
    Console.Write("Тут нет третей цифры\nВведите число: ");
    n = int.Parse(Console.ReadLine()!);
}
while (n > 999)
{
    n = n / 10;
}
Console.WriteLine(n % 10);