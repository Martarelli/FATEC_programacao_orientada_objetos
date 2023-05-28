using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Martarelli", 1000);
Dependente dep1 = new Dependente(1, "Joãozin", 12);
a1.AdicionarDependente(dep1);
a1.ListarDependentes();

Assalariado a2 = new Assalariado(2, "Fulano", 2000);
a2.ListarDependentes();

Comissionado c1 = new Comissionado(3, "Tal pessoa", 1000, 0.2);
Dependente dep2 = new Dependente(2, "Mariazinha", 4);
Dependente dep3 = new Dependente(3, "Fulaninho", 15);
Dependente dep4 = new Dependente(4, "Ele mesmo", 2);
c1.AdicionarDependente(dep2);
c1.AdicionarDependente(dep3);
c1.AdicionarDependente(dep4);
c1.ListarDependentes();

Comissionado c2 = new Comissionado(4, "Seu Creison", 1000, 0.5);
Dependente dep5 = new Dependente(5, "Creisinho", 2);
Dependente dep6 = new Dependente(6, "Josileison", 5);
c2.AdicionarDependente(dep5);
c2.AdicionarDependente(dep6);
c2.RemoverDependente(6);
c2.ListarDependentes();

Departamento d1 = new Departamento(1, "TI");
d1.Admitir(a1);
d1.Admitir(c1);

Departamento d2 = new Departamento(2, "RH");
d2.Admitir(a2);
d2.Admitir(c2);

d1.ListarFuncionarios();
System.Console.WriteLine($"Quantidade total de dependendes do departarmente {d1.Descricao}: {d1.CalcularQtdeDependentesFuncionarios()}"); 
d2.ListarFuncionarios();
System.Console.WriteLine($"Quantidade total de dependendes do departarmente {d2.Descricao}: {d2.CalcularQtdeDependentesFuncionarios()}"); 
// d1.DemitirFuncionario(3);
// d1.ListarFuncionarios();
System.Console.WriteLine($"Total da folha do departamento {d1.Descricao} = {d1.CalcularFolha(30):C}");
System.Console.WriteLine($"Total da folha do departamento {d2.Descricao} = {d2.CalcularFolha(30):C}");



