using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioExcecao
{
    public class Conta
    {
        public static int Contador { get; set; }
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
            Contador++;
        }
        public Conta(int n)
        {
            
            Numero = n;
            Contador++;
        }

        public Conta(int n, string t, double s)
        {
            Numero = n;
            Titular = t;
            Saldo = s;
            Contador++;
        }
        public void Sacar(double valor){
            Saldo -= valor;
        }

        public void Depositar(double valor){
            try
            {
                if(valor >= 0)
                {
                    Saldo += valor;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch(ArgumentException e)
            {
                System.Console.WriteLine($"EXCECAO DE ARGUMENTO : {e.Message}");
            }
        }

        public void MostrarAtributos(){
            System.Console.WriteLine("\nNumero: " + Numero);
            System.Console.WriteLine("Titular: " + Titular);
            System.Console.WriteLine("Saldo: " + Saldo + "\n");
        }

        public void Transferencia(double valor, Conta c2){
            if (Saldo >= valor)
            {
                Saldo -= valor;
                c2.Saldo += valor;
                System.Console.WriteLine("\nNovo saldo conta titular: " + Titular + " = R$" + Saldo);
                System.Console.WriteLine("Novo saldo conta titular: " + c2.Titular + " = R$"+ c2.Saldo + "\n");  
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente...\n");
            }
        }
    }
}