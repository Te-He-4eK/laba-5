using System;

class N1
{
    static void Main(string[] args)
    {
        Console.Write("Введите список имен через пробел: ");
        string namesString = Console.ReadLine();

        string[] names = namesString.Split(' ');

        Array.Sort(names);

        Console.WriteLine("Имена, стоящие в алфавитном порядке раньше имени \"Маша\":");

        foreach (string name in names)
        {
            if (string.Compare(name, "Маша") < 0)
            {
                Console.WriteLine(name);
            }
        }
    }
}

