namespace ex04;
class Program
{
    static void Main()
    {
        int X = 1;
        double? first = null;
        double? second = null;
        while (X < 3)
        {
            Console.WriteLine($"Type the {X} value: ");
            var placeholder = Console.ReadLine();
            if (double.TryParse(placeholder, out var result))
            {
                if (X == 1)
                {
                    first = result;
                }
                else if (X == 2)
                {
                    second = result;
                }
                X++;
            }
            else
            {
                Console.WriteLine("Invalid type, try again please...");
                continue;
            }
        }
        Console.WriteLine($"You corectly type those 2 number: {first} and {second}");
    }
}

