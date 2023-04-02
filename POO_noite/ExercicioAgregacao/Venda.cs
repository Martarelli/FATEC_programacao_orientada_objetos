using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAgregacao
{
    public class Venda
    {
        public Produto Produto { get; set; }
        public Vendedor Vendedor { get; set; }
        public Comprador Comprador { get; set; }
        public Venda(Produto p, Vendedor v, Comprador c)
        {
            Produto = p;
            Vendedor = v;
            Comprador = c;
        }

        public void ConcretizarVenda()
        {
            System.Console.WriteLine($"\nVenda Concretizada!!!");
        }

        public void CancelarVenda()
        {
            System.Console.WriteLine($"Venda Cancelada!!!");
        }
        
    }
}