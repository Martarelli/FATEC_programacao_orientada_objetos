using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Martarelli", 1000);
Assalariado a2 = new Assalariado(2, "Fulano", 2000);

Comissionado c1 = new Comissionado(3, "Tal pessoa", 1000, 0.2);
Comissionado c2 = new Comissionado(4, "Seu Creison", 1000, 0.5);

Departamento d1 = new Departamento(1, "TI");
d1.Admitir(a1);
d1.Admitir(c1);

Departamento d2 = new Departamento(2, "RH");
d2.Admitir(a2);
d2.Admitir(c2);

d1.ListarFuncionarios();
d2.ListarFuncionarios();

