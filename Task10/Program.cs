Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 100 || n > 1000)
{
    Console.Write("Вы ошиблиись!\nВведите трехзначное число: ");
    n = int.Parse(Console.ReadLine()!);
}
Console.Write( n % 100 / 10);

   