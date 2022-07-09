// Задача 70. Написать программу, которая на вход принимает 
// два числа и выдаёт первые N чисел, для которых каждое 
// следующее равно сумме двух предыдущих: 
// 3 и 4, N = 5 -> 3 4 7 11 18; 
// 6 и 10, N = 4 -> 6 10 16 26.

int num1 = Input("Enter number one: ");
int num2 = Input("Enter number two: ");
int n = Input("Enter number N: ");
//int count = 3;
// Console.Write($"{num1} {num2} ");


int SumNumbers()
{
    if ()
}

/*
while (count <= n)
{
    int sum = num1 + num2;
    Console.Write(sum + " ");
    num1 = num2;
    num2 = sum;
    count++;
}
*/

int Input(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
