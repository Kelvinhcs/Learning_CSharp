using System.Security.Cryptography.X509Certificates;

namespace ex01;

class Program
{
    static void Main()
    {
        Console.WriteLine("Type your age: ");
        var age = Console.ReadLine();
        var intage = int.Parse(age);
        var nextyearage = intage + 1;

        Console.WriteLine($"Next year your age is goig to be {nextyearage} years old!");
        Console.WriteLine($"This year you have {intage} year old");

    }
}
