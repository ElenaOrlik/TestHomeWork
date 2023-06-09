void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random(). Next(-99, 100); 
}
int SumArray (int[] array)
  {
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
        sum = sum + array[i];
    return sum;  
  }
  Console.Clear();
  Console.Write("Введите кол-во элементов массива: ");
  int n = int.Parse(Console.ReadLine()!);
  int[] array = new int[n];
  InputArray(array);
  Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
  Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях равна: [ {SumArray(array)} ]");
  