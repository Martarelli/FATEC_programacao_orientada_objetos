using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        public string Nome { get; set; } = "";

        public int Cpf { get; set; }
        
        public string Endereco { get; set; } = "";

        public Cliente()
        {
        }
        public Cliente(string n, int c, string e)
        {
            Nome = n;
            Cpf = c;
            Endereco = e;
        }
    }
}