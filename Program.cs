using ConsolePOOAluno.Entidade;
using System.Globalization;

Aluno aluno = new Aluno();
Console.Write("Informe o nome do aluno: ");
aluno.Nome = Console.ReadLine();

Console.Write("Informe a primeira nota: ");
aluno.Nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Informe a Segunda nota: ");
aluno.Nota += double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Informe a terceira nota: ");
aluno.Nota += double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine(aluno);

