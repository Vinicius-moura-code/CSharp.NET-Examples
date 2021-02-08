using System;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string[] data = input.Split(' ');

            int h = int.Parse(data[0]);
            int v = int.Parse(data[1]);
            double qtdCombustivelGasto = h * v / 12.0;


            Console.WriteLine(Math.Round(qtdCombustivelGasto, 3));
        }
    }
}
