/* Задача 2: Напишите программу, которая принимает на 
вход три числа и выдаёт максимальное из этих чисел. 
Пример: 2, 3, 7 -> 7  */

Console.Clear();
Console.WriteLine("Введите первое число: "); 
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: "); 
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число: "); 
double num3 = Convert.ToDouble(Console.ReadLine());
double maxNumberA = num2;
double maxNumberB = num3;
double maxNumberAB;

if (num1 > maxNumberA)
{
   maxNumberA = num1;
}
    else 
    {
        maxNumberA = num2;
    }

if (num1 > maxNumberB)
{
    maxNumberB = num1;
}
    else 
    {
        maxNumberB = num3;
    }

if (maxNumberA > maxNumberB)
{
    maxNumberAB = maxNumberA;
}
    else 
    {
        maxNumberAB = maxNumberB;
    }

Console.Write( " Максимальное число: " + maxNumberAB);
