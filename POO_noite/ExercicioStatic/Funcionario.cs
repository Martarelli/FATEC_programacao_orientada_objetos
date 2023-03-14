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

        public static int Contador { get; set; }

        public Funcionario()
        {
            Contador++;
        }

        public Funcionario(int cod)
        {
            Codigo = cod;
            Contador++;
        }


    }
}