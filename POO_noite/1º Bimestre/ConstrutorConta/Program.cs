using ConstrutorConta;

Conta c1 = new Conta();
c1.MostrarAtributos();

Conta c2 = new Conta(2);
c2.MostrarAtributos();

Conta c3 = new Conta(3, "Martarelli", 1000.00);
c3.MostrarAtributos();

System.Console.WriteLine(Conta.Contador);
ClasseEstatica.MostraFrase();
