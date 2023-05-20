using InterfaceAutenticavel;

Gerente g = new Gerente();
g.Nome = "Gerentão";
g.Senha = 123;

Diretor d = new Diretor();
d.Nome = "Diretor zica";
d.Senha = 100;

Cliente c = new Cliente();
c.Nome = "Clientela";
c.Endereco = "Rua da aldeia";
c.Senha = 200;

IAutenticavel ia;
ia = g;
System.Console.WriteLine($"{g.Nome} - {ia.Autenticar(123)}"); 
System.Console.WriteLine($"{d.Nome} - {d.Autenticar(18)}"); 
ia = c;
System.Console.WriteLine($"{c.Nome} - {ia.Autenticar(1099)}"); 


