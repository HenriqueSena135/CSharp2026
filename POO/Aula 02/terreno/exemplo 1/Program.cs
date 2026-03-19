using static System.Console;
using exemplo1;
WriteLine("Entre com os dados do Produto :");
Write("Nome:");
string nome = ReadLine();
Write("Preço:");
double preco = double.Parse(ReadLine());
Write("Quantidade :");
int qtd = int.Parse(ReadLine());



Produto p = new Produto(nome,preco,qtd);
Console.WriteLine($"Dados do Produto {p.Dados_do_Produto()}");

Write("Digite a quantidade do produto a ser adicionado no estoque:");
qtd = int.Parse(ReadLine());
p.Adicionar_Produtos(qtd);
WriteLine($"Dados atualizados:{p.Dados_do_Produto()}");
Write("digite a quantidade do produto a serem removidos do estoque: ");
qtd = int.Parse(ReadLine());
p.Remover_Produtos(qtd);
Write($"Dados atualizados:{p.Dados_do_Produto()}");
ReadKey();
"


