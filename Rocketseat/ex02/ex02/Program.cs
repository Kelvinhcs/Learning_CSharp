namespace ex02;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please type your first name:");
        var firstname = Console.ReadLine().Trim();
        Console.WriteLine("Now, type your last name:");
        var lastname = Console.ReadLine().Trim();
        Console.WriteLine($"I see, your name is {firstname} {lastname}. It's a pleasure to meet you!");
    }
}