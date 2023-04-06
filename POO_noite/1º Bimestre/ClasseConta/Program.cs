//funcao Main()

using ClasseConta;

Conta c1;
c1 = new Conta();
c1.numero = 10001;
c1.titular = "Martarelli";
c1.saldo = 152635.25;
c1.MostrarAtributos();


Conta c2 = new Conta();
c2.numero = 10002;
c2.titular = "Fulano";
c2.saldo = 835.25;
c2.MostrarAtributos();

Conta c3 = new Conta();
c3.numero = 10003;
c3.titular = "Fulano";
c3.saldo = 15200.25;
c3.MostrarAtributos();

c1.Transferencia(200000, c3);