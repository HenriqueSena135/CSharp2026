using Banco_1;
using static System.Console;

Title = "Cadastro de conta";
ContaBancaria conta;

//Entrada de dados
Write("Entre com o Número da conta:");
int n = int.Parse(Console.ReadLine());
Write("Entre com o Nome do titular da conta:");
string nome = ReadLine();
Write("Deseja Fazer depósito inicial (s/n):");
char resposta = char.Parse(ReadLine().ToLower());
if (resposta == 's')
{
    Write("Entre com Valor do Depósito inicial:");
    double dep = double.Parse(Console.ReadLine());
    conta = new ContaBancaria(n, nome, dep);
}
else
{
    conta = new(n, nome);
}
conta.Dados();
ReadKey();