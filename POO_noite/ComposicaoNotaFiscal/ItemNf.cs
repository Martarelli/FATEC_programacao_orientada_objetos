using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNf
    {
        public int Quantidade { get; set; }
        public ItemNf(int q)
        {
            Quantidade = q;
        }
        ~ItemNf()//destrutor
        {
            Console.WriteLine("Destruindo o item nota fiscal");
        }
    }
}