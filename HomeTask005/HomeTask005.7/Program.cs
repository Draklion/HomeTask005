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
  CW("Задание 7. Программа, которая находит разницу между максимальным и минимальным элементов массива.");
  CW("Введите элементы массива: ");

  double[] array = new double[5];
  double max = 0;
  double min = 0;

  for (int i = 0; i < array.Length; i++)
    array[i] = double.Parse(CR());

  max = array[0];
  min = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (max < array[i])
      max = array[i];
    else if (min > array[i])
      min = array[i];
  }
  CW(max + " " + min);
  CW($"Разницу между максимальным и минимальным элементов массива : {max - min}");
}
catch { CW("Вы ввели некорректное значение."); }