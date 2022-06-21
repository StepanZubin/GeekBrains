/* Задача 13. Написать программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет: 645 -> 5; 32679 -> 6;
78 -> третьей цифры нет */


Console.Clear();
Console.Write("Задайте число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < -99)
{
    num = num * -1;
}

while (num > 999)
{
    num = num / 10;
}

if (num > 99)
{
    num = num % 10;
    Console.Write($"третья цифра: {num}");
}
else
{
    Console.Write("третьей цифры нет");
}
