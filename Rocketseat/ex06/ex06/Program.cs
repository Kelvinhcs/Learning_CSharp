namespace ex06;
class Program
{
    static void Main(string[] args)
    {
        // Obtém a data e hora atual
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("Selecione o formato para exibição da data:");
        Console.WriteLine("1. Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
        Console.WriteLine("2. Apenas a data (dd/MM/yyyy).");
        Console.WriteLine("3. Apenas a hora (formato 24 horas).");
        Console.WriteLine("4. A data com o mês por extenso.");

        // Recebe a escolha do usuário
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                // Formato completo
                Console.WriteLine(currentDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
                break;
            case "2":
                // Apenas a data no formato "01/03/2024"
                Console.WriteLine(currentDate.ToString("dd/MM/yyyy"));
                break;
            case "3":
                // Apenas a hora no formato de 24 horas
                Console.WriteLine(currentDate.ToString("HH:mm"));
                break;
            case "4":
                // A data com o mês por extenso
                Console.WriteLine(currentDate.ToString("dd 'de' MMMM 'de' yyyy"));
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
