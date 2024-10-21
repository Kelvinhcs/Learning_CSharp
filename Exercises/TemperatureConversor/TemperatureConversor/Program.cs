namespace TemperatureConversor;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("[1] Celsius [2] Fahrenheit [3] Kelvin");
            var option = ValidationIntWithRange("Please choose the original temperature:");
            var temperature = ValidationFloat("Type the temperature: ");
            Console.WriteLine("[1] Celsius [2] Fahrenheit [3] Kelvin");
            var convertion = ValidationIntWithRange("What temperature do you want to convert to:");


            // Its time to put the real logic on the code but now im just want to sleep
            // I alredy have the original temperature, the real temperature and the one the user want's to convert, just have to convert to the new based on the original one. :)



        }
    }




    static float ValidationIntWithRange(string message)
    {
        while (true)
        {
            int result;
            Console.WriteLine(message);
            var typed = Console.ReadLine();
            while(!int.TryParse(typed, out result))
            {
                Console.WriteLine("Please type a valid option...");
                typed = Console.ReadLine();
            }
            if (result != 1 && result != 2 && result != 3)
                continue;
            else
                return result;
        }
    }
    
    
    
    
    
    static float ValidationFloat(string message)
    {
        float result;
        Console.WriteLine(message);
        var typed = Console.ReadLine();
        while(!float.TryParse(typed, out result))
        {
            Console.WriteLine("Please type a valid option...");
            typed = Console.ReadLine();
        }
        return result;
    }
}