using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();

        int count = CountLetterA(input);
        Console.WriteLine($"A letra 'a' aparece {count} vezes na string.");
    }

    static int CountLetterA(string text)
    {
        int count = 0;

        string lowerText = text.ToLower();

        foreach (char c in lowerText)
        {
            if (c == 'a')
            {
                count++;
            }
        }

        return count;
    }
}