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
            Poupancas = new List<Poupanca>();
            ContasCorrentes = new List<ContaCorrente>();
        }
        public Banco(List<Poupanca> p, List<ContaCorrente> c)
        {
            Poupancas = p;
            ContasCorrentes = c;
        }

        public void AbrirConta(double saldo, double chequeEspecial)
        {
            ContaCorrente c = new ContaCorrente(saldo, chequeEspecial);
            ContasCorrentes.Add(c);
            System.Console.WriteLine("Conta Corrente criada com sucesso...");
        }
        
    }
}