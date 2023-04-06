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

        public void AbrirPoupanca(double saldo)
        {
            Poupanca p = new Poupanca(saldo);
            Poupancas.Add(p);
            System.Console.WriteLine("Poupança criada com sucesso...");
        }

        public void ExibirContas()
        {
            foreach (ContaCorrente c in ContasCorrentes)
            {
                c.GerarExtrato();
            }
        }

        ~Banco()
        {
            System.Console.WriteLine("O banco declarou falencia...");
            Poupancas = null;
            ContasCorrentes = null;
        }
    }
}