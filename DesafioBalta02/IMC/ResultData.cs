using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta02.IMC
{
    internal static class ResultData
    {
        public static void GetResult(float imc)
        {
            if (imc < 16)
            {
                Console.WriteLine($"\tSeu IMC é: {imc}Kg/m²");
                Console.WriteLine($"\tClassificação: Magreza Grau III");
                Console.WriteLine($"\tRisco: Sem risco determinado!");
            }
            else
            {
                if (imc >= 16 && imc <= 16.9)
                {
                    Console.WriteLine($"\tSeu IMC é: {imc}Kg/m²");
                    Console.WriteLine($"\tClassificação: Magreza Grau II");
                    Console.WriteLine($"\tRisco: Sem risco determinado!");
                } else
                {
                    if (imc >= 17 && imc <= 18.4)
                    {
                        Console.WriteLine($"\tSeu IMC é: {imc}Kg/m²");
                        Console.WriteLine($"\tClassificação: Magreza Grau I");
                        Console.WriteLine($"\tRisco: Sem risco determinado!");
                    } else
                    {
                        if (imc >= 18.5 && imc <= 24.9)
                        {
                            Console.WriteLine($"\tSeu IMC é: {imc}Kg/m²");
                            Console.WriteLine($"\tClassificação: Eutrofia");
                            Console.WriteLine($"\tRisco: Sem risco determinado!");
                        } else
                        {
                            if (imc >= 25 && imc <= 29.9)
                            {
                                Console.WriteLine($"\tSeu IMC é: {imc}Kg/m²");
                                Console.WriteLine($"\tClassificação: Sobrepeso");
                                Console.WriteLine($"\tRisco: Aumentado");
                            } else
                            {
                                if (imc >= 30 && imc <= 34.9)
                                {
                                    Console.WriteLine($"\tSeu IMC é: {imc}Kg/m²");
                                    Console.WriteLine($"\tClassificação: Obesidade Grau I");
                                    Console.WriteLine($"\tRisco: Moderado");
                                } else
                                {
                                    if (imc >= 35 && imc <= 40)
                                    {
                                        Console.WriteLine($"\tSeu IMC é: {imc}Kg/m²");
                                        Console.WriteLine($"\tClassificação: Obesidade Grau II");
                                        Console.WriteLine($"\tRisco: Grave");
                                    } else
                                    {
                                        Console.WriteLine($"\tSeu IMC é: {imc}Kg/m²");
                                        Console.WriteLine($"\tClassificação: Obesidade Grau III");
                                        Console.WriteLine($"\tRisco: Muito Grave!");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
