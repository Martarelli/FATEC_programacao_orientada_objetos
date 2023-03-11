using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        //ATRIBUTOS
        public int numero;
        public string titular;
        public double saldo;

        //CONSTRUTORES

        public Conta()
        {
        }
        public Conta(int n)
        {
            this.numero = n;
        }

        public Conta(int n, string t, double s)
        {
            this.numero = n;
            this.titular = t;
            this.saldo = s;
        }
        //METODOS
        public void Sacar(double valor){
            saldo -= valor;
        }

        public void Depositar(double valor){
            saldo += valor;
        }

        public void MostrarAtributos(){
            System.Console.WriteLine("\nNumero: " + numero);
            System.Console.WriteLine("Titular: " + titular);
            System.Console.WriteLine("Saldo: " + saldo + "\n");
        }

        public void Transferencia(double valor, Conta c2){
            if (saldo >= valor)
            {
                saldo -= valor;
                c2.saldo += valor;
                System.Console.WriteLine("\nNovo saldo conta titular: " + titular + " = R$" + saldo);
                System.Console.WriteLine("Novo saldo conta titular: " + c2.titular + " = R$"+ c2.saldo + "\n");  
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente...\n");
            }
        }
    }
}