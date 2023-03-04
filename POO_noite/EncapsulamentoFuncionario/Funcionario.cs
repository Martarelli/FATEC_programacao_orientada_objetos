using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        private int codigo;
        private string nome;
        private double salario;

        public void MostrarDados(){
            System.Console.WriteLine("\nCODIGO: " + codigo);
            System.Console.WriteLine("NOME: " + nome);
            System.Console.WriteLine("SALARIO: " + salario + "\n");
        }
    }
}