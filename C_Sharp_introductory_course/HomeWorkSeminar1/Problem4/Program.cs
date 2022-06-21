/* Задача 4: Напишите программу, которая на вход 
принимает число (N), а на выходе показывает все 
чётные числа от 1 до N. Например: 8 -> 2, 4, 6, 8 */

Console.Clear();
Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (N < 1)
{
    Console.Write(" Число не является натуральным! ");
}
else
{
    if (N > 1)
    {
        while (count < N + 1)
        {
             Console.Write(count + " , ");
             count = count + 2;
        }
    }
    else     
    {
             Console.Write(" нет чётных чисел ");
    }
}    