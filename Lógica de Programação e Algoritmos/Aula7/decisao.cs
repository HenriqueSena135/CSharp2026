double resultado = 1;
//entrada de dados
System.Console.WriteLine("Digite o numerador para realizar a divisão: ");
double entrada = double.Parse(System.Console.ReadLine());
//processamento de dados
if (entrada > 0)
{
     resultado = 2 / entrada;
}
else
{
        resultado = 2 + entrada;
}
//saída de dados
System.Console.WriteLine($"O resultado é {resultado}");



