// Задача 10: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру этого числа.

string x = Console.ReadLine();
int userNumber = int.Parse(x);
int secondNumber = userNumber / 10 % 10;
if (userNumber>999)
{
    Console.WriteLine("error");

}
else
{
    Console.WriteLine(secondNumber);
}



