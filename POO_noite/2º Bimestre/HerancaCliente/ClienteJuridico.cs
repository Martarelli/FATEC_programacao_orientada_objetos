using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteJuridico : Cliente
    {
        private int cnpj;
        public int Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        private int ie;
        public int Ie
        {
            get { return ie; }
            set { ie = value; }

    
        }

        public ClienteJuridico(){}
        
        public ClienteJuridico(int c, string n, string e, int cnpj, int i) : base(c, n, e)
        {
            Cnpj = cnpj;
            Ie = i;
        }    
        
        public void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine($"CNPJ: {Cnpj} \tIE: {Ie}");
        }
    }
}