using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta02
{
    internal class TextView
    {
        public static float GetHeight()
        {
            Console.Write("Informe sua altura (em m): ");
            return float.Parse(Console.ReadLine().Replace(',', '.'));
        }

        public static float GetWeight()
        {
            Console.Write("Informe seu peso (em Kg): ");
            return float.Parse(Console.ReadLine().Replace(',', '.'));
        }
    }
}
