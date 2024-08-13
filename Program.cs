using fundamentos_desafio.Task1;

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

        int numberSelected;

        do
        {
            Console.Clear();

            Console.WriteLine("Escolha abaixo o que deseja fazer:");
            Console.WriteLine();
            Console.WriteLine("1 - Concatenar nome e sobrenome");
            Console.WriteLine("0 - Sair");

            numberSelected = int.Parse(Console.ReadLine());
            Console.WriteLine(numberSelected);

            switch (numberSelected)
            {
                case 0:
                    break;
                case 1:
                    var concat = new ConcatName();
                    concat.Concat();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"A opção escolhida não é válida: {numberSelected}");
                    Console.WriteLine("Para continuar, pressione ENTER");
                    Console.ReadLine();
                    break;
            }
        }
        while (numberSelected > 0);

        Console.Clear();
        Console.WriteLine("O Programa foi encerrado!");
    }
}