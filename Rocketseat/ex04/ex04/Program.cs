using System.Numerics;

namespace ex04;
class Program
{
    static void Main()
    {
        int total = 0;
        Console.WriteLine("Type anything here: ");
        var letters = Console.ReadLine().Trim();
        
        foreach(var character in letters)
        {
            if (character == ' ')
                continue;
            else
                total++;
        }
        Console.WriteLine($"We count on total {total} characters.");
    }
}

