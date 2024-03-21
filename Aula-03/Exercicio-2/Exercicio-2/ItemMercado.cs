namespace Exercicio_2;

using System;

// Definição do enum Tipo
public enum Tipo
{
    Comida,
    Bebida,
    Higiene,
    Limpeza
}

// Definição da classe ItemMercado
public class ItemMercado
{
    public string Nome { get; set; }
    public Tipo Tipo { get; set; }
    public double Preco { get; set; }
}
