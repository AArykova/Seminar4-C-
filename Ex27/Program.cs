// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int summa = 0;

while (number > 0)
{
    summa += number%10;
    number = number/10; 
}
Console.WriteLine("Сумма цифр в числе равна " + summa);
