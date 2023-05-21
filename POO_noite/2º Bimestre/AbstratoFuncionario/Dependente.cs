using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; } = "";
        public int Idade { get; set; }

        public void MaiorIdade()
        {
            if(Idade >= 18)
                System.Console.WriteLine($"{Nome} - Maior de idade");
            else
                System.Console.WriteLine($"{Nome} - Menor de idade");
        }

    }
}