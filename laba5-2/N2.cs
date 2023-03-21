using System;

class N2
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length == 4)
            {
                words[i] = "love_Is";
            }
        }

        string output = string.Join(" ", words);

        Console.WriteLine(output);
        Console.ReadKey();
    }
}