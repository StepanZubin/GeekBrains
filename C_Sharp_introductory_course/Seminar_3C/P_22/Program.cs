/* Задача 22. Написать программу, которая принимает на вход 
число (N) и выдаёт таблицу квадратов чисел от 1 до N: 
5 -> 1, 4, 9, 16, 25.   2 -> 1, 4.  */

Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (num < 0)
{
    num = num * -1;
}

while (count <= num - 1) 
{
    Console.Write(Squared(count) + ", ");
    count++;
}
Console.Write(Squared(count) + ". "); /* замена "," на "." 
после последнего числа (поэтому в 15-й стороке: num - 1) */

int Squared(int a)
{
    return a * a;
}