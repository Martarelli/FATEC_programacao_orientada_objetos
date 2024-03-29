using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Cliente : IAutenticavel
    {
        public string Nome { get; set; } = "";
        public string Endereco { get; set; } = "";
        public int Senha { get; set; }

        public bool Autenticar(int s)
        {
            if (Senha == s)
                return true;
            return false;
        }

    }
}