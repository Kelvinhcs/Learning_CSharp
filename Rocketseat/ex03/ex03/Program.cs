namespace ex03;
class Program
{
    static void Main()
    {
        double first = 0;
        string response;
        do
        {
            Console.WriteLine("Please type the first number: ");
            var response = Console.ReadLine();
        }
        while (response.GetType() != )
        var first = Console.ReadLine();
        var second = Console.ReadLine();
        
        double average = (first + second) / 2;


        Console.WriteLine("We are now showing the results!");
        Console.WriteLine($"{first} + {second} = {first + second:F2}");
        Console.WriteLine($"{first} - {second} = {first - second:F2}");
        if (second == 0)
        {
            Console.WriteLine("The second number is 0, meaning the multiplication always results 0");
            Console.WriteLine("The second number is 0, meaning the division doesn't exist");
        }
        else
        {
            Console.WriteLine($"{first} X {second} = {first * second:F2}");
            Console.WriteLine($"{first} / {second} = {first / second:F2}");
        }
        Console.WriteLine($"The average of these 2 numbers is {average:F2}");
    }
}

// UNFINISHED PROJECT, I JUST NEED TO SLEEP IS ALMOST 1 AM SORRY