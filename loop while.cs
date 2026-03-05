using System;

class Program
{
    static void Main(string[] args)
    {
        int totalTuristas = 0;
        string opcao;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aplicativo de controle de fluxo carros");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Parque Nacional os Lençóis Maranhenses");
        Console.ResetColor();

        Console.WriteLine("\nBem-vindo ao aplicativo de controle de fluxo de carros!");

        while (true)
        {
            Console.Write("\nDigite o fluxo de carro (entrada/saida)\nou sair para encerrar a aplicação: ");
            opcao = Console.ReadLine()?.ToLower();

            if (opcao == "sair")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSaindo do aplicativo...");
                Console.WriteLine("Aplicativo encerrado.");
                Console.ResetColor();
                break;
            }

            if (opcao != "entrada" && opcao != "saida")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Por favor, digite 'entrada' ou 'saida'.");
                Console.ResetColor();
                continue;
            }

            Console.Write("Digite o número de turistas: ");
            if (!int.TryParse(Console.ReadLine(), out int numeroTuristas) || numeroTuristas < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Número inválido.");
                Console.ResetColor();
                continue;
            }

            DateTime agora = DateTime.Now;

            if (opcao == "entrada")
            {
                totalTuristas += numeroTuristas;

                Console.WriteLine($"\nEntrada registrada em: {agora}");
                Console.WriteLine($"Entrada de {numeroTuristas} turistas registrada.");
            }
            else
            {
                totalTuristas -= numeroTuristas;
                if (totalTuristas < 0)
                    totalTuristas = 0;

                Console.WriteLine($"\nSaída registrada em: {agora}");
                Console.WriteLine($"Saída de {numeroTuristas} turistas registrada.");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total de turistas no parque: {totalTuristas}");
            Console.ResetColor();
        }
    }
}
    
