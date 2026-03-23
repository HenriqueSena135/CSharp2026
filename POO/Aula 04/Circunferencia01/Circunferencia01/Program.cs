using static System.Console;

Title = "Calculadora 01";

//Declaração de variaveis
double raio;
const double PI = 3.14;

//entrada de dados
Write("Entre com o valor do raio da circunferencia:");
ForegroundColor = ConsoleColor.Red;
raio = double.Parse(ReadLine());
ResetColor();

//Saida de dados
WriteLine($"Circunferencia : {Circunferencia (raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
WriteLine($"PI:{PI}");
// calculo da circunferencia
double Circunferencia(double raio)
    {
    return 2 * PI * raio ;
    }
//Calcular Volume
double Volume (double r)
{
    return (4 / 3) * PI * r*r*r);

}



