using ExercicioComposicao;

Banco b1 = new Banco();
b1.AbrirConta(2000.00, 1000);
b1.AbrirConta(34567.98, 100);
b1.AbrirConta(3321.88, 40);
b1.AbrirConta(2234.09, 155);
b1.AbrirPoupanca(234345.22);
b1.AbrirPoupanca(3456.55);
b1.AbrirPoupanca(10000.00);

b1.ExibirContas();
b1.ExibirPoupancas();

b1.AplicarRendimentoPoupanca();