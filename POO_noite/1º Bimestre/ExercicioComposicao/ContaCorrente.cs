using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioComposicao
{
    public class ContaCorrente
    {
        public double Saldo { get; set; }
        public double ChequeEspecial { get; set; }

        public ContaCorrente()
        {
            
        }

        public ContaCorrente(double s, double c)
        {
            Saldo = s;
            ChequeEspecial = c;
        }

        
    }
}