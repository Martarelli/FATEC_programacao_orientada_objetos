using AgregacaoContaVetor;

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 22334.56;

Cliente cli1 = new Cliente("Josivaldo",111111,111);
Cliente cli2 = new Cliente("Josivaldo",222222,222);
Cliente cli3 = new Cliente("Josivaldo",333333,333);

c1.vetTitular = new List<Cliente>();
c1.vetTitular.Add(cli1);
c1.vetTitular.Add(cli2);
c1.vetTitular.Add(cli3);

foreach(Cliente c in c1.vetTitular)
{
    c.MostrarCliente();
}