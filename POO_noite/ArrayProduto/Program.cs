using ArrayProduto;

Produto[] vetP = new Produto[3];

for (int i = 0; i < vetP.Length; i++)
{
    vetP[i] = new Produto();

    System.Console.Write("Código: ");
    vetP[i].Codigo = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Nome: ");
    vetP[i].Nome = Console.ReadLine();
    System.Console.Write("Preço: ");
    vetP[i].Preco = Convert.ToDouble(Console.ReadLine());
}
double totalPrecos = 0;
int precosAcima200 = 0;
foreach (Produto p in vetP)
{
    if (p.Preco > 200)
    {
        precosAcima200++;
    }
    totalPrecos += p.Preco;
    p.Mostrar();
}
 double media = totalPrecos / vetP.Length;
System.Console.WriteLine($"Média dos preços: R${media:C}");
//apresentar vetor 
//calcular a média de preço dos produtos
//contar quntos preços estão acima de 200 reais

