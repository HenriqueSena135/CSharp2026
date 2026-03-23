using System;
using System.Globalization;

namespace RetanguloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e depois a altura do retângulo:");

            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nValores digitados foram:");
            Console.WriteLine($"Largura = {r.Largura.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Altura = {r.Altura.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"\nA área do retângulo é de {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"O perímetro do retângulo é de {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A diagonal do retângulo é de {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}