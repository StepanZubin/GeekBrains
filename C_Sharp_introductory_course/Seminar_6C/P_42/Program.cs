// Задача 42: Написать программу, которая будет 
//преобразовывать десятичное число в двоичное.
//45 -> 101101 3  -> 11 2  -> 10

//Решение с использованием строки
Console.Clear();
int number = Input("Enter number: ");
string digit = string.Empty; //обозначает пустую строку, вместо: ""

while(number > 0)
{
  //digit = Convert.ToString(number % 2) + digit;
    digit = number % 2 + digit; //при конкотенации конвертация автоматическая
    number /= 2; 
}
Console.WriteLine(digit);


int Input(string a)
{
    Console.Write(a);
    return Convert.ToInt32(Console.ReadLine());
}
