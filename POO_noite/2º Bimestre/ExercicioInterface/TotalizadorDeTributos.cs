using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    public class TotalizadorDeTributos
    {
        public double Total { get; private set; }
        public void Adiciona(ITributavel t)
        {
            Total += t.CalculaTributos();
        }
    }
}