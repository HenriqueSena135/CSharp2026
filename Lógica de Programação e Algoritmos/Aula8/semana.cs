// o usuario vai digitar um numero de 1 a 7 e esse codigo vai mostrar o dia da semana correspondente a esse numero ao numero digitado pelo usuario

//declaracao de variaveis
using static System.Console;
int valor;
// entrada de dados
Write("Digite um numero de 1 a 7: ");
valor = int.Parse(Console.ReadLine());
//processamento de dados
if (valor == 1)
{
    WriteLine("Domingo");
}
else if (valor == 2)
{
    WriteLine("Segunda-feira");
}
else if (valor == 3)
{
    WriteLine("Terça-feira");
}
else if (valor == 4)
{
    WriteLine("Quarta-feira");
}
else if (valor == 5)
{
    WriteLine("Quinta-feira");
}
else if (valor == 6)
{
    WriteLine("Sexta-feira");
}
else if (valor == 7)
{
    WriteLine("Sábado");
}
else
{
    WriteLine("Número fora do intervalo,");
}
