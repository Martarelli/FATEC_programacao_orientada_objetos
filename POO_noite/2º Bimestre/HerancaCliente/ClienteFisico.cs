using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteFisico : Cliente
    {
        private int cpf;
        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private int rg;
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        
        

        public ClienteFisico(){}
        
        public ClienteFisico(int c, string n, string e, int c, int r) : base(codigo, nome, endereco)
        {
            Cpf = c;
            Rg = r;
        }
    }
}