using ExercicioHeranca;

Funcionario f = new Funcionario(1, "Funcionario", 1000, 10.5);
f.CalcularSalario();

Mensalista m = new Mensalista(2, "Mensalista", 1000, 12.5, 220);
m.CalcularSalario();

Horista h = new Horista(3, "Horista", 1000, 15, 20);
h.CalcularSalario();
