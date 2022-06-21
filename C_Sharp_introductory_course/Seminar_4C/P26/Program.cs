// Зфдача 26. Написать программу, которая принимает 
// на вход число и выдаёт количество цифр в числе: 456 -> 3


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (num > 0)
{
    num /= 10;
    i++;
} 

Console.WriteLine(i);
