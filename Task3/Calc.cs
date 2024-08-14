using fundamentos_desafio.Utils;

namespace fundamentos_desafio.Task3;
public class Calc
{
    public void InsertData()
    {
        Console.Clear();

        var continueMessage = new ContinueMessage();
        double firstNumber = 0;
        double secondNumber = 0;

        int selectedChoice;

        Console.WriteLine("Por favor, insira o primeiro número:");
        var inputValueOne = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(inputValueOne))
        {
            _ = double.TryParse(inputValueOne, out firstNumber);
        }

        Console.Clear();

        Console.WriteLine("Por favor, insira o segundo número:");
        var inputValueTwo = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(inputValueTwo))
        {
            _ = double.TryParse(inputValueTwo, out secondNumber);
        }

        Console.Clear();

        if (firstNumber == 0 || !double.TryParse(inputValueOne, out _) || !double.TryParse(inputValueTwo, out _))
        {
            Console.WriteLine("Valor inserido inválido");
            continueMessage.Execute();

            return;
        }

        do
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Média");
            Console.WriteLine("0 - Sair");

            var inputValueChoice = Console.ReadLine();
            _ = int.TryParse(inputValueChoice, out selectedChoice);
            
            Console.Clear();

            switch (selectedChoice)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine($"A soma entre {firstNumber} e {secondNumber} é: {Sum(firstNumber, secondNumber)}");

                    continueMessage.Execute();
                    break;
                case 2:
                    Console.WriteLine($"A subtração entre {firstNumber} e {secondNumber} é: {Subtraction(firstNumber, secondNumber)}");

                    continueMessage.Execute();
                    break;
                case 3:
                    Console.WriteLine($"A multiplicação entre {firstNumber} e {secondNumber} é: {Multiplication(firstNumber, secondNumber)}");

                    continueMessage.Execute();
                    break;
                case 4:
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Divisão por 0 não é permitido.");

                        continueMessage.Execute();
                        break;
                    }
                    Console.WriteLine($"A divisão entre {firstNumber} e {secondNumber} é: {Division(firstNumber, secondNumber)}");

                    continueMessage.Execute();
                    break;
                case 5:
                    Console.WriteLine($"A média entre {firstNumber} e {secondNumber} é: {Average(firstNumber, secondNumber)}");

                    continueMessage.Execute();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"A opção escolhida não é válida: {selectedChoice}");

                    continueMessage.Execute();
                    break;
            }
        } while (selectedChoice > 0);

        Console.Clear();
    }

    private static double Sum(double firstNumber, double secondNumber)
    {
        return firstNumber + secondNumber;
    }

    private static double Subtraction(double firstNumber, double secondNumber)
    {
        return firstNumber - secondNumber;
    }

    private static double Multiplication(double firstNumber, double secondNumber)
    {
        return firstNumber * secondNumber;
    }

    private static double Division(double firstNumber, double secondNumber)
    {
        return firstNumber / secondNumber;
    }

    private static double Average(double firstNumber, double secondNumber)
    {
        return (firstNumber + secondNumber) / 2;
    }
}
