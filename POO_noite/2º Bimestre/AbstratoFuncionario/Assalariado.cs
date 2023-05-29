using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Assalariado : Funcionario
    {
        public Assalariado(int c, string n, double s) : base(c, n, s)
        {

        }
        public override double CalcularSalario(int diasUteis)
        {
            return Salario = Salario / 30 * diasUteis;
        }

        public override int CalcularTotalDependentes()
        {
            return VetD.Count;
        }
        public override void AdicionarDependente(Dependente d)
        {
            VetD.Add(d);
        }
        public override void RemoverDependenteMaioridade(int cod)
        {
            foreach (Dependente dep in VetD)
            {
                if(dep.Codigo == cod)
                {
                    if(dep.MaiorIdade())
                        {
                            VetD.Remove(dep);
                            break;
                        }
                }
            }
        }
        public override void ListarDependentes()
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