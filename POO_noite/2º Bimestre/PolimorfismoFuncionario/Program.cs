using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Martarelli", 1000);
System.Console.WriteLine($"{f.Nome} - Bonificação {f.CalcularBonificacao():C}");

Secretario s = new Secretario(1, "Gabi", 1000, 11);
System.Console.WriteLine($"{s.Nome} - Bonificação {s.CalcularBonificacao():C}");