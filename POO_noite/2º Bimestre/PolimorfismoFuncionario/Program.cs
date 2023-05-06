using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Martarelli", 1000);
System.Console.WriteLine($"{f.Nome} - Bonificação {f.CalcularBonificacao():C}");

Secretario s = new Secretario(1, "Gabi", 1000, 11);
System.Console.WriteLine($"{s.Nome} - Bonificação {s.CalcularBonificacao():C}");

Gerente g = new Gerente(1, "Fulano", 2000);
System.Console.WriteLine($"{g.Nome} - Bonificação {g.CalcularBonificacao():C}");

Diretor d = new Diretor(1, "Fulano", 2000);
System.Console.WriteLine($"{d.Nome} - Bonificação {d.CalcularBonificacao():C}");