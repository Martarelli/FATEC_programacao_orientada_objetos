//funcao Main()

using ClasseConta;

Conta c1;
c1 = new Conta();
c1.numero = 10001;
c1.titular = "Martrelli";

System.Console.WriteLine("Numero: " + c1.numero);
System.Console.WriteLine("Titular: " + c1.titular);
System.Console.WriteLine("Saldo: " + c1.saldo);

Conta c2 = new Conta();
