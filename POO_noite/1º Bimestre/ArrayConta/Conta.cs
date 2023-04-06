using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayConta
{
    public class Conta
    {
        //ATRIBUTOS
        public int numero;
        public string titular;
        public double saldo;

    //METODOS
        public void MostrarAtributos(){
            System.Console.WriteLine($"Titular: {titular} \tNumero: {numero}\t Saldo: {saldo:C}\n");
        }

      
    }
}