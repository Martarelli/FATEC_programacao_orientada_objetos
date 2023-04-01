using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAgregacao
{
    public class Venda
    {
        public List<Produto> Produto { get; set; }
        public Vendedor Vendedor { get; set; }
        public Comprador Comprador { get; set; }
        public Venda(List<Produto> p, Vendedor v, Comprador c)
        {
            Produto = p;
            Vendedor = v;
            Comprador = c;
        }

        
    }
}