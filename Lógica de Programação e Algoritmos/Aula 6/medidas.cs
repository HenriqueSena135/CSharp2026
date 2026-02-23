
using static System.Console;
try{
//Declaração de variáveis
double a , b ,c , areaQuadrado, areaTriangulo, areaTrapesio;
//entrada de dados
Write("Digite a medida A: ");
a = double.Parse(ReadLine());
Write("Digite a medida B: ");
b = double.Parse(ReadLine());
Write("Digite a medida c : " );
c = double.Parse(ReadLine());
//processamento de dados
areaQuadrado = a * a;
areaTriangulo = (b * c) / 2;
areaTrapesio = ((a + b) * c) / 2;
//saida de dados
WriteLine($"Area do quadrado é :{areaQuadrado:F4}");
WriteLine($"Area do triangulo é: {areaTriangulo:F4} ");
WriteLine($"Area do trapezio é: {areaTrapesio:F4} ");
}
catch (Exception)
{
    WriteLine($"Valores invalidos inseridos, programa encerrado.");
}


