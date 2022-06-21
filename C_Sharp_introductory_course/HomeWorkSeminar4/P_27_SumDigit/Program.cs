// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе: 
// 452 -> 11;  82 -> 10;  9012 -> 12.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

Console.Clear();
Console.Write(num + " -> " + SumDigit(sum));

int SumDigit(int sum) //М: сумма цифр
{
    while (num > 0)
    {
        sum += num % 10;
        num /= 10; 
    }
    return sum;
}
