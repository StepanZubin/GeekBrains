/* Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2" */

Console.Clear();
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine()),
    count = num * -1;

while (count < num + 1)
{
    Console.Write(count + ",");
    count++;
}
