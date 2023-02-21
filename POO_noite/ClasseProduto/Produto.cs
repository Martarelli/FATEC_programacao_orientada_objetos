using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public int codigo;
        public string descricao;
        public double preco;

        public void mostrarDados(){
            System.Console.WriteLine("\nCODIGO: " + codigo);
            System.Console.WriteLine("DESCRIÇÃO: " + descricao);
            System.Console.WriteLine("PREÇO: " + preco);
        }
    }
}