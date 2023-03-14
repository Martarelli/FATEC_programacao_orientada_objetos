using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioStatic
{
    public class Funcionario
    {
        private int Codigo { get; set; }

        private string Nome { get; set; }

        private double Salario { get; set; }

        private int Contador { get; set; }

        public void Funcionario()
        {
            Contador++;
        }


    }
}