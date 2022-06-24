
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
