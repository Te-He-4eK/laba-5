using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите предложение: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');

        string shortestWord = words[0];
        string longestWord = words[0];

        foreach (string word in words)
        {
            if (word.Length < shortestWord.Length)
            {
                shortestWord = word;
            }

            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        string output = "";

        for (int i = 0; i < shortestWord.Length+longestWord.Length; i++)
        {
            output += shortestWord + "," + longestWord + ",";
        }

        output = output.Substring(0, output.Length - 1);

        Console.WriteLine(output);
    }
}
