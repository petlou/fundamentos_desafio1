namespace fundamentos_desafio.Task3;
public class Calc
{
    public void InsertData()
    {
        Console.Clear();

        Console.WriteLine("Por favor, insira o primeiro número:");
        double firstNumber= double.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Por favor, insira o segundo número:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Clear();

        int selectedChoice;

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

            selectedChoice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (selectedChoice)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine($"A soma entre {firstNumber} e {secondNumber} é: {Sum(firstNumber, secondNumber)}");
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine($"A subtração entre {firstNumber} e {secondNumber} é: {Subtraction(firstNumber, secondNumber)}");
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine($"A multiplicação entre {firstNumber} e {secondNumber} é: {Multiplication(firstNumber, secondNumber)}");
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ReadLine();
                    break;
                case 4:
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Divisão por 0 não é permitido.");
                        Console.WriteLine("Presione ENTER para continuar");
                        Console.ReadLine();
                        break;
                    }
                    Console.WriteLine($"A divisão entre {firstNumber} e {secondNumber} é: {Division(firstNumber, secondNumber)}");
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine($"A média entre {firstNumber} e {secondNumber} é: {Average(firstNumber, secondNumber)}");
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ReadLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"A opção escolhida não é válida: {selectedChoice}");
                    Console.WriteLine("Para continuar, pressione ENTER");
                    Console.ReadLine();
                    break;
            }
        } while (selectedChoice > 0);

        Console.Clear();
    }

    private double Sum(double firstNumber, double secondNumber)
    {
        return firstNumber + secondNumber;
    }

    private double Subtraction(double firstNumber, double secondNumber)
    {
        return firstNumber - secondNumber;
    }

    private double Multiplication(double firstNumber, double secondNumber)
    {
        return firstNumber * secondNumber;
    }

    private double Division(double firstNumber, double secondNumber)
    {
        return firstNumber / secondNumber;
    }

    private double Average(double firstNumber, double secondNumber)
    {
        return (firstNumber + secondNumber) / 2;
    }
}
