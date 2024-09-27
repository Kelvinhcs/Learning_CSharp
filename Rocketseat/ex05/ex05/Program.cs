namespace ex05;
class Program
{
    static void Main()
    {
        Console.WriteLine("Insert the Brazillian vechile plate:");
        var plate = Console.ReadLine();

        if (plate.Length == 7)
        {
            bool isValid = true;
            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(plate[i]))
                {
                    isValid = false;
                    break;
                }
            }

            for (int i = 3; i < 7; i++)
            {
                if (!char.IsDigit(plate[i]))
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
                Console.WriteLine("Relaxa paizao, fica tranquilo");

            else
                Console.WriteLine("Mamou!");
        }

        else
            Console.WriteLine("Você deve digitar exatamente 7 caracteres");
    }
}