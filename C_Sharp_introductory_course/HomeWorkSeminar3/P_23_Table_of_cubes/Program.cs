/* Задача 23. Написать программу, которая принимает 
на вход число (N) и выдаёт таблицу кубов чисел 
от 1 до N: 3 -> 1, 8, 27. */

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (num < 0)
{
        num = num * -1;
}

while (count <= num)
{
    int numCube = Cube(count);
    count++;
    Console.WriteLine(numCube);
}

int Cube(int a) // метод: возведение в куб
{
    return a * a * a;
}