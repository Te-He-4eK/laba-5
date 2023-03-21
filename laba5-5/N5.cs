using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите предложение: ");
        string input= Console.ReadLine();
        string[] words = input.Split(' ');
        string output = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (!words.Take(i).Contains(words[i]))
            {
                output += words[i] + " ";
            }
        }
        Console.WriteLine(output.TrimEnd());
    }
}

