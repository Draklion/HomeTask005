string CW(string msg)
{
  Console.WriteLine(msg);
  return msg;
}
string CR()
{
  return Console.ReadLine();
}
try
{
  CW("Задание 4. Программа, которая находит произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");
  CW("Введите количество элементов в массиве: ");
  int[] array1 = new int[Int32.Parse(CR())];
  int[] array2 = new int[array1.Length % 2 == 0 ? array1.Length / 2 : (array1.Length / 2) + 1];

  Random rand = new Random();

  for (int i = 0; i < array1.Length; i++)
    array1[i] = rand.Next(1, 10);

  CW("Исходный массив: [" + string.Join(",", array1) + "]");
  if (array1.Length % 2 == 0)
  {
    for (int i = 0; i < array1.Length / 2; i++)
      array2[i] = array1[i] * array1[array1.Length - 1 - i];
  }
  else
  {
    for (int i = 0; i < array1.Length / 2; i++)
      array2[i] = array1[i] * array1[array1.Length - 1 - i];
    array2[array2.Length - 1] = array1[array1.Length / 2];
  }


  CW("Массив произведений: [" + string.Join(",", array2) + "]");
}
catch { CW("Вы ввели некорректное значение."); }