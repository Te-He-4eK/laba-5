using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        string output = "";

        for (int i = 0; i < input.Length; i++)
        {
            output += input[i];

            if ((i + 1) % n == 0)
            {
                output += '*';
            }
        }

        Console.WriteLine(output);
    }
}
