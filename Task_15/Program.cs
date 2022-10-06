// Задача 15: Напишите программу, которая принимает на вход цифру, о
// бозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число: ");
string userNumber = Console.ReadLine();
int dayWeek = int.Parse(userNumber);

if (dayWeek == 6 || dayWeek == 7) Console.WriteLine("да");
else Console.WriteLine("нет");
if (dayWeek < 1 || dayWeek > 7) Console.WriteLine("такого дня недели нет");



