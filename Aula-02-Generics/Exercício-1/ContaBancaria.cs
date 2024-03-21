namespace Exercício;

using System;

// Definição da classe ValorInvalidoException
public class ValorInvalidoException : Exception
{
    public ValorInvalidoException(string mensagem, double valorInvalido) : base(mensagem)
    {
        ValorInvalido = valorInvalido;
    }

    public double ValorInvalido { get; }
}

// Definição da classe SaldoInsuficienteException
public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(string mensagem, double saldoDisponivel) : base(mensagem)
    {
        SaldoDisponivel = saldoDisponivel;
    }

    public double SaldoDisponivel { get; }
}

// Definição da classe ContaBancaria
public class ContaBancaria
{
    private double saldo;

    public ContaBancaria(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public void Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ValorInvalidoException("Valor de saque inválido.", valor);
        }
        if (valor > saldo)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente para saque.", saldo);
        }
        saldo -= valor;
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ValorInvalidoException("Valor de depósito inválido.", valor);
        }
        saldo += valor;
    }

    public void Transferir(double valor, ContaBancaria destino)
    {
        Sacar(valor);
        destino.Depositar(valor);
    }

    public double Saldo => saldo;
}
