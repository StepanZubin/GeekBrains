// Задача 43. Написать программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = InputNumber("Enter b1: ");
double k1 = InputNumber("Enter k1: ");
double b2 = InputNumber("Enter b2: ");
double k2 = InputNumber("Enter k2: ");

if (k1 == k2) 
{
    Console.Clear();
    Console.Write("Given straight lines are parallel");
    return;
}
double x = (b2 - b1) / (k1 - k2);
double y = k2 * (b2 - b1) / (k1 - k2) + b2;

Console.Clear();
Console.Write("b1 = " + b1 + "; k1 = " + k1);
Console.Write("; b2 = " + b2 + "; k2 = " + k2 + " -> ");
Console.Write("(" + x + "; " + y + ")");


double InputNumber(string a)
{
    Console.Write(a);
    return Convert.ToInt32(Console.ReadLine());
}
