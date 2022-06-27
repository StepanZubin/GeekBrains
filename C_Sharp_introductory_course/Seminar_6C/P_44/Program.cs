// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1. Если N = 5 -> 0 1 1 2 3; 
// Если N = 3 -> 0 1 1;  Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
int N = Input("Enter size array: ");
int[] array = new int[N];

if(N > 0)
{
    array[0] = 0;
}
if(N > 1)
{
    array[1] = 1;
}

for(int i = 2; i < array.Length; i++)
{
    array[i] = array[i - 1] + array[i - 2];
}

Console.Write("Если N = " + N + " -> ");

for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}


int Input(string a)
{   
    Console.Write(a);
    return Convert.ToInt32(Console.ReadLine());
}

