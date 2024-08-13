namespace fundamentos_desafio.Task2;
public class ConcatName
{
    public void Concat()
    {
        Console.Clear();

        Console.WriteLine("Por favor, digite o primeiro nome:");
        string? name = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Por favor, digite o sobrenome:");
        string? lastName = Console.ReadLine();
        Console.Clear();

        Console.WriteLine($"{name} {lastName}");
        Console.WriteLine();
        Console.WriteLine("Presione ENTER para voltar para o Menu anterior");
        Console.ReadLine();
        Console.Clear();
    }
}
