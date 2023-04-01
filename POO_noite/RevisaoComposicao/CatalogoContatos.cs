using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoComposicao
{
    public class CatalogoContatos
    {
        public string Nome { get; set; }    
        public List<Contatos> ListaContatos { get; set; }   

        public CatalogoContatos(string n, List<Contatos> l)
        {
            Nome = n;
            ListaContatos = l;
            //listaContatos = new List<Contatos>();

        }

        public void ExibirContatos()
        {
            foreach (Contatos c in ListaContatos)
            {
                c.ListarContatos();
            }
        }
    }
}