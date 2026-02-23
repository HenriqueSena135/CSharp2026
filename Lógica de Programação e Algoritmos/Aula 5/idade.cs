using static System.Console;
//Declaração de variáveis
int anos, meses, diasdigitados;
//entrada de dados
WriteLine("Digite a idade em dias: ");
diasdigitados = int.Parse(ReadLine());
//processamento de dados
 anos = diasdigitados / 365 ;
 meses = (diasdigitados % 365)/30;
diasdigitados = (diasdigitados % 365)%30;
//saida de dados
WriteLine($"A idade em anos é: {anos} anos, {meses} meses e {diasdigitados} dias");


