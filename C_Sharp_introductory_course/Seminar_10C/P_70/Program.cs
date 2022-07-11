// Задача 70. Написать программу, которая на вход принимает 
// два числа и выдаёт первые N чисел, для которых каждое 
// следующее равно сумме двух предыдущих: 
// 3 и 4, N = 5 -> 3 4 7 11 18; 
// 6 и 10, N = 4 -> 6 10 16 26.

int num1 = Input("Enter number one: ");
int num2 = Input("Enter number two: ");
int n = Input("Enter number N: ");

for (int i = 1; i <= n; i++)
{
    Console.Write(Fibonacci(num1, num2, i) + " ");
}

int Fibonacci(int a, int b, int n)
{
    if (n == 1) return a;
    if (n == 2) return b;
    else 
    {
        int sum = Fibonacci(a, b, n - 1) + Fibonacci(a, b, n - 2); 
        return sum;
    }
}

int Input(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}


/*
// Вариант через строку
int num1 = Input("Enter number one: ");
int num2 = Input("Enter number two: ");
int n = Input("Enter number N: ");
Console.Write(Fibonacci(num1, num2, n));

string Fibonacci(int a, int b, int count)
{
    if (count == 0) return string.Empty;
    else return a + " " + Fibonacci(b, a + b, --count);
}

int Input(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
*/