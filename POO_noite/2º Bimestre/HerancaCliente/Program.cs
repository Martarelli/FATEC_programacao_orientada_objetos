using HerancaCliente;

Cliente c = new Cliente();

c.Codigo = 1;
c.Nome = "Martarelli";
c.Endereco = "Rua Terezina, 75";

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Bia";
cf.Endereco = "Rua Pará, 33";
cf.Cpf = 99999222;
cf.Rg = 1111111;

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Empresa S/A";
cj.Endereco = "Rua Tocantins, 33";
cj.Cnpj = 9999999999;
cj.Ie = 9999999;
cj.Mostrar();




