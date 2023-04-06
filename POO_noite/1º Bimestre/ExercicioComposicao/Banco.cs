using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioComposicao
{
    public class Banco
    {
        public List<Poupanca> Poupancas { get; set; }
        public List<ContaCorrente> ContasCorrentes { get; set; }

        public Banco()
        {
            
        }
        public Banco(List<Poupanca> p, List<ContaCorrente> c)
        {
            Poupancas = p;
            ContasCorrentes = c;
        }
    }
}