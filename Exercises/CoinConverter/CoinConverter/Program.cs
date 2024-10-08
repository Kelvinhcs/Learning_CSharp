namespace CoinConverter;
class Program
{
    static void Main()
    {
        var usdPrice = 5.43;
        while (true)
        {
            Console.WriteLine("Type a value in R$: ");
            var insertedValue = Console.ReadLine();
            if (!double.TryParse(insertedValue, out var convertedValue))
            {
                Console.WriteLine("You typed an invalid format, please try again.");
                continue;
            }
            else
            {
                var dolars = convertedValue * usdPrice;
                Console.WriteLine($"R${convertedValue:F} = US${dolars:F}");
                break;
            }
        }
    }
}