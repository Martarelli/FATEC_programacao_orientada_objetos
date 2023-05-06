using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    public class Funcionario
    {
        protected int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        protected string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        protected double salario;
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        private double valorHora;
        public double ValorHora
        {
            get { return valorHora; }
            set { valorHora = value; }
        }
        
        
        public Funcionario(int c, string n, double s, double v)
        {
            Codigo = c;
            Nome = n;
            Salario = s;
            ValorHora = v;
        }
        public virtual void CalcularSalario()
        {
            System.Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tSalario: {Salario:C}");
        }
        
        
    }
}