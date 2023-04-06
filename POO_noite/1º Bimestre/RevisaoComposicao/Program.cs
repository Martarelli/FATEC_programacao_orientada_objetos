using RevisaoComposicao;

Contatos c1 = new Contatos("Martarelli","aaa@aaa.com", "111");
Contatos c2 = new Contatos("Gabi","selva@aldeia.com", "222");
Contatos c3 = new Contatos("Fatec","fatec@fatec.com", "333");
Contatos c4 = new Contatos("Unoeste","unoeste@unoeste.com", "444");


List<Contatos> vet1 = new List<Contatos>();
vet1.Add(c1);
vet1.Add(c2);
CatalogoContatos cat1 = new CatalogoContatos("TurmaPOO", vet1);
System.Console.WriteLine($"\nNome do catálogo: {cat1.Nome}..........");
cat1.ExibirContatos();

List<Contatos> vet2 = new List<Contatos>();
vet2.Add(c3);
vet2.Add(c4);
CatalogoContatos cat2 = new CatalogoContatos("Facul", vet2);
System.Console.WriteLine($"\nNome do catálogo: {cat2.Nome}..........");
cat2.ExibirContatos();