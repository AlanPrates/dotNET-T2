using System;

public class Lampada
{
    private bool ligada;

    public Lampada(bool ligada)
    {
        this.ligada = ligada;
    }

    public void Ligar()
    {
        ligada = true;
        Console.WriteLine("Lâmpada ligada");
    }

    public void Desligar()
    {
        ligada = false;
        Console.WriteLine("Lâmpada desligada");
    }

    public void Imprimir()
    {
        if (ligada)
        {
            Console.WriteLine("Lâmpada ligada");
        }
        else
        {
            Console.WriteLine("Lâmpada desligada");
        }
    }
}