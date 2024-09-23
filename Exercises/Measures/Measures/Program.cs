using System.Net.NetworkInformation;

namespace Measures;
class Program{
    static void Main(){
        Console.WriteLine("Measures converter!");
        Console.WriteLine("Please type something in meters to convert: ");
        var typed = Console.ReadLine();
        var meters = double.Parse(typed);

        var km = meters / 1000;
        var hm = meters / 100;
        var dam = meters / 10;

        var dm = meters * 10;
        var cm = meters * 100;
        var mm = meters * 1000;


        Console.WriteLine($"Here is our conversion results:");
        Console.WriteLine($"{km} kilometers");
        Console.WriteLine($"{hm} hectometer");
        Console.WriteLine($"{dam} decameters");
        Console.WriteLine($"{meters} m");
        Console.WriteLine($"{dm} decimeters");
        Console.WriteLine($"{cm} centimeters");
        Console.WriteLine($"{mm} milimeters");

    }
}