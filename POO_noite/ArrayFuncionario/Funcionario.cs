using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    public class Funcionario
    {
        public int codigo;
        public string nome;
        public double salario;

        public void MostrarDados(){
            System.Console.WriteLine($"/Código: {codigo} \tNome: {nome}\t Salario: {salario:C}\n");
        }
    }
}