using exemplocomPOO;
using static System.Console;

Triangulo x = new Triangulo();
Triangulo y = new Triangulo();

WriteLine("Digite a medidas do Triangulo x");
Write("Digite a medida A:");
x.ladoA = double.Parse(ReadLine());
Write("Digite a medida B:");
x.ladoB = double.Parse(ReadLine());
Write("Digite a medida C:");
x.ladoC = double.Parse(ReadLine());

WriteLine("Digite a medidas do Triangulo y");
Write("Digite a medida A:");
y.ladoA =double.Parse(ReadLine());
Write("Digite a medida B:");
y.ladoB=double.Parse(ReadLine());
Write("Digite a medida C:");
y.ladoC=double.Parse(ReadLine());

//saida de dados
WriteLine($"A area do triangulo x é de{x.Area()}");
WriteLine($"A area do triangulo y é de{y.Area()}");
ReadKey();




