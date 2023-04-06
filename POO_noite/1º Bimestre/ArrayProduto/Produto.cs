using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private double preco;

        public void Mostrar(){
            System.Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tPreço: {Preco}");
        }


        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        

        
    }
}