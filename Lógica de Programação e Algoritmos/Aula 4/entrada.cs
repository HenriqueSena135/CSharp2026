//Entrada de dados
using System.Security.Cryptography;

Console.WriteLine("Digite o seu nome: ");
string nome =Console.ReadLine();//entrada de dados
Console.WriteLine($"o valor digitado é de {nome}");
Console.WriteLine("digite o 1º numero: ");
double x = double.Parse(Console.ReadLine());//conversao de dados
Console.WriteLine("digite o 2º numero: ");
double y = double.Parse(Console.ReadLine());//conversão de dados

//processamento de dados
double soma = x + y;

//Saida de de dados
Console.WriteLine($"a soma dos valores é: {soma}");