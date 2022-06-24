// Задать массив размером "n"
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];


// пользовательский ввод массива
UserArray(numbers);

void UserArray(int[] num) 
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(i + " element: ");
        num[i] = Convert.ToInt32(Console.ReadLine());
    }
}


// рандомный ввод массива
SetArray(numbers);

void SetArray(int[] num) 
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(10);
    }
}


// вывод массива
OutArray(number);

void OutArray(int[] num) 
{
    for (int i = 0; i < num.Length; i++)
    Console.Write(num[i] + " ");
} 


// вывод массива в обратном порялдке
ReversArray(numbers);

void ReversArray(int[] num)
{
    for (int i = n - 1; i > -1; i--)
    {
         Console.Write(num[i] + " ");
    }
}
