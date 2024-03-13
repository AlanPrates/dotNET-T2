using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma lâmpada inicialmente ligada
        Lampada lampada = new Lampada(true);
        
        // Imprimindo o estado atual
        Console.WriteLine("Estado inicial:");
        lampada.Imprimir();
        
        // Desligando a lâmpada e imprimindo o estado atual
        lampada.Desligar();
        lampada.Imprimir();
        
        // Ligando a lâmpada e imprimindo o estado atual
        lampada.Ligar();
        lampada.Imprimir();
    }
}