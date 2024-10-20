namespace Calculator;
class Program
{
    static void Main()
    {
        Console.WriteLine("-=-=-=- Welcome to my simple calculator!!! -=-=-=-");
        while (true) 
        { 
            float result;
            var first = ValidationFloat("Type the First number:");
            var second = ValidationFloat("Type the Second Number: ");
            Console.WriteLine("[1] Add [2] Subtract [3] Divide [4] Multiply");
            var choice = ValidationFloat("What is your choice?");
            Console.WriteLine();
            switch (choice) 
            {
                case 1:
                    result = first + second;
                    Console.WriteLine($"{first} + {second} = {result}");
                    break;
                case 2:
                    result = first - second;
                    Console.WriteLine($"{first} - {second} = {result}");
                    if (second > first)
                        Console.WriteLine("If you remove more than this number has it will be negative");
                    break;
                case 3:
                    result = second == 0 ? 0 : first / second;
                    Console.WriteLine($"{first} / {second} = {result}");
                    if (second == 0)
                        Console.WriteLine("Every number divided by 0 is equals to 0.");
                    break;
                case 4:
                    result = first * second;
                    Console.WriteLine($"{first} * {second} = {first * second}");
                    if (second == 0)
                        Console.WriteLine("Every number multiplied by 0 is equals to 0. ");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("[1] Keep using [2] Exit the program");
            choice = ValidationInt("What is your choice?");
            if (choice == 2)
                break;
            Console.WriteLine();
        }
    }

    static float ValidationFloat(string message)
    {
        float result;
        Console.WriteLine(message);
        var typed = Console.ReadLine();
        while(!float.TryParse(typed, out result))
        {
            Console.WriteLine("Please, type a valid option!");
            typed = Console.ReadLine();
        }
        return result;

    }static int ValidationInt(string message)
    {
        int result;
        Console.WriteLine(message);
        var typed = Console.ReadLine();
        while(!int.TryParse(typed, out result))
        {
            Console.WriteLine("Please, type a valid option!");
            typed = Console.ReadLine();
        }
        return result;
    }
}
