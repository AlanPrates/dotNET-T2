using System;
using Exercício_3;

public class Program
{
    public static void Main(string[] args)
    {
        // Mostra as opções de exercícios existentes
        Console.WriteLine("Opções de exercícios:");
        foreach (Exercicio opcao in Enum.GetValues(typeof(Exercicio)))
        {
            Console.WriteLine($"{(int)opcao}: {opcao}");
        }

        // Solicita ao usuário a digitação de um exercício
        Console.Write("Digite o número do exercício (1, 2 ou 3): ");
        string input = Console.ReadLine();

        try
        {
            // Converte a entrada para um número inteiro
            int numeroExercicio = int.Parse(input);

            // Verifica se o número está dentro do intervalo esperado
            if (numeroExercicio >= 1 && numeroExercicio <= 3)
            {
                // Converte o número do exercício para o enum correspondente
                Exercicio exercicioSelecionado = (Exercicio)numeroExercicio;

                // Mostra o nome do exercício associado à opção digitada
                Console.WriteLine($"Exercício selecionado: {exercicioSelecionado}");
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, digite um número válido (1, 2 ou 3).");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato inválido. Por favor, digite um número válido (1, 2 ou 3).");
        }
    }
}