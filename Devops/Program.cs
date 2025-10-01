using Devops.Models;

Calculadora calculadora = new Calculadora();

calculadora.A = 3;
calculadora.B = 2;

var result = Calculadora.Soma(calculadora.A, calculadora.B);
Console.WriteLine(result);
