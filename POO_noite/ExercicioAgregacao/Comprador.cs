using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAgregacao
{
    public class Comprador
    {
        public float Verba { get; set; }

        public Comprador(float v)
        {
            Verba = v;
        }

        public void Compra(Produto p)
        {
            if(Verba >= p.Preco){
                System.Console.WriteLine($"Verba suficiente para a compra...");
            } else {
                System.Console.WriteLine($"Verba insuficiente...");
            };
        }
    }
}