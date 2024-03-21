namespace Exercicio_3;

using System;
using System.Threading;

public class Worker
{
    public void Work()
    {
        // Simulando um trabalho
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.Name}: Trabalho em andamento... {i}/5");
            Thread.Sleep(1000); // Simulando o trabalho com uma pausa de 1 segundo
        }
        Console.WriteLine($"Thread {Thread.CurrentThread.Name}: Trabalho concluído!");
    }
}
