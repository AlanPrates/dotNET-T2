using System;
using System.Threading;
namespace Exercicio_3;
class Program
{
    static void Main(string[] args)
    {
        // Criando duas instâncias da classe Worker
        Worker worker1 = new Worker();
        Worker worker2 = new Worker();

        // Criando duas threads e associando cada uma a um método Work das instâncias da classe Worker
        Thread thread1 = new Thread(worker1.Work);
        Thread thread2 = new Thread(worker2.Work);

        // Nomeando as threads para facilitar a identificação
        thread1.Name = "Thread 1";
        thread2.Name = "Thread 2";

        // Iniciando as threads
        thread1.Start();
        thread2.Start();

        // Aguardando até que ambas as threads terminem de executar
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Programa principal concluído.");
    }
}