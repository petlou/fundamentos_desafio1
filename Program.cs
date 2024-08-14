using fundamentos_desafio.Task2;
using fundamentos_desafio.Task3;
using fundamentos_desafio.Task4;
using fundamentos_desafio.Task5;
using fundamentos_desafio.Task6;
using fundamentos_desafio.Utils;

namespace fundamentos_desafio;

class Program
{
    static void Main()
    {
        var continueMessage = new ContinueMessage();

        Console.WriteLine("Olá! Por favor, digite seu nome:");
        string? name = Console.ReadLine();
        Console.Clear();

        var message = string.IsNullOrWhiteSpace(name)
            ? "Olá! Seja muito bem-vindo!"
            : $"Olá, {name}! Seja muito bem-vindo!";

        Console.WriteLine(message);

        Console.WriteLine();
        Console.WriteLine("----------------------");
        Console.WriteLine();

        continueMessage.Execute();

        int selectedChoice;

        do
        {
            Console.Clear();

            Console.WriteLine("Escolha abaixo o que deseja fazer:");
            Console.WriteLine();
            Console.WriteLine("1 - Concatenar nome e sobrenome");
            Console.WriteLine("2 - Calcular dois números");
            Console.WriteLine("3 - Calcular caracteres de uma frase ou palavra");
            Console.WriteLine("4 - Validar placa");
            Console.WriteLine("5 - Data atual formatada");
            Console.WriteLine("0 - Sair");

            var inputSelectChoice = Console.ReadLine();
            _ = int.TryParse(inputSelectChoice, out selectedChoice);

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
                case 3:
                    var calcLength = new CalcLength();
                    calcLength.Execute();
                    break;
                case 4:
                    var validPlate = new ValidPlate();
                    validPlate.Execute();
                    break;
                case 5:
                    var formatedDate = new DateFormated();
                    formatedDate.Execute();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"A opção escolhida não é válida: {selectedChoice}");
                    
                    continueMessage.Execute();
                    break;
            }
        }
        while (selectedChoice > 0);

        Console.Clear();
        Console.WriteLine("O Programa foi encerrado!");
    }
}
