using static System.Console;

static void total(int qtd,double valor)
{
     WriteLine($"O valor total é: {qtd * valor}");
}



//declaracao de variaveis
int codigo, quantidade;
//entrada de dados
try {
Write("Digite o codigo do produto: ");
codigo = int.Parse(ReadLine());
Write("Digite a quantidade: ");
quantidade = int.Parse(ReadLine());
//processamento de dados
switch (codigo)
{
    case 1:
            total(quantidade,5.00);
        //WriteLine($"O valor total é: {quantidade * 5.00}");
        break;
    case 2:
            total(quantidade,4.50);
        //WriteLine($"O valor total é: {quantidade * 4.50}");
        break;
    case 3:
            total(quantidade,3.75);
       // WriteLine($"O valor total é: {quantidade * 3.75}");
        break;
    case 4:
            total(quantidade,8.99);
        //WriteLine($"O valor total é: {quantidade * 8.99}");
        break;
    case 5:
            total(quantidade,11.33);
        //WriteLine($"O valor total é: {quantidade * 11.33}");
        break;
        default:
         WriteLine("Codigo invalido");
         break;
}
}
catch (Exception ex)

{

     WriteLine("Digite valores validos ,erro:{ex.Message}");  
} 