//Problema  Baskara
using System.Reflection;
using System.Security.Cryptography;
using static System.Console;
//declarando as variáveis
double a , b ,c , delta, x1, x2;
//entrada de dados
Write("Digite o valor de a: ");
a = double.Parse(ReadLine());
Write("Digite o valor de b: ");
b = double.Parse(ReadLine());
WriteLine("Digite o valor de c: ");
c = double.Parse(ReadLine());
//processamento de dados
delta = (b * b) - (4 * a * c);
//estrutura de controle de decisão - IF

if (delta < 0)
{
  WriteLine("Raizes impossiveis");


} 
else if (delta ==0)
{ 
       x1 = -b/ (2*a);
       x2 = x1;
       WriteLine($"x1 = {x1}\x2 = {x2}");
}
else
{
    x1 =(-b - Math.Sqrt(delta)) /(2*a);
    x2 = (-b + Math.Sqrt(delta)) /(2*a);
    WriteLine($"x1 = {x1}\x2 = {x2}");      
}

    

    
    

