using System.Reflection;
using static System.Console;
//declarando as variáveis
double nota1 , nota2,resultado;
//entrada de dados
Write("Digite a nota1: ");
nota1 = double.Parse(ReadLine());
Write("digite a nota2: ");
nota2 = double.Parse(ReadLine());
//processamento de dados
resultado = (nota1 + nota2) / 2;
if (resultado < 60)
{
        WriteLine($"Nota final = {resultado}");
        WriteLine("Aluno reprovado");
}
else
{
        WriteLine($"Nota final = {resultado}");
        WriteLine("Aluno aprovado");
}



