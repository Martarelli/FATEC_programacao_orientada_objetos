using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Produto
    {
        protected int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        protected string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        protected double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        public Produto()
        {               }

        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public virtual void Mostrar()
        {
            System.Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tPreço: {Preco:C}");
        }

    }
}