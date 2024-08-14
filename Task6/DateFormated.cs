using fundamentos_desafio.Utils;

namespace fundamentos_desafio.Task6;
public class DateFormated
{
    public void Execute()
    {
        Console.Clear();

        var continueMessage = new ContinueMessage();
        DateTime dataAtual = DateTime.Now;

        Console.WriteLine("Abaixo todos os formatos de data:");
        Console.WriteLine();
        Console.WriteLine("Formato completo: " + dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
        Console.WriteLine("Apenas a data: " + dataAtual.ToString("dd/MM/yyyy"));
        Console.WriteLine("Apenas a hora: " + dataAtual.ToString("HH:mm"));
        Console.WriteLine("Data com mês por extenso: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy"));
        Console.WriteLine();

        continueMessage.Execute();
    }
}
