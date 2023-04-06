using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        private int codigo;
        private string nome = "";
        private double salario;
        public int Codigo
        {
            get { 
                return this.codigo; 
                }
            set { 
                this.codigo = value; 
                }
        }

        public string Nome
        {
            get { 
                return this.nome; 
                }
            set { 
                this.nome = value; 
                }
        }

                public double Salario
        {
            get { 
                return this.salario; 
                }
            set { 
                this.salario = value; 
                }
        }

        public void MostrarDados(){
            System.Console.WriteLine("\nCODIGO: " + codigo);
            System.Console.WriteLine("NOME: " + nome);
            System.Console.WriteLine("SALARIO: " + salario + "\n");
        }
    }
}