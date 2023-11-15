using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Lista para armazenar tarefas
    static List<Task> tasks = new List<Task>();

    // Método principal onde a execução do programa começa
    static void Main()
    {
        while (true)
        {
            // Exibição das opções de menu
            Console.WriteLine("1. Criar Tarefa");
            Console.WriteLine("2. Listar Tarefas");
            Console.WriteLine("3. Marcar Tarefa como Concluída");
            Console.WriteLine("4. Listar Tarefas Pendentes");
            Console.WriteLine("5. Listar Tarefas Concluídas");
            Console.WriteLine("6. Excluir Tarefa");
            Console.WriteLine("7. Pesquisar Tarefas por Palavra-chave");
            Console.WriteLine("8. Exibir Estatísticas");
            Console.WriteLine("9. Sair");

            int choice = GetChoice();

            switch (choice)
            {
                case 1:
                    CreateTask();
                    break;
                case 2:
                    ListAllTasks();
                    break;
                case 3:
                    MarkTaskAsCompleted();
                    break;
                case 4:
                    ListPendingTasks();
                    break;
                case 5:
                    ListCompletedTasks();
                    break;
                case 6:
                    DeleteTask();
                    break;
                case 7:
                    SearchTasksByKeyword();
                    break;
                case 8:
                    DisplayStatistics();
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    break;
            }
        }
    }

    // Método para obter a escolha do usuário
    static int GetChoice()
    {
        Console.Write("Escolha uma opção: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                return choice;
            }
            else
            {
                Console.Write("Escolha inválida. Digite novamente: ");
            }
        }
    }

    // Método para criar uma nova tarefa
    static void CreateTask()
    {
        Console.Write("Título da Tarefa: ");
        string title = Console.ReadLine();

        Console.Write("Descrição da Tarefa: ");
        string description = Console.ReadLine();

        Console.Write("Data de Vencimento (YYYY-MM-DD): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine() ?? throw new ArgumentNullException("s"));

        Task task = new Task(title ?? throw new ArgumentNullException("title"), description ?? throw new ArgumentNullException("description"), dueDate);
        tasks.Add(task);

        Console.WriteLine($"Tarefa '{title}' criada com sucesso! (Número: {tasks.Count})");
    }

    // Método para listar todas as tarefas
    static void ListAllTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Não há tarefas cadastradas.");
            return;
        }

        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    // Método para marcar uma tarefa como concluída
    static void MarkTaskAsCompleted()
    {
        Console.Write("Digite o número da tarefa a ser marcada como concluída: ");
        int taskNumber = GetChoice();

        if (taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks[taskNumber - 1].MarkAsCompleted();
            Console.WriteLine($"Tarefa '{tasks[taskNumber - 1].Title}' marcada como concluída com sucesso!");
        }
        else
        {
            Console.WriteLine("Número de tarefa inválido.");
        }
    }

    // Método para listar tarefas pendentes
    static void ListPendingTasks()
    {
        var pendingTasks = tasks.FindAll(task => !task.IsCompleted);
        if (pendingTasks.Count == 0)
        {
            Console.WriteLine("Não há tarefas pendentes.");
            return;
        }

        foreach (var task in pendingTasks)
        {
            Console.WriteLine(task);
        }
    }

    // Método para listar tarefas concluídas
    static void ListCompletedTasks()
    {
        var completedTasks = tasks.FindAll(task => task.IsCompleted);
        if (completedTasks.Count == 0)
        {
            Console.WriteLine("Não há tarefas concluídas.");
            return;
        }

        foreach (var task in completedTasks)
        {
            Console.WriteLine(task);
        }
    }

    // Método para excluir uma tarefa
    static void DeleteTask()
    {
        Console.Write("Digite o número da tarefa a ser excluída: ");
        int taskNumber = GetChoice();

        if (taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine("Tarefa excluída com sucesso!");
        }
        else
        {
            Console.WriteLine("Número de tarefa inválido.");
        }
    }

    // Método para pesquisar tarefas por palavra-chave
    static void SearchTasksByKeyword()
    {
        Console.Write("Digite uma palavra-chave para pesquisa: ");
        string keyword = Console.ReadLine().ToLower();

        var matchingTasks = tasks.FindAll(task => task.Title.ToLower().Contains(keyword) || task.Description.ToLower().Contains(keyword));
        if (matchingTasks.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa correspondente encontrada.");
            return;
        }

        foreach (var task in matchingTasks)
        {
            Console.WriteLine(task);
        }
    }

    // Método para exibir estatísticas
    static void DisplayStatistics()
    {
        int totalTasks = tasks.Count;
        int completedTasks = tasks.Count(task => task.IsCompleted);
        int pendingTasks = totalTasks - completedTasks;

        Console.WriteLine($"Total de Tarefas: {totalTasks}");
        Console.WriteLine($"Tarefas Concluídas: {completedTasks}");
        Console.WriteLine($"Tarefas Pendentes: {pendingTasks}");

        if (completedTasks > 0)
        {
            var oldestTask = tasks.OrderBy(task => task.DueDate).FirstOrDefault();
            var newestTask = tasks.OrderByDescending(task => task.DueDate).FirstOrDefault();

            Console.WriteLine($"Tarefa Mais Antiga: {oldestTask}");
            Console.WriteLine($"Tarefa Mais Recente: {newestTask}");
        }
    }
}

class Task
{
    // Propriedades da tarefa
    public string Title { get; }
    public string Description { get; }
    public DateTime DueDate { get; }
    public bool IsCompleted { get; private set; }

    // Construtor da classe Task
    public Task(string title, string description, DateTime dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsCompleted = false;
    }

    // Método para marcar a tarefa como concluída
    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }

    // Sobrescreve o método ToString para exibir informações da tarefa
    public override string ToString()
    {
        return $"Tarefa: {Title}\nDescrição: {Description}\nData de Vencimento: {DueDate}\nStatus: {(IsCompleted ? "Concluída" : "Pendente")}\n";
    }
}

