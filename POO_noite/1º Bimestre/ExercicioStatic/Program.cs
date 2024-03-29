﻿/* Criar a classe funcionário que tenha como atributos: código, nome, salário.  
Implemente os conceitos de orientação a objetos utilizados até o momento, para isso instancie alguns funcionários e identifique quantos tem.
Crie um método que calcule e mostre o novo salário aplicando um reajuste salarial a partir de um valor informado.
Use o construtor static para predeterminar que o código do funcionário comece de 100
Realize 3 instâncias */
using ExercicioStatic;

Funcionario f1 = new Funcionario(Funcionario.Contador);
f1.Nome = "Martarelli";
f1.Salario = 2000.00;
f1.MostrarAtributos();
f1.Reajuste(20);

Funcionario f2 = new Funcionario(Funcionario.Contador);
f2.Nome = "Gabi";
f2.Salario = 5000.00;
f2.MostrarAtributos();
f2.Reajuste(15);

Funcionario f3 = new Funcionario(Funcionario.Contador);
f3.Nome = "Doidinha";
f3.Salario = 1000.00;
f3.MostrarAtributos();
f3.Reajuste(33);

System.Console.WriteLine($"Quantidade de funcionários = {Funcionario.Contador - 100}");
