using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int cod, string nome, double salario)
        {
            Codigo = cod;
            Nome = nome;
            Salario = salario;
        }
        public abstract double CalcularSalario(int diasUteis);
        public virtual void Mostrar()
        {
            System.Console.WriteLine($"Cód: {Codigo}\tNome: {Nome}\tSalário: {Salario:C}");
        }
    }
}