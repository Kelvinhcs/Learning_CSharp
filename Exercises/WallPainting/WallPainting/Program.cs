using System.Threading.Channels;

namespace WallPainting;
class Program
{
    static void Main()
    {
        Console.WriteLine("Largura: ");
        var largura = Console.ReadLine();
        Console.WriteLine("Altura: ");
        var altura = Console.ReadLine();

        var larguraConvert = double.Parse(largura);
        var alturaConvert = double.Parse(altura);
        var area = larguraConvert * alturaConvert;



    }
}