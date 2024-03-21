using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Inicia as duas tarefas simultâneas
        Task task1 = DoWorkAsync("Tarefa 1");
        Task task2 = DoWorkAsync("Tarefa 2");

        // Aguarda a conclusão de ambas as tarefas
        await Task.WhenAll(task1, task2);

        // Imprime uma mensagem indicando que ambas as tarefas foram concluídas
        Console.WriteLine("Ambas as tarefas foram concluídas.");
    }

    static async Task DoWorkAsync(string taskName)
    {
        Console.WriteLine($"Iniciando a {taskName}");

        // Simula algum tipo de trabalho realizando um loop com Task.Delay
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Progresso da {taskName}: {i}/5");
            await Task.Delay(1000); // Simula um tempo de espera de 1 segundo entre cada iteração
        }

        Console.WriteLine($"A {taskName} foi concluída.");
    }
}