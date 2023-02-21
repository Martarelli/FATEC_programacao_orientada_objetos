using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        public int codigo;
        public string nome;
        public double salario;

        public void mostrarDados(){
            System.Console.WriteLine("\nCODIGO: " + codigo);
            System.Console.WriteLine("NOME: " + nome);
            System.Console.WriteLine("SALARIO: " + salario + "\n");
        }
    }
}