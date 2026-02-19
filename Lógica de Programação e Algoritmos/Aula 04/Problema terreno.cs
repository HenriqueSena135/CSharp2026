using static System.Console;
//Declaração de variáveis
double largura,comprimento,valor,area,preco;
//entrada de dados
WriteLine("Digite a largura do terreno: ");
largura = double.Parse(ReadLine());
WriteLine("Digite o comprimento do terreno: ");
comprimento = double.Parse(ReadLine());
WriteLine("digite o valor do m² do terreno: ");
valor = double.Parse(ReadLine());
//processamento de dados
area = largura * comprimento;
preco = area * valor;
//saida de dados
WriteLine($"a area do terreno é: {area} e preco do terreno é de R$ {preco}");
