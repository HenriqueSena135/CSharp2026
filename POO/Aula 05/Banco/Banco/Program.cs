using Banco;
using static System.Console;
using static System.Globalization.CultureInfo;

Title = "Abertura de Conta";

ContaBancaria conta;

WriteLine("Abertura de Conta - Nika Investment");
Write("Entre Com Um Número de Conta ");
int numero = int.Parse(Console.ReadLine());
Write("Entre com o nome do titular :");
string nome = ReadLine();
Write("Deseja Fazer um Depósito inicial S/N:");
char resposta = char.Parse(Console.ReadLine().ToLower());

if (resposta == 's')
{
    Write("Entre Com Valor de Depósito Inicial : $ ");
    double  deposito = double.Parse(Console.ReadLine());
    conta = new ContaBancaria(numero , nome ,deposito);
}
else
{
     conta = new ContaBancaria(numero, nome);
}

conta.Dados();

WriteLine("Entre Com um Valor para depósito: $ ");
double quantia = double.Parse(Console.ReadLine());
conta.Deposito(quantia);
conta.Dados();
WriteLine("Entre Com Um Valor Para Saque: $ ");
quantia = double.Parse(Console.ReadLine());
conta.Saque(quantia);
conta.Dados();




ReadKey();



