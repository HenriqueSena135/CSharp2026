using static System.Console;
//declaracao de variaveis
int codigo, quantidade;
//entrada de dados
Write("Digite o codigo do produto: ");
codigo = int.Parse(ReadLine());
Write("Digite a quantidade: ");
quantidade = int.Parse(ReadLine());
//processamento de dados
switch (codigo)
{
    case 1:
        WriteLine($"O valor total é: {quantidade * 5.00}");
        break;
    case 2:
        WriteLine($"O valor total é: {quantidade * 4.50}");
        break;
    case 3:
        WriteLine($"O valor total é: {quantidade * 3.75}");
        break;
    case 4:
        WriteLine($"O valor total é: {quantidade * 8.99}");
        break;
    case 5:
        WriteLine($"O valor total é: {quantidade * 11.33}");
        break;
}