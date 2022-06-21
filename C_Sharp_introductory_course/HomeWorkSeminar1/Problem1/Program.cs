/* Задача 1: Написать программу, которая на вход 
принимает два числа и выдаёт, какое число большее, 
а какое меньшее. Пример: a = 5; b = 7 -> max = 7 */

Console.Clear();
Console.WriteLine("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2)
{
    Console.Write(num1 + " -> max " + num2 + " -> min ");
}
else if (num1 < num2)
{
    Console.Write(num1 + " -> min " + num2 + " -> max ");
}
else 
{
    Console.Write(" данные числа равны ");
}
