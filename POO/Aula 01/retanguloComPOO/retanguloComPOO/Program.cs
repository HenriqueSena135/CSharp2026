using retanguloComPOO;
using static System.Console;
//Declaração de variáveis;
retangulox x = new Retangulo();
retanguloy y = new Retangulo();
//entrada de dados
WriteLine("Digite a largura do retângulox x: ");
x.largura  = double.Parse(ReadLine());
WriteLine("Digite a altura do retângulox x: ");
//processamento de dados
x.altura  = double.Parse(ReadLine());
x.area  = x.largura  * x.altura ;
x.perimetro  = 2 * (x.largura  + x.altura );
x.diagonal  = Math.Sqrt(Math.Pow(x.largura , 2) + Math.Pow(x.altura , 2));
x.Processo();

WriteLine("Digite a largura do retânguloy y: ");
y.largura = double.Parse(ReadLine());
WriteLine("Digite a altura do retânguloy y: ");
y.altura = double.Parse(ReadLine());
y.area = y.largura * y.altura;
y.perimetro = 2 * (y.largura + y.altura);
y.diagonal = Math.Sqrt(Math.Pow(y.largura, 2) + Math.Pow(y.altura, 2));
y.Processo();
//saida de dados
WriteLine($"A área do retângulox x e:{x.area }");
WriteLine($"O perímetro do retângulox x é:{x.perimetro }");
WriteLine($"A diagonal do retângulox x é :{x.diagonal }");

WriteLine($"A área do retânguloy y e:{y.area}");
WriteLine($"O perímetro do retânguloy y é:{y.perimetro}");
WriteLine($"A diagonal do retânguloy y é :{y.diagonal}");
ReadKey();
