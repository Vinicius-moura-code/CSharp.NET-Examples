using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            String palavra1; //declare as suas variaveis
            String palavra2;
            String palavra3;

            palavra1 = Console.ReadLine(); //insira suas variaveis
            palavra2 = Console.ReadLine();
            palavra3 = Console.ReadLine();

            if ((palavra1 == "vertebrado") && (palavra2 == "ave") && (palavra3 == "carnivoro"))
            {
                Console.WriteLine("aguia\n");
                //complete o desafio
            }

            if ((palavra1 == "vertebrado") && (palavra2 == "ave") && (palavra3 == "onivoro"))
            {
                Console.WriteLine("pomba\n");
                //complete o desafio
            }

            if ((palavra1 == "vertebrado") && (palavra2 == "mamifero") && (palavra3 == "onivoro"))
            {
                Console.WriteLine("homem\n");
                //complete o desafio
            }

            if ((palavra1 == "vertebrado") && (palavra2 == "mamifero") && (palavra3 == "herbivoro"))
            {
                Console.WriteLine("vaca\n");
                //complete o desafio
            }

            if ((palavra1 == "invertebrado") && (palavra2 == "inseto") && (palavra3 == "hematofago"))
            {
                Console.WriteLine("pulga\n");
                //complete o desafio
            }

            if ((palavra1 == "invertebrado") && (palavra2 == "inseto") && (palavra3 == "herbivoro"))
            {
                Console.WriteLine("lagarta\n");
                //complete o desafio
            }
            if ((palavra1 == "invertebrado") && (palavra2 == "anelideo") && (palavra3 == "hematofago"))
            {
                Console.WriteLine("sanguessuga\n");
                //complete o desafio
            }

            if ((palavra1 == "invertebrado") && (palavra2 == "anelideo") && (palavra3 == "onivoro"))
            {
                Console.WriteLine("minhoca\n");
            }








            /*using System;
using System.Linq;

class Program {

  static void Main(string[] args) {
    int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
    int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
    int totalDeFigurinhas = 0;

    int[] albumDeFigurinha = new int[numeroDeFigurinhasCompradas] ;

    for (int i = 0; i < numeroDeFigurinhasCompradas; i++) {
      int figurinha = int.Parse(Console.ReadLine());
        if (!albumDeFigurinha.Contains(figurinha)) {
          albumDeFigurinha[i] = figurinha;
          numeroDeFigurinhas -= 1;
        }
        if (numeroDeFigurinhas == 0) {
          break;
        }
    }

    totalDeFigurinhas = numeroDeFigurinhas;

    Console.WriteLine(totalDeFigurinhas);
  }

}*/








            /*using System;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string[] data = input.Split(' ');

            double h = double.Parse(data[0]);
            double v = double.Parse(data[1]);
            double qtdCombustivelGasto = h * v / 12.0;

            Console.WriteLine(qtdCombustivelGasto.ToString("N3"));;
        }
    }
}*/
        }
    }
}
