using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioStatic
{
    public class Funcionario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double Salario { get; set; }

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

        public void Reajuste(double porcentagem)
        {
            double salarioReajustado = Salario + Salario*porcentagem/100;
            System.Console.WriteLine($"Salario do Funcionário {Nome} reajustado com {porcentagem}% de ajuste é de {salarioReajustado:C}");
        }

    }
}