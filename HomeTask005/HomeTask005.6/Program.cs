string CW(string msg)
{
  Console.WriteLine(msg);
  return msg;
}
try
{
  CW("Задание 6. Программа, которая сумму элементов, стоящих на нечётных позициях.");

  int[] array = new int[6];

  Random rand = new Random();

  for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(-100, 100);

  int sum = 0;
  CW("Исходный массив: [" + string.Join(",", array) + "]");

  for (int i = 0; i < array.Length; i += 2)
  {
    sum = sum + array[i];
  }
  CW($"Cуммf элементов, стоящих на нечётных позициях: {sum}");
}
catch { CW("Вы ввели некорректное значение."); }