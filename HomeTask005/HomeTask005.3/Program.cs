string CW(string msg)
{
  Console.WriteLine(msg);
  return msg;
}
try
{
  CW("Задание 3. Программа, которая задает одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].");

  int[] array = new int[123];

  Random rand = new Random();

  for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(1, 300);

  int count = 0;
  CW("Исходный массив: [" + string.Join(",", array) + "]");

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= 10 && array[i] <= 99)
    {
      count++;
    }
  }
  CW($"Количество элементов массива, значения которых лежат в отрезке [10,99]: {count}");
}
catch { CW("Вы ввели некорректное значение."); }