
class ContaBancaria
{
    private decimal saldo;

    // Propriedade Saldo com lógica personalizada para evitar saldos negativos
    public decimal Saldo
    {
        get { return saldo; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Saldo não pode ser negativo");
            }
            saldo = value;
        }
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria minhaConta = new ContaBancaria();

        try
        {
            // Solicita ao usuário para inserir o saldo desejado
            Console.Write("Digite o saldo inicial da conta: ");
            decimal saldoInicial = decimal.Parse(Console.ReadLine());

            // Tenta definir o saldo inserido
            minhaConta.Saldo = saldoInicial;

            // Exibe o saldo atual
            Console.WriteLine($"Saldo atual: {minhaConta.Saldo}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Valor inválido inserido. Certifique-se de inserir um número válido.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
