/* Задача 17. Написать программу, которая принимает на 
вход координаты точки (x; y), причём x = 0 и y = 0 и 
выдаёт номер четверти, в которой находится эта точка. 
1-я четверть (x > 0; y > 0), 2-я четверть (x < 0; y > 0), 
3-я четверть (x < 0; y < 0), 4-я четверть (x > 0; y < 0). */

Console.Clear();
int x = Input("Введите координату x: ");
int y = Input("Введите координату y: ");

if (x == 0 || y == 0)
{
    Console.Write("x и y не могут равняться 0");
    return;
}

int result = GetNumberQuarter(x, y);
Console.WriteLine($"{result}-я четверть");

int Input(string a)
{
    Console.Write(a);
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumberQuarter(int x, int y)
{
    int result = 0;
    if (x > 0 && y > 0)
    {
        result = 1;
    }
    if (x < 0 && y > 0)
    {
        result = 2;
    }
    if (x < 0 && y < 0)
    {
        result = 3;
    }
    if (x > 0 && y < 0)
    {
        result = 4;
    }
    return result;
}
