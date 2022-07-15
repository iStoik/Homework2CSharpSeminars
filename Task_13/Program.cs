Console.Write("Введите число: "); // Ввод значения пользователем
string number = Console.ReadLine();

char[] numberArray = number.ToCharArray();
if (numberArray.Length >= 3)
{
    Console.Write($"{number} -> {numberArray[2]}");
}
else
{
    Console.Write($"{number} -> третьей цифры нет");
}
