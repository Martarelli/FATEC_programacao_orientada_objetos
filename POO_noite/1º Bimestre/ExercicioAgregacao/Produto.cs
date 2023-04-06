using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAgregacao
{
    public class Produto
    {
        public float Preco { get; set; }
        public int Tamanho { get; set; }

        public Produto()
        {
            
        }
        public Produto(float p, int t)
        {
            Preco = p;
            Tamanho = t;
        }
        public void Vendido (){
            System.Console.WriteLine($"O produto tem tamanho: {Tamanho} e custa {Preco:C}");
        }
    }
}