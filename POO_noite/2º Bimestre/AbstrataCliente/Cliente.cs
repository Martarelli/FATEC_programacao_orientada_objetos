using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public abstract class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Cliente(int c, string n)
        {
            Codigo = c;
            Nome = n;
        }
        public abstract void Mostrar();
    }
}