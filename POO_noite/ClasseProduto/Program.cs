using ClasseProduto;

Produto p1 = new Produto();
p1.codigo = 1;
p1.descricao = "Suco";
p1.preco = 2.56;
p1.mostrarDados();

Produto p2 = new Produto();
p2.codigo = 2;
p2.descricao = "Pão";
p2.preco = 6.56;
p2.mostrarDados();

Produto p3 = new Produto();
p3.codigo = 3;
p3.descricao = "Pizza";
p3.preco = 22.56;
p3.mostrarDados();

double valorTotal = p1.preco + p2.preco + p3.preco;

System.Console.WriteLine("\nValor total: R$" + valorTotal);