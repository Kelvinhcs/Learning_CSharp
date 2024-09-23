namespace ex01;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please, type your name");
        var name = Console.ReadLine().Trim();
        Console.WriteLine($"Welcome abord captain {name}!");
    }
}