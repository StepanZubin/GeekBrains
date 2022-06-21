// Yes or No Square 
Console.Clear();
Console.Write("Введите число a: ");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int number_b = Convert.ToInt32(Console.ReadLine());

if (number_a == number_b * number_b)
    Console.Write(number_a + " является квадратом " + number_b);
else 
    Console.Write(number_a + " не является квадратом " + number_b);
