using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAgregacao
{
    public class Vendedor
    {
        public float Comissao { get; set; }
        
        public Vendedor(float c)
        {
            Comissao = (c / 100f);
        }
        public void Vende(Produto p)
        {
            float valorComissao = p.Preco * Comissao;
            System.Console.WriteLine($"A comissão da venda é de {valorComissao:C}");
        }
    }
}