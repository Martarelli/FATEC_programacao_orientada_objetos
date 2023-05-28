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
        public virtual int CalcularTotalDependentes()
        {
            return VetD.Count;
        }
        public virtual void AdicionarDependente(Dependente d)
        {
            VetD.Add(d);
        }
        public virtual void RemoverDependente(int cod)
        {
            foreach (Dependente dep in VetD)
            {
                if(dep.Codigo == cod)
                {
                    VetD.Remove(dep);
                    break;
                }
            }
        }

        public virtual void ListarDependentes()
        {
            System.Console.WriteLine($"DEPENDENTES FUNCIONARIO: {Nome}");
            foreach(Dependente dep in VetD)
            {
                System.Console.WriteLine($"Nome: {dep.Nome}\tIdade: {dep.Idade}");
            }
            System.Console.WriteLine();
        }
    }
}