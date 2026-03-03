using static System.Console;
//declaracao de variaveis
int numero;
//entrada de dados
Write("Digite um numero para ver a tabuada: ");
numero = int.Parse(ReadLine());
//processamento de dados
for (int i = 0; i <= 10; i++)
{
    //saida de dados
    WriteLine($"{numero} x {i+1} = {numero * (i+1)}");

}
