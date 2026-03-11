using static System.Console;
//declarando as variáveis
double a,b, c, triangulo, areaTra;
//entrada de dados
Write("Digite o valor a:");
a= double.Parse(ReadLine());
Write("Digite o valor de b:");
b =double.Parse(ReadLine());
Write("Digite o valor de c:");
c = double.Parse(ReadLine());
//processamento de dados
if (a < b + c & b < a + c & c < a + b)
{
    double p = (a + b + c) / 2;
    triangulo = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    WriteLine($"A area do triangulo é {triangulo}");
}
else
{
    WriteLine("Os valores não formam um triangulo");
    areaTra = ((a + b)*c)/2;
    WriteLine($"A area do trapezio é {areaTra}");
}

