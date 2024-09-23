namespace LoopTest;

class Program
{
    static void Main()
    {
        string resposta;
        int times = 0;
        do
        {
            if (times >= 1) Console.WriteLine("Please type a valid answer!");
            Console.WriteLine($"Do you accept the offer [s/n]? ");
            resposta = Console.ReadLine();
            times++;
        }
        while (resposta != "s" && resposta != "n");
    }
}