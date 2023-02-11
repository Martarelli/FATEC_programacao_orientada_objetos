// main
Console.WriteLine("Hello, World!");

System.Console.WriteLine("...Programa para calcular a idade...");

System.Console.Write("Informe o ano de nascimento: ");
int ano_nasc = Convert.ToInt32(Console.ReadLine());
int idade = 2023 - ano_nasc;

System.Console.WriteLine("Sua idade é " + idade + " anos.");

//Exemplo estrutura de decisão
if (idade >= 18)
{
    System.Console.WriteLine("Maior de idade");
}
else
{
    System.Console.WriteLine("Menor de idade");

}

int opcao = 1;
switch (opcao)
{
    case 1:
        System.Console.WriteLine("Realizar uma soma");
        break;
    case 2:
        System.Console.WriteLine("Realizar uma subtração");
        break;
    default:
        System.Console.WriteLine("Opção inexistente");
        break;
}

double media = 8;

string situacao = (media >= 6 )? "Passou": "Reprovou";
System.Console.WriteLine("Aluno " + situacao);

System.Console.WriteLine("WHILE");
int cont = 1;
while (cont < 5)
{
    System.Console.WriteLine(cont);
    cont++;
}

System.Console.WriteLine("FOR");
for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine(i);
}

System.Console.WriteLine("DO WHILE");
do
{
    System.Console.WriteLine(cont);
    cont--;
} while (cont > 0);
