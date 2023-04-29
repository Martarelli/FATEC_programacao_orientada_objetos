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
        
        
        public void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine($"CPF: {Cpf} \tRG: {Rg}");
        }
        public ClienteFisico(){}
        
        public ClienteFisico(int c, string n, string e, int cpf, int r) : base(c, n, e)
        {
            Cpf = cpf;
            Rg = r;
        }
    }
}