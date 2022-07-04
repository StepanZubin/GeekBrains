// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12; 45 -> 9

Console.Write("Задайте число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Numbers(m));

int Numbers(int n)
{
    if(n == 0)
    {
        return n;
    }
    else
    {
        return n % 10 + Numbers(n/10);
    }
}


/*
// решение без рекурсии Сем4 27
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
*/ 