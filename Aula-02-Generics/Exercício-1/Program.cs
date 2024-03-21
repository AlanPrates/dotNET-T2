using System;
using Exercício;


public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            ContaBancaria contaAlan = new ContaBancaria(1000);
            ContaBancaria contaZé = new ContaBancaria(500);

            // Transações corretas
            contaAlan.Depositar(500);
            contaAlan.Sacar(200);
            contaAlan.Transferir(300, contaZé);

            // Transações que geram exceção
            contaAlan.Depositar(-100); // Valor inválido
            contaAlan.Sacar(1500);     // Saldo insuficiente

        }
        catch (ValorInvalidoException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
            Console.WriteLine("Valor inválido: " + ex.ValorInvalido);
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
            Console.WriteLine("Saldo disponível: " + ex.SaldoDisponivel);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro inesperado: " + ex.Message);
        }
    }
}