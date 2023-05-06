using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    public class Mensalista : Funcionario
    {
        public int QtdeHorasTrabalhadas { get; set; }
        

        public Mensalista(int c, string n, double s, double v, int q) : base(c, n, s, v)
        {
            QtdeHorasTrabalhadas = q;
        }

        public override void CalcularSalario()
        {
            Salario = QtdeHorasTrabalhadas * ValorHora;
            base.CalcularSalario();
        }
        
        
    }
}