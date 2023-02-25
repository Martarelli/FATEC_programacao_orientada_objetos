using ArrayFuncionario;

Funcionario[] vetF = new Funcionario[3];

for (int i = 0; i < vetF.Length; i++)
{
    vetF[i] = new Funcionario();
    System.Console.Write("Digite o código: ");
    vetF[i].codigo = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Digite o nome: ");
    vetF[i].nome= Console.ReadLine();
    System.Console.Write("Digite o salário: ");
    vetF[i].salario = Convert.ToDouble(Console.ReadLine());
}
/* CADASTRAR 3 FUNCIONARIOS
CALCULAR A MEDIA SALARIAL
APRESENTAR NOME E SALARIAL DE QUEM RECEBE MAIS DE 300 REAIS
CRIAR UM METODO NA CLASSE FUNCIONARIO PARA APLICAR AUMENTO AOS SALARIOS MENORES QUE 300 REIAS */

double somaSalarios = 0;
foreach (Funcionario f in vetF)
{
    somaSalarios += f.salario;
}
System.Console.WriteLine("\n--------------- MEDIA SALARIOS ---------------");
System.Console.WriteLine($"A média de salário é: {somaSalarios/vetF.Length:C}");

System.Console.WriteLine("\n--------------- SALARIOS > R$300,00 ---------------");
foreach (Funcionario f in vetF)
{
    if (f.salario > 300)
    {
        System.Console.WriteLine($"Nome: {f.nome}\tSalário: {f.salario:C}\n");
    }
}

System.Console.WriteLine("\n--------------- SALARIOS COM AUMENTO ---------------");
foreach (Funcionario f in vetF)
{
    f.AumentoSalario();
}

foreach (Funcionario f in vetF)
{
    f.MostrarDados();
}