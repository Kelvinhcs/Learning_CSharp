namespace ex03;
class Program
{
    static void Main()
    {
        int x = 1;
        double? first = null;
        double? second = null;
        while (x < 3)
        {
            Console.WriteLine($"Type the {x} value: ");
            var placeholder = Console.ReadLine();
            if (double.TryParse(placeholder, out var result))
            {
                if (x == 1)
                {
                    first = result;
                }
                else if (x == 2)
                {
                    second = result;
                }
                x++;
            }
            else
            {
                Console.WriteLine("Invalid type, try again please...");
                continue;
            }
        }

        var average = (first + second) / 2;

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