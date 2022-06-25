double num1 = InputNumber("Enter number 1: ");
double num2 = InputNumber("Enter number 2: ");
string msg1 = InputStrings("Enter string 1: ");
string msg2 = InputStrings("Enter string 2: ");

Console.WriteLine(num1 + " = " + num2 + ": " + CompareNumbers(num1, num2));
Console.WriteLine(msg1 + " = " + msg2 + ": " + CompareStrings(msg1, msg2));
ArithneticOperation(num1, num2);

Console.Write($"{num1} to the power {num2} = ");
PowerNumber(num1, num2);
Console.Write($"{num2} to the power {num1} = ");
PowerNumber(num2, num1);


void PowerNumber(double a, double b) //возведение числа "a" в степень "b"
{
    double power = 1;
    for (int i = 0; i < b; i++)
    {
         power *= a;
    }
    Console.WriteLine(power + ";");
}

void ArithneticOperation(double a, double b) //операции с числами "a" и "b"
{
    Console.WriteLine($"{a} + {b} = {a + b};");
    Console.WriteLine($"{a} - {b} = {a - b};");
    Console.WriteLine($"{b} - {a} = {b - a};");
    Console.WriteLine($"{a} * {b} = {a * b};");
    Console.WriteLine($"{a} / {b} = {a / b};");
    Console.WriteLine($"{b} / {a} = {b / a};");
    Console.WriteLine($"{a} squared = {a * a};");
    Console.WriteLine($"{b} squared = {b * b};");
    Console.WriteLine($"{a} cubed = {a * a * a};");
    Console.WriteLine($"{b} cubed = {b * b * b};");
    Console.WriteLine($"square root {a} = {Math.Sqrt(a)};");
    Console.WriteLine($"square root {b} = {Math.Sqrt(b)};");
}

bool CompareStrings(string a, string b) //сравнение строк
{
    return a == b;
}

string InputStrings(string a) //строчный ввод
{
    Console.Write(a);
    return Console.ReadLine();
}

bool CompareNumbers(double a, double b) //сравнение чисел
{
    return a == b;
}

double InputNumber(string a) //ввод чисел
{
    Console.Write(a);
    return Convert.ToInt32(Console.ReadLine());
}



// Сравнение чисел: false или true
int a = 2;
int b = 4;

bool CheckInt(int a, int b)
{
    return a == b;
} 

Console.WriteLine(CheckInt(a, b)); 


// Сравнение строк (для string только "==")
// false или true
string c = "text";
string d = "text";

bool CheckString(string a, string b)
{
    return a == b;
} 

Console.Write(CheckString(c, d));
