/* Задача 19. Написать программу, которая принимает 
на вход пятизначное число и проверяет, является ли 
оно палиндромом: 14212 -> нет; 12821 -> да  */

Console.Clear();
Console.Write("Ведите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99999 || num < 10000)
{
    Console.Write("Ошибка вводв!");
    return;
}

int num5 = num % 10;
int num4 = num / 10 % 10;
// int num3 = num / 100 % 10;
int num2 = num / 1000 % 10;
int num1 = num / 10000;

if (num1 == num5 && num2 == num4)
{
    Console.Write("ДА");
}
else
{
    Console.Write("НЕТ");
}