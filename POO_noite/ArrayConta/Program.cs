using Internal;
using System;
using ClasseConta;

Conta[] vetConta = new Conta[3];

for (int i = 0; i < vetConta.length; i++)
{
    vetConta[i] = new Conta();
    System.Console.Write("Digite o número: ");
    vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Digite o titular: ");
    vetConta[i].numero = Console.ReadLine();
    System.Console.Write("Digite o saldo: ");
    vetConta[i].numero = Convert.ToDouble(Console.ReadLine());
}

foreach (Conta c in vetConta)
{
    c.MostrarAtributos();
}

