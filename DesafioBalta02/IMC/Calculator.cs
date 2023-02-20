using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta02.IMC
{
    internal class Calculator
    {
        public static float Result(float height, float weight)
        {
            height /= 100;
            return (weight / (height * height));
        }
    }
}
