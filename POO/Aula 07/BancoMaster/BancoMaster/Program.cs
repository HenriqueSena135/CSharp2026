using System;
using BancoMaster;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 - Poupança | 2 - Empresa");
        int tipo = int.Parse(Console.ReadLine());

        Console.Write(" Digite o Número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write(" Digite o Nome do Titular: ");
        string titular = Console.ReadLine();

        Console.Write("Saldo inicial: ");
        double saldo = double.Parse(Console.ReadLine());

        Conta conta;

        if (tipo == 1)
        {
            Console.Write("Taxa de juros: ");
            double taxa = double.Parse(Console.ReadLine());

            conta = new ContaPoupanca(numero, titular, saldo, taxa);
        }
        else
        {
            Console.Write("Limite de empréstimo: ");
            double limite = double.Parse(Console.ReadLine());

            conta = new ContaParaEmpresa(numero, titular, saldo, limite);
        }

        Console.Write("Depósito: ");
        conta.Deposito(double.Parse(Console.ReadLine()));

        Console.Write("Saque: ");
        conta.Saque(double.Parse(Console.ReadLine()));

        Console.WriteLine("Saldo final: " + conta.Saldo);

        Console.ReadKey();
    }
}
