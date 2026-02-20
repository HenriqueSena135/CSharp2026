using static System.Console;
//Declaração de variáveis;
double Base, Altura, Area ,Perimetro , Diagonal;
//entrada de dados
WriteLine("Digite a base do retângulo: ");
Base = double.Parse(ReadLine());
WriteLine("Digite a altura do retângulo: ");
//processamento de dados
Altura = double.Parse(ReadLine());
Area = Base * Altura;
Perimetro = 2 * (Base + Altura);
Diagonal = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
//saida de dados
WriteLine($"A área do retângulo é: {Area}");
WriteLine($"O perímetro do retângulo é: {Perimetro}");
WriteLine($"A diagonal do retângulo é: {Diagonal}");






