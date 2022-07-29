void WordsThree (string[] mass1, string[] mass2)
{
    int count = 0;
    for (int i = 0; i < mass1.Length; i++)
    {
    if(mass1[i].Length <= 3)
        {
        mass2[count] = mass1[i];
        count++;
        }
    }
}

void PrintArray(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write (mass[i] + " ");
    }
    Console.WriteLine();
}

string [] words = {"hello", "2", "world", ":-)"};
string [] newWords = new string[words.Length];

WordsThree(words, newWords);

PrintArray(words);
PrintArray(newWords);
