void InputArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(0,1000)) / 100;
        }
}
double MinArray(double[] array)
{
    double min = array[0];
    foreach (double i in array)
    {
        if(min > i) min = i;
    }
    return min;
}

double MaxArray(double[] array)
{
    double max = array[0];
    foreach (double i in array)
    {
        if(max < i) max = i;
    }
    return max;
}
double DiffArray(double min, double max)
{
    double result = max - min;
     return result;
}
  
Console.Clear();
  Console.Write("Введите кол-во элементов массива: ");
  int n = int.Parse(Console.ReadLine()!);
  double[] array = new double[n];
  InputArray(array);
  Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
  Console.WriteLine($"Минимальное число равно: [ {MinArray(array)} ]");
  Console.WriteLine($"Максимальное число равно: [ {MaxArray(array)} ]");
  //Console.WriteLine($"Разница межву макс и мин равно: [ {DiffArray(min, max)} ]");