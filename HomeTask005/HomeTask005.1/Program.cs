string CW(string msg)
{
  Console.WriteLine(msg);
  return msg;
}
try
{
  CW("Задание 1. Программа, которая заменяет элементы массива: положительные элементы замените на соответствующие отрицательные, и наоборот.");

  int[] array = new int[5];

  Random rand = new Random();

  for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(-9, 10);

  CW("Исходный массив: [" + string.Join(",", array) + "]");

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = -array[i];
  }
  CW("Массив с противоположными элементами: [" + string.Join(",", array) + "]");
}
catch { CW("Вы ввели некорректное значение."); }