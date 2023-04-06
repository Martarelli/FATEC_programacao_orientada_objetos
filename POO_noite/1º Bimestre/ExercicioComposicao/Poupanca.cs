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

        public void Depositar(double valor)
        {
            Saldo += valor;
            System.Console.WriteLine("Deposito realizado com sucesso...");
        }

        public void Sacar(double valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
                System.Console.WriteLine("Saque realizado com sucesso...");
            }
            else
            {
                System.Console.WriteLine("O saque não pode ser executado... Saldo insuficiente...");
            }
        }

        public void GerarRendimento()
        {
            Saldo *= 1.05;
            System.Console.WriteLine($"O novo saldo é {Saldo:C}");
        }

        public void GerarExtrato()
        {
            System.Console.WriteLine($"\n*****EXTRATO*****\nSALDO:\t{Saldo:C}");
        }
    }
}