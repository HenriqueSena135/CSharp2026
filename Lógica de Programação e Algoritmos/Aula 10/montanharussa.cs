using static System.Console;
using static System.Linq.Enumerable;
//declaração de variaveis
int visitantes = 0, contagem = 0;   
double altura_max = 0,altura_min = 0, alturas = 0;
try{

//entrada de dados

Write("digite o numero de visitantes: ");
visitantes = int.Parse(ReadLine());
Write("digite a altura_max: ");
altura_max = double.Parse(ReadLine());
Write("digite a altura_min: ");
altura_min = double.Parse(ReadLine());
//processamento de dados
foreach (int i in Range(0,visitantes))
{
    Write("digite a altura da pessoa n° {i+1}: ");
     alturas =int.Parse(ReadLine());
    if ((alturas < altura_min)& (alturas < altura_max));
    {
        contagem++;
    }

}
WriteLine($"O número de pessoas que podem entrar no parque é: {contagem}");
}
catch (Exception ex)
{
    WriteLine("erro:Entrada_inválida .Por favor insira números inteiro_válidos= ", ex.Message);
}




