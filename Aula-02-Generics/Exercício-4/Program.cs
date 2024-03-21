using System;
using Exercício_4;

// Definição da classe MeuServico
public class MeuServico : IServico
{
    public void Executar()
    {
        Console.WriteLine("Executando o serviço...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Criando uma instância da fábrica de serviços para a classe MeuServico
        ServicoFabrica<MeuServico> fabrica = new ServicoFabrica<MeuServico>();

        // Criando uma nova instância de MeuServico usando a fábrica
        MeuServico servico = fabrica.NovaInstancia();

        // Chamando o método Executar do serviço
        servico.Executar();
    }
}