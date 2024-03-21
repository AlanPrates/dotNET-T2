namespace Exercício_4;

using System;

// Definição da classe ServicoFabrica<T>
public class ServicoFabrica<T> where T : IServico, new()
{
    public T NovaInstancia()
    {
        return new T();
    }
}
