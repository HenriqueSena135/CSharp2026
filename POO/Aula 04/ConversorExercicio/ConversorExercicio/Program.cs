using System;
using System.Globalization;

namespace ExercicioConversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = ConversorDeMoeda.Converter(cotacao, dolares);

            Console.WriteLine("Valor a ser pago em reais = "
                + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
