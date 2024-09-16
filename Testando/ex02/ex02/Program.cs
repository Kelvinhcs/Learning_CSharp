namespace ex02;

class Program
{
    static void Main()
    {
        Console.WriteLine("Type one number: ");
        var typed = Console.ReadLine();
        var integer = int.Parse(typed);

        var x2 = integer * 2;
        var x3 = integer * 3;
        var squareroot = Math.Sqrt(integer);

        Console.WriteLine($"Your choice was {integer}");
        Console.WriteLine($"The double is {x2}");
        Console.WriteLine($"The triple is {x3}");
        Console.WriteLine($"And the square root is {squareroot}");
    }
}