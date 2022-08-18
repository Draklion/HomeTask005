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
  CW("Задание 2. Программа, которая определяет, присутствует ли заданное число в массиве.");
  CW("Введите число для поиска в массиве: ");

  int number = Int32.Parse(CR());
  int[] array = new int[10];

  Random rand = new Random();

  for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(1, 10);
  int count = 0;
  CW("Исходный массив: [" + string.Join(",", array) + "]");
  CW($"Присутствует ли заданное число в массиве?");
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == number)
    {
      count++;
      break;
    }
  }
  CW(count > 0 ? "Да" : "Нет");
}
catch { CW("Вы ввели некорректное значение."); }