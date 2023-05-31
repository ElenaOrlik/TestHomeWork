Console.Clear();
Console.Write("Введите число А: ");
double a = double.Parse(Console.ReadLine()!);
Console.Write("Введите число В: ");
double b = double.Parse(Console.ReadLine()!);
double c = Math.Pow(a, b);
Console.WriteLine($"Ответ: {a} в степени {b} равен {c}");