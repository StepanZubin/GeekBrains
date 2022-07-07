// Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Enter m: ");
double m = int.Parse(Console.ReadLine());
Console.Write("Enter n: ");
double n = double.Parse(Console.ReadLine());

Console.Clear();
Console.Write($"m = {m}, n = {n} -> A(m, n) = " + Ackermann(m, n));

double Ackermann(double m, double n)
{
  if (m == 0) return n + 1;
  else if ((m > 0) && (n == 0)) return Ackermann(m - 1, 1);
  else if ((m > 0) && (n > 0)) return Ackermann(m - 1, Ackermann(m, n - 1));
  else return n + 1;
}

 