using System.Runtime.InteropServices;

namespace TestingFunctions;
public class Program{
    static void Main(){

        var addtest = new MathFunc();

        var (resultado, autor) = addtest.Adding(FirstValue:5, SecondValue:2);
        
        Console.WriteLine(resultado);
        Console.WriteLine(autor); 
    }
}