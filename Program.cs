namespace fundamentos_desafio;

class Program
{
    static void Main()
    {
        Console.WriteLine("Olá! Por favor, digite seu nome:");
        string? name = Console.ReadLine();
        Console.Clear();

        Console.WriteLine($"Olá, {name}! Seja muito bem - vindo!");
    }
}