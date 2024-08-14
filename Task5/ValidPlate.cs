using fundamentos_desafio.Utils;
using System.Numerics;
using System.Text.RegularExpressions;

namespace fundamentos_desafio.Task5;
public class ValidPlate
{
    public void Execute()
    {
        var continueMessage = new ContinueMessage();

        Console.Clear();

        Console.WriteLine("Insira o número da placa:");
        string? inputPlateValue = Console.ReadLine();

        Console.Clear();

        if (!string.IsNullOrWhiteSpace(inputPlateValue))
        {
            var plate = inputPlateValue.Trim().Replace(" ", "");

            string padrao = @"^[a-zA-Z]{3}[0-9]{4}$";
            var validPlate = Regex.IsMatch(plate, padrao);

            if (plate.Length != 7 || !validPlate)
            {
                Console.WriteLine($"Placa {plate} é inválida!");
                continueMessage.Execute();

                return;
            }

            Console.WriteLine($"Placa {plate} é válida!");
            continueMessage.Execute();

            return;
        }

        Console.WriteLine("Nenhum valor foi inserido.");
        continueMessage.Execute();
    }
}
