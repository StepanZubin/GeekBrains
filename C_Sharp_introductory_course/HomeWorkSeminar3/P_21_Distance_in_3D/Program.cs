/* Задача 21. Написать программу, которая принимает 
на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве: 
A(3, 6, 8); B(2, 1, -7) -> 15,84.  */

Console.Clear();

int x1 = Input("введите x1: ");
int y1 = Input("введите y1: ");
int z1 = Input("введите z1: ");

int x2 = Input("введите x2: ");
int y2 = Input("введите y2: ");
int z2 = Input("введите z2: ");

int num_x = SquareDifference(x1, x2);
int num_y = SquareDifference(y1, y2);
int num_z = SquareDifference(z1, z2);

double dist = Math.Sqrt(num_x + num_y + num_z);
double distRound = Math.Round(dist, 2); // метод: округление

Console.Write($"A({x1}, {y1}, {z1}); B({x2}, {y2}, {z2}) -> {distRound}");

int Input(string number)
{
    Console.Write(number);
    return (Convert.ToInt32(Console.ReadLine()));
}

int  SquareDifference(int a, int b) // метод: квадрат разности
{
    return (b - a) * (b - a);
}