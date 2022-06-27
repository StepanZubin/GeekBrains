// Задача 40: Написать программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();
int a = Input("Enter 1 number: ");
int b = Input("Enter 2 number: ");
int c = Input("Enter 3 number: ");

if ( a < b + c && b < a + c && c < b + c) 
{
     Console.Write("Yes, triangle is possible");
}
else Console.Write("No, triangle is not possible");


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}