using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "1";

            float height, weight;

            do
            {
                Console.Clear();

                Console.WriteLine("\tDesafio do Balta 02!\n");

                height = TextView.GetHeight();

                weight = TextView.GetWeight();

                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                Console.WriteLine("\nResultados:\n");

                float imc = IMC.Calculator.Result(height, weight);

                IMC.ResultData.GetResult(imc);

                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

                Console.Write("Refazer Calculo? (1 para Refazer / 0 para Sair): ");
                option = Console.ReadLine();

            } while (!option.Equals("0"));
        }
    }
}
