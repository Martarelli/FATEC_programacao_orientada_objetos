using ExercicioAgregacao;

Produto p1 = new Produto(1299.99f, 2);
p1.Vendido();

Comprador c1 = new Comprador(2500f);
c1.Compra(p1);

Vendedor v1 = new Vendedor(10f);
v1.Vende(p1);

Venda venda1 = new Venda(p1, v1, c1);
venda1.ConcretizarVenda();
