using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    public class SeguroDeVida : ITributavel
    {
        public double CalculaTributos()
        {
            return 75.00;
        }
    }
}