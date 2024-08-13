using fundamentos_desafio.Task2;
using fundamentos_desafio.Task3;

namespace fundamentos_desafio;

class Program
{
    static void Main()
    {
        Console.WriteLine("Olá! Por favor, digite seu nome:");
        string? name = Console.ReadLine();
        Console.Clear();

        Console.WriteLine($"Olá, {name}! Seja muito bem - vindo!");
        Console.WriteLine();
        Console.WriteLine("----------------------");
        Console.WriteLine();
        Console.WriteLine("Para continuar, pressione ENTER");
        Console.ReadLine();
        Console.Clear();

        int selectedChoice;

        do
        {
            Console.Clear();

            Console.WriteLine("Escolha abaixo o que deseja fazer:");
            Console.WriteLine();
            Console.WriteLine("1 - Concatenar nome e sobrenome");
            Console.WriteLine("2 - Calcular números");
            Console.WriteLine("0 - Sair");

            selectedChoice = int.Parse(Console.ReadLine());

            switch (selectedChoice)
            {
                case 0:
                    break;
                case 1:
                    var concat = new ConcatName();
                    concat.Concat();
                    break;
                case 2:
                    var calc = new Calc();
                    calc.InsertData();                    
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"A opção escolhida não é válida: {selectedChoice}");
                    Console.WriteLine("Para continuar, pressione ENTER");
                    Console.ReadLine();
                    break;
            }
        }
        while (selectedChoice > 0);

        Console.Clear();
        Console.WriteLine("O Programa foi encerrado!");
    }
}