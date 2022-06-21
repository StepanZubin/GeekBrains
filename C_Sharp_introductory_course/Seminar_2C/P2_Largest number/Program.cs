/* Задача 2. Напишите программу, которая выводит 
случайное число из отрезка [10, 99] и показывает 
наибольшую цифру числа: 78 -> 8  12-> 2  85 -> 8 */


// Моё решение
/* Console.Clear();
int num = new Random().Next(10, 100);
int num2 = num % 10;
int num1 = (num - num2) / 10;

if (num1 == num2)
{
    Console.Write(num + ": Цифры данного числа равны. ");
}

else if (num1 > num2)
{
    Console.Write(num + ": Наибольшая цифра данного числа -> " + num1);
}
else
{
    Console.Write(num + ": Наибольшая цифра данного числа -> " + num2);
} */




// Реш-е с MinValue
/* Console.Clear();
 int num = new Random().Next(10, 100);
 int max = int.MinValue; 

 int firstDigit = num / 10;
 int secondDigit = num % 10;

if (firstDigit > max)
{
    max = firstDigit;
}
if (secondDigit > max)
{
    max = secondDigit;
}

Console.Write($"{num}: наибольшая цифра числа -> {max}");  */




 // Реш-е через while
 /* Console.Clear();
 int num = new Random().Next(10, 100);
 int max = int.MinValue;

 Console.Write(num);

 while (num > 0)
 {
    int lastDigit = num % 10;
    if (lastDigit > max)
    {
        max = lastDigit;
    }
     num = num / 10;
 }

Console.Write($": наибольшая цифра -> {max}"); */




// Реш-е с использованием методов(функций)
Console.Clear();
int num = GetRandomNumber();
Console.Write(num);
int maxDigit = FindMaxDigit(num);
Console.Write($": наибольшая цифра -> {maxDigit}"); 

int GetRandomNumber()
{
    return new Random().Next(10, 100);
}

int FindMaxDigit(int num)
{
    int max = int.MinValue;
    while (num > 0)
    {
        int lastDigit = num % 10;
        if (lastDigit > max)
        {
            max = lastDigit;
        }
        num = num / 10;
    }
    return max;
}