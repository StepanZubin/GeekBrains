/* Задача 18. Написать программу, которая по заданному номеру
четверти, показывает диапазон возможных координат точек в 
этой четверти (x и y) */

Console.Clear();
Console.Write("Введите номер четверти:");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num > 4)
{
    Console.Write("Ошибка: всего 4-ре четверти!");
}

if (num == 1)
{
    Console.WriteLine("x > 0; y > 0");
}
if (num == 2)
{
    Console.WriteLine("x < 0; y > 0");
}
if (num == 3)
{
    Console.WriteLine("x < 0; y < 0");
}
if (num == 4)
{
    Console.WriteLine("x > 0; y < 0");
}
