using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var tuple1 = (10, 20);
        Console.WriteLine($"tuple1: {tuple1.Item1}, {tuple1.Item2}"); // 10, 20 (tuple1);

        var tuple2 = (x: 5, y: 50);
        Console.WriteLine($"tuple2: {tuple2.x}, {tuple2.y}");

        var tuple3 = (id: 10, name: "Alan", born: new DateTime(1989, 07, 10));
        Console.WriteLine($"tuple3: {tuple3.id}, {tuple3.name}, {tuple3.born}");

        List<(int id, string name, DateTime born)> list = new List<(int, string, DateTime)>();
        list.Add(tuple3);
        list.Add((11, "Alan", new DateTime(1989, 07, 10)));

        list.ForEach(x => Console.WriteLine($"Tuple 4: {x.id}, {x.name}, {x.born.ToShortDateString()}"));
    }
}
