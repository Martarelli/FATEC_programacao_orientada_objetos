using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Martarelli", 1000);
Assalariado a2 = new Assalariado(2, "Fulano", 2000);

Comissionado c1 = new Comissionado(3, "Tal pessoa", 1000, 0.2);
Comissionado c2 = new Comissionado(4, "Seu Creison", 1000, 0.5);

a1.Mostrar();
System.Console.WriteLine($"Novo salario: {a1.CalcularSalario(30):C}\n");
a2.Mostrar();
System.Console.WriteLine($"Novo salario: {a2.CalcularSalario(30):C}\n");

c1.Mostrar();
System.Console.WriteLine($"Novo salario: {c1.CalcularSalario(25):C}\n");
c2.Mostrar();
System.Console.WriteLine($"Novo salario: {c2.CalcularSalario(30):C}\n");

