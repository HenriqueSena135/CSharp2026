using static System.Console;
//Declaração de variáveis
double valor , quantidade , valorrecebido,troco;
//entrada de dados
WriteLine("Digite o valor: ");
valor = double.Parse(ReadLine());
WriteLine("Digite a quantidade: ");
quantidade = double.Parse(ReadLine());
WriteLine("Digite o valor recebido: ");
valorrecebido = double.Parse(ReadLine());
//processamento de dados
troco = valorrecebido -(quantidade * valor);
//saida de dados
WriteLine($"O valor do troco é: R$ : {troco}");
