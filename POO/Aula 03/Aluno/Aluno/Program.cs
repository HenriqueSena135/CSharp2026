using System;
using System.Globalization;

namespace ProjetoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.NomeDoAluno = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");

            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Nota final do aluno: "
                + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.AprovadoOuReprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram "
                    + aluno.Ponto().ToString("F2", CultureInfo.InvariantCulture)
                    + " pontos");
            }
        }
    }
}
