namespace HelloWorld;
class Program
{
    static void Main()
    {
        int? nivel = null;

        var valor = nivel.HasValue;

        Console.WriteLine(valor);
        Console.WriteLine(nivel);
        Console.WriteLine("End!");

    }
}