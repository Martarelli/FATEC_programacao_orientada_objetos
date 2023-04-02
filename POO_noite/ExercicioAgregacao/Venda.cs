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
            System.Console.WriteLine($"Venda Concretizada!!!\nValor: {Produto.Preco:C}\nComissão da venda: {Vendedor.Comissao:C}\nVerba disponível: {Comprador.Verba}");
        }

        public void CancelarVenda()
        {
            System.Console.WriteLine($"Venda Cancelada!!!\nValor: {Produto.Preco:C}");
        }
        
    }
}