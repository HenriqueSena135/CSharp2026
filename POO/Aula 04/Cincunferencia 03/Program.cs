using static System.Console;
using static System.ConsoleColor;
using static Cincunferencia_03.Calculadora;

Title = "Calculadora 03";
Write("Digite o raio da cincunferencia:");
ForegroundColor = Red;
double raio = double.Parse(Console.ReadLine());
ResetColor();
// saida de dados
WriteLine($"Cincunferencia: {Circunferencia(raio): F2}");
WriteLine($"Volume:{Volume(raio):F2}");
Write($"PI : {PI}");

