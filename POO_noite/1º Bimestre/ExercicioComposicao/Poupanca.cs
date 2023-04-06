using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioComposicao
{
    public class Poupanca
    {
        public double Saldo { get; set; }

        public Poupanca()
        {
            
        }

        public Poupanca(double valor)
        {
            Saldo = valor;
        }

        
    }
}