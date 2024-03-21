using System;
using Exercício_5;

public class Program
{
    public static void Main(string[] args)
    {
        // Triângulo de inteiros
        Triangulo<int> trianguloInt = new Triangulo<int>
        {
            P1 = new Ponto<int> { X = 0, Y = 0, Z = 0 },
            P2 = new Ponto<int> { X = 1, Y = 0, Z = 0 },
            P3 = new Ponto<int> { X = 0, Y = 1, Z = 0 }
        };

        // Triângulo de doubles
        Triangulo<double> trianguloDouble = new Triangulo<double>
        {
            P1 = new Ponto<double> { X = 0.0, Y = 0.0, Z = 0.0 },
            P2 = new Ponto<double> { X = 1.5, Y = 0.0, Z = 0.0 },
            P3 = new Ponto<double> { X = 0.0, Y = 1.5, Z = 0.0 }
        };

        // Triângulo de strings (para fins de demonstração, não faz sentido geometricamente)
        Triangulo<string> trianguloString = new Triangulo<string>
        {
            P1 = new Ponto<string> { X = "A", Y = "B", Z = "C" },
            P2 = new Ponto<string> { X = "D", Y = "E", Z = "F" },
            P3 = new Ponto<string> { X = "G", Y = "H", Z = "I" }
        };

        // Exibindo os pontos dos triângulos
        ExibirTriangulo(trianguloInt);
        ExibirTriangulo(trianguloDouble);
        ExibirTriangulo(trianguloString);
    }

    public static void ExibirTriangulo<T>(Triangulo<T> triangulo)
    {
        Console.WriteLine($"Triângulo:");
        Console.WriteLine($"P1: ({triangulo.P1.X}, {triangulo.P1.Y}, {triangulo.P1.Z})");
        Console.WriteLine($"P2: ({triangulo.P2.X}, {triangulo.P2.Y}, {triangulo.P2.Z})");
        Console.WriteLine($"P3: ({triangulo.P3.X}, {triangulo.P3.Y}, {triangulo.P3.Z})");
        Console.WriteLine();
    }
}