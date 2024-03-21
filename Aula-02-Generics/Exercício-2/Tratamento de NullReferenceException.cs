namespace DefaultNamespace;

public class Tratamento_de_NullReferenceException
{
try
{
    object o = null;
    o.ToString();
}
catch (NullReferenceException ex)
{
    Console.WriteLine("O objeto é nulo. Não é possível chamar o método ToString().");
}
}