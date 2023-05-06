using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    public class Horista : Funcionario
    {
        public int QtdeHorasSemana { get; set; }

        public Horista(int c, string n, double v, int q) : base(c, n, v)
        {
            QtdeHorasSemana = q;
        }

        public override void CalcularSalario()
        {
            Salario = QtdeHorasSemana * ValorHora;
            base.CalcularSalario();
        }
        

    }
}