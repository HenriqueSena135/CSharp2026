using System;
using System.Collections.Generic;
using ProjetoImposto.Entities;

namespace ProjetoImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            List<Contribuinte> lista = new List<Contribuinte>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nContribuinte #{i}:");
                Console.Write("Pessoa física ou jurídica (f/j)? ");
                char tipo = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda anual: ");
                double renda = double.Parse(Console.ReadLine());

                if (tipo == 'f')
                {
                    Console.Write("Gastos com saúde: ");
                    double saude = double.Parse(Console.ReadLine());

                    lista.Add(new PessoaFisica(nome, renda, saude));
                }
                else
                {
                    Console.Write("Número de funcionários: ");
                    int funcionarios = int.Parse(Console.ReadLine());

                    lista.Add(new PessoaJuridica(nome, renda, funcionarios));
                }
            }

            Console.WriteLine("\nIMPOSTOS PAGOS:");
            double total = 0;

            foreach (Contribuinte c in lista)
            {
                double imposto = c.CalcularImposto();
                Console.WriteLine($"{c.Nome}: R$ {imposto:F2}");
                total += imposto;
            }

            Console.WriteLine($"\nTOTAL DE IMPOSTO: R$ {total:F2}");
        }
    }
}
