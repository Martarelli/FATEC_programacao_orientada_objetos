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
            else if (Saldo+ChequeEspecial >= valor)
            {
                double valorExcedente = valor - Saldo;
                Saldo = 0;
                ChequeEspecial -= valorExcedente;
                System.Console.WriteLine("Saque realizado com sucesso mas entrou no cheque especial...");
            }
            else
            {
                System.Console.WriteLine("O saque não pode ser executado... Saldo insuficiente...");
            }
        }
    }
}