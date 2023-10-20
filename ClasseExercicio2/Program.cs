using ClasseExercicio2;
using System.Globalization;

Funcionario func1 = new Funcionario();
Funcionario func2 = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
func1.Nome = Console.ReadLine();
Console.Write("Salário: ");
func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário:");
Console.Write("Nome: ");
func2.Nome = Console.ReadLine();
Console.Write("Salário: ");
func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salarioMedio = (func1.Salario + func2.Salario) / 2.0;

Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));