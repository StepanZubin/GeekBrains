// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B:  3, 5 -> 243 (3⁵)

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