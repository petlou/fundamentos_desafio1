using fundamentos_desafio.Utils;

namespace fundamentos_desafio.Task4;
public class CalcLength
{
    public void Execute()
    {
        var continueMessage = new ContinueMessage();

        Console.Clear();

        Console.WriteLine("Insira uma frase ou palavra:");
        string? inputValue = Console.ReadLine();

        Console.Clear();

        if (!string.IsNullOrWhiteSpace(inputValue))
        {
            Console.WriteLine($"A frase contém {inputValue.Trim().Length} caracteres.");
            Console.WriteLine($"Removendo os espaços a frase contém {inputValue.Trim().Replace(" ", "").Length} caracteres.");
            Console.WriteLine();

            continueMessage.Execute();

            return;
        }
        
        Console.WriteLine("Nenhum valor foi inserido.");
        continueMessage.Execute();
    }
}
