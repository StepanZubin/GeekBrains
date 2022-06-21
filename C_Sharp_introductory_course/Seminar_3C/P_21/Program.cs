/* Задача 21. Написать программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 2D пространстве: 
A(3; 6); B(2; 1) -> 5,09;
A(7; -5); B(1; -1) -> 7,21.  */

Console.Clear();
int numX1 = Input("введите x1: ");
int numX2 = Input("введите x2: ");
int numY1 = Input("введите y1: ");
int numY2 = Input("введите y2: ");

int num1 = numX2 - numX1;
int num2 = numY2 - numY1;
int num3 = num1 * num1 + num2 * num2;

Console.Write("Расстояние между точками: "+ Math.Sqrt(num3));

int Input(string lineOutput)
{
    Console.Write(lineOutput);
    return (Convert.ToInt32(Console.ReadLine()));
}