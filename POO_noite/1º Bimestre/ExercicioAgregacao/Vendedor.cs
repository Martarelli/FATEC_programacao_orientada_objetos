using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAgregacao
{
    public class Vendedor
    {
        public float Comissao { get; set; }
        

        public void Vende(Produto p)
        {
            Comissao = p.Preco * 0.25f;
            System.Console.WriteLine($"A comissão da venda é de {Comissao:C}");
        }
    }
}