// array of strings

string[] arrayInput = new string[4] {"hello", "2", "world", ":-)"};
int size = 0;

int indexInput = 0;
int indexOutput = 0; 
   
while (indexInput < arrayInput.Length)
{
    if (arrayInput[indexInput].Length <= 3)
    {
        size++;
    }
    indexInput++;
}

string[] arrayOutput = new string[size];
indexInput = 0;
while (indexInput < arrayInput.Length)
{
    if (arrayInput[indexInput].Length <= 3)
    {
        arrayOutput[indexOutput] = arrayInput[indexInput];
        indexOutput++;
    }
    indexInput++;
}

PrintStringArray(arrayInput);
Console.Write(" -> ");
PrintStringArray(arrayOutput);

void PrintStringArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}