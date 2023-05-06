using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        protected string dtValidade;
        public string DtValidade
        {
            get { return dtValidade; }
            set { dtValidade = value; }
        }

        private string dtFabricacao;
        public string Dtfabricacao
        {
            get { return dtFabricacao; }
            set { dtFabricacao = value; }
        }
        private int lote;
        public int Lote
        {
            get { return lote; }
            set { lote = value; }
        }
        
        public Perecivel(){

        }
        public Perecivel(int codigo, string nome, double preco, string dtValidade, string dtFabricacao, int lote) : base(codigo, nome, preco)
        {
            DtValidade = dtValidade;
            Dtfabricacao = dtFabricacao;
            Lote = lote;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine($"Data Validade: {DtValidade}\tData Fabricação: {Dtfabricacao}\tLote: {Lote}");
        }
        
    }
}