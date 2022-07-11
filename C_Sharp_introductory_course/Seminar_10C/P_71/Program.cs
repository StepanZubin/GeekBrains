// Задача 71. В некотором машинном алфавите имеются 
// четыре буквы "а", "и", "с", "в". Показать все 
// слова, состоящии из n букв, которые можно построить 
// из букв этого алфавита: n = 2 -> 
// аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс

string charsWords = "аисв";
Console.Write("Enter count chars in words: ");
int countCharsInWords = Convert.ToInt32(Console.ReadLine());
PrintAllWords(charsWords, countCharsInWords, "");


void PrintAllWords(string alphabet, int length, string prefix) //перфикс - начало строки
{
    if (length == 0) Console.Write(prefix + " ");
    else 
    {
        for (int i = 0; i < alphabet.Length; i++)
        {
            PrintAllWords(alphabet, length - 1, prefix + alphabet[i]);
        }
    }
}