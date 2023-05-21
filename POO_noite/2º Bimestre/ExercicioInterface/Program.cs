using ExercicioInterface;

ContaCorrente c1 = new ContaCorrente();
c1.Saldo = 1000;

ContaCorrente c2 = new ContaCorrente();
c2.Saldo = 2000;

SeguroDeVida s1 = new SeguroDeVida();
SeguroDeVida s2 = new SeguroDeVida();

TotalizadorDeTributos tt = new TotalizadorDeTributos();
ITributavel it = c1;
tt.Adiciona(it);
ITributavel it = c2;
tt.Adiciona(it);
ITributavel it = s1;
tt.Adiciona(it);
ITributavel it = s2;
tt.Adiciona(it);

System.Console.WriteLine($"Total dos tributos: {tt.Total:C}");



