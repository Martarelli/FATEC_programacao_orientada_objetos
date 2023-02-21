using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        //ATRIBUTOS
        public int numero;
        public string titular;
        public double saldo;

    //METODOS
        public void Sacar(){}

        public void Depositar(){}

        public void MostrarAtributos(){
            System.Console.WriteLine("Numero: " + numero);
            System.Console.WriteLine("Titular: " + titular);
            System.Console.WriteLine("Saldo: " + saldo);
        }

        public void transferencia(double valor, Conta c1, Conta c2){
            if (c1.saldo > 0 && c1.saldo - valor >= 0)
            {
                c1.saldo -= valor;
                c2.saldo += valor;
                System.Console.WriteLine("Novo saldo conta titular: " + c1.titular + " = R$"+ c1.saldo);
                System.Console.WriteLine("Novo saldo conta titular: " + c2.titular + " = R$"+ c2.saldo);  
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente...\n");
            }
        }
    }
}