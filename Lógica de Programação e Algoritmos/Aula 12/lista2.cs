using static System.Console;
//declaração de variaveis
int n;
List<double> numeros = new List<double>();
//entrada de dados
Write("Quantos numeros voce vai digitar");
n = int.Parse(ReadLine());

for(int i = 0; i <  n; i++)
{
    Write("Digite um numero; ");
    numeros.Add(double.Parse(ReadLine()));
}

 Write("Valores = ");

for(int i = 0; i<n;i++)
{
   
    Write($"{numeros[i]} ");
}

Write($"\nSoma = {numeros.Sum()}");
Write($"\nmédia = {numeros.Average()}");