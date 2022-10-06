// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры неt

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
string userNumberString = Convert.ToString(userNumber);

if (userNumberString.Length > 2)
{
    Console.WriteLine("Третья цифра: " + userNumberString[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}