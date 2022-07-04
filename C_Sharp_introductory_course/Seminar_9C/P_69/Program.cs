// Задача 69: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А возведенную в целую 
// степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵); A = 2; B = 3 -> 8

int m = InputInt("Задайте число m: ");
int n = InputInt("Задайте число n: ");
Console.WriteLine(Numbers(m,n));

int Numbers(int m, int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return m * Numbers(m,n-1);  
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}


/*
// старое решение Сем4 25 (без рекурсии)
int a = Input("Введите число А: ");
int b = Input("Введите число B: ");
int n = a;

Console.Clear();
Console.Write($"{a} в {b} степени -> {Degre(a, b, n)}");

int Degre(int a, int b, int n) //М: возведение в степень
{
    for (int i = 1; i < b; i++)
    {
        n *= a;
    }
    return n;
}

int Input(string n)
{
    Console.Write(n);
    return Convert.ToInt32(Console.ReadLine());
}
*/

