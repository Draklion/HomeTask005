string CW(string msg)
{
  Console.WriteLine(msg);
  return msg;
}
try
{
  CW("Задание 5. Программа, которая покажет количество чётных чисел в массиве.");

  int[] array = new int[10];

  Random rand = new Random();

  for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(100, 1000);

  int count = 0;
  CW("Исходный массив: [" + string.Join(",", array) + "]");

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count++;
    }
  }
  CW($"Количество чётных чисел в массиве: {count}");
}
catch { CW("Вы ввели некорректное значение."); }