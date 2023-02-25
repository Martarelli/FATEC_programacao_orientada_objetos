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
        public void MostrarAtributos(){
            System.Console.WriteLine($"Titular: {titular} \tNumero: {numeroSaldo}\t Saldo: {saldo:C}\n");
        }

      
    }
}