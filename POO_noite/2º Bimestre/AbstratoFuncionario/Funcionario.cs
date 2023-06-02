using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public List<Dependente> VetD { get; set; }

        public Funcionario(int cod, string nome, double salario)
        {
            Codigo = cod;
            Nome = nome;
            Salario = salario;
            VetD = new List<Dependente>();
        }
        public abstract double CalcularSalario(int diasUteis);
        public virtual void Mostrar()
        {
            System.Console.WriteLine($"Cód: {Codigo}\tNome: {Nome}\tSalário: {Salario:C}");
        }
        public abstract int CalcularTotalDependentes();
        public abstract void AdicionarDependente(Dependente d);
        public abstract void RemoverDependenteMaioridade(int cod);
        public abstract void ListarDependentes();
    }
}