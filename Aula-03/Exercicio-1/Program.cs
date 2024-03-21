using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criando a lista inicial
        List<double> numeros = new List<double> { 3, 7, 2, 4, 6 };

        // Usando o método ConvertAll para dividir cada elemento por 2 e retornar uma nova lista
        List<double> novaLista = numeros.ConvertAll(x => x / 2);

        // Imprimindo os elementos da nova lista usando o método ForEach
        novaLista.ForEach(x => Console.WriteLine(x));
    }
}