// Square
Console.Clear();
Console.Write("Введите целое число: ");
string input = Console.ReadLine(); // Считывает пользовательский вид
int number = Convert.ToInt32(input); 

int result = number * number;

Console.WriteLine(number + " в квадрате равно " + result);
