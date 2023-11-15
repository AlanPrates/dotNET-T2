// Task.cs
public class Task
{
    public string Title { get; }
    public string Description { get; }
    public DateTime DueDate { get; }
    public bool IsCompleted { get; private set; }

    public Task(string title, string description, DateTime dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsCompleted = false;
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }

    public override string ToString()
    {
        return $"Tarefa: {Title}\nDescrição: {Description}\nData de Vencimento: {DueDate}\nStatus: {(IsCompleted ? "Concluída" : "Pendente")}\n";
    }
}
