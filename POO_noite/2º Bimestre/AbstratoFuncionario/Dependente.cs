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

        public Dependente(int c, string n, int i)
        {
            Codigo = c;
            Nome = n;
            Idade = i;
        }
        
        public bool MaiorIdade()
        {
            if(Idade >= 18)
                return true;
            return false;
        }

    }
}