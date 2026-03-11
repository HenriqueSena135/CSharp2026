using static System.Console;
//declaração de variaveis
int visitantes ,altura_de_pessoas, altura_minima, altura_maxima;
try
//entrada de dados
{

    

Write("digite visitantes: ");
visitantes = int.Parse(ReadLine());
Write("digite a altura de pessoas: ");
altura_de_pessoas = int.Parse(ReadLine());
Write("digite a altura_minima: ");
altura_minima = int.Parse(ReadLine());
Write("digite a altura_maxima: ");
altura_maxima = int.Parse(ReadLine());


//processamento de dados
for (int i = 0 ; i < visitantes; i++)
{
    if (altura_de_pessoas < altura_minima)
    {
        WriteLine("Acesso negado");
    }
    else if (altura_de_pessoas > altura_maxima)
    {
        WriteLine("Acesso negado");
    }
    
    else
    {
        WriteLine("Acesso permitido");
    }
}

}
catch (Exception ex )



{
    WriteLine("erro:Entrada_inválida .Por favor insira números inteiro_válidos= ", ex.Message);

}
 