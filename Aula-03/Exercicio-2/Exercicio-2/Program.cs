using System;
using System.Collections.Generic;
using System.Linq;
namespace Exercicio_2;
class Program
{
    static void Main(string[] args)
    {
        // Criando uma lista de objetos ItemMercado
        List<ItemMercado> itensMercado = new List<ItemMercado>
        {
            new ItemMercado { Nome = "Arroz", Tipo = Tipo.Comida, Preco = 3.90 },
            new ItemMercado { Nome = "Azeite", Tipo = Tipo.Comida, Preco = 2.50 },
            new ItemMercado { Nome = "Macarrão", Tipo = Tipo.Comida, Preco = 3.90 },
            new ItemMercado { Nome = "Cerveja", Tipo = Tipo.Bebida, Preco = 22.90 },
            new ItemMercado { Nome = "Refrigerante", Tipo = Tipo.Bebida, Preco = 5.50 },
            new ItemMercado { Nome = "Shampoo", Tipo = Tipo.Higiene, Preco = 7.00 },
            new ItemMercado { Nome = "Sabonete", Tipo = Tipo.Higiene, Preco = 2.40 },
            new ItemMercado { Nome = "Cotonete", Tipo = Tipo.Higiene, Preco = 5.70 },
            new ItemMercado { Nome = "Sabão em pó", Tipo = Tipo.Limpeza, Preco = 8.20 },
            new ItemMercado { Nome = "Detergente", Tipo = Tipo.Limpeza, Preco = 2.60 },
            new ItemMercado { Nome = "Amaciante", Tipo = Tipo.Limpeza, Preco = 6.40 }
        };

        // 1) Retorne uma lista de itens do tipo Higiene ordenados por ordem decrescente de preço.
        var itensHigieneOrdenados = itensMercado.Where(item => item.Tipo == Tipo.Higiene)
                                                .OrderByDescending(item => item.Preco)
                                                .ToList();
        Console.WriteLine("Itens de Higiene ordenados por preço (decrescente):");
        foreach (var item in itensHigieneOrdenados)
        {
            Console.WriteLine($"Nome: {item.Nome}, Preço: R${item.Preco}");
        }

        Console.WriteLine();

        // 2) Retorne uma lista de itens cujo preço seja maior ou igual a R$ 5,00. A ordenação deve ser feita por ordem crescente de preço.
        var itensPrecoMaiorIgual5 = itensMercado.Where(item => item.Preco >= 5.00)
                                                 .OrderBy(item => item.Preco)
                                                 .ToList();
        Console.WriteLine("Itens com preço maior ou igual a R$5,00 ordenados por preço (crescente):");
        foreach (var item in itensPrecoMaiorIgual5)
        {
            Console.WriteLine($"Nome: {item.Nome}, Preço: R${item.Preco}");
        }

        Console.WriteLine();

        // 3) Retorne uma lista de itens cujo tipo seja Comida ou Bebida. A ordenação deve ser feita por nome em ordem alfabética.
        var itensComidaBebidaOrdenados = itensMercado.Where(item => item.Tipo == Tipo.Comida || item.Tipo == Tipo.Bebida)
                                                     .OrderBy(item => item.Nome)
                                                     .ToList();
        Console.WriteLine("Itens de Comida ou Bebida ordenados por nome:");
        foreach (var item in itensComidaBebidaOrdenados)
        {
            Console.WriteLine($"Nome: {item.Nome}, Tipo: {item.Tipo}, Preço: R${item.Preco}");
        }

        Console.WriteLine();

        // 4) Retorne cada um dos tipos associado com a quantidade de itens de cada tipo.
        var quantidadePorTipo = itensMercado.GroupBy(item => item.Tipo)
                                           .Select(g => new { Tipo = g.Key, Quantidade = g.Count() })
                                           .ToList();
        Console.WriteLine("Quantidade de itens por tipo:");
        foreach (var item in quantidadePorTipo)
        {
            Console.WriteLine($"Tipo: {item.Tipo}, Quantidade: {item.Quantidade}");
        }

        Console.WriteLine();

        // 5) Retorne cada um dos tipos associado com o preço máximo, preço mínimo e média de preço de cada tipo.
        var estatisticasPorTipo = itensMercado.GroupBy(item => item.Tipo)
                                              .Select(g => new
                                              {
                                                  Tipo = g.Key,
                                                  PrecoMaximo = g.Max(item => item.Preco),
                                                  PrecoMinimo = g.Min(item => item.Preco),
                                                  PrecoMedio = g.Average(item => item.Preco)
                                              })
                                              .ToList();
        Console.WriteLine("Estatísticas de preço por tipo:");
        foreach (var item in estatisticasPorTipo)
        {
            Console.WriteLine($"Tipo: {item.Tipo}, Preço Máximo: R${item.PrecoMaximo}, Preço Mínimo: R${item.PrecoMinimo}, Preço Médio: R${item.PrecoMedio}");
        }
    }
}
