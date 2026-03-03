using static System.Console;
//declaracao de variaveis
int numero,valor;
try
{
    //entrada de dados
    Write("Quantos numeros voce vai digitar? ");
    numero = int.Parse(ReadLine());
    //processamento de dados
    for (int i = 0; i < numero; i++)
    {
        Write($"Digite um numero: ");
    valor= int.Parse(ReadLine());
    if (valor < 0)
        {
            WriteLine("Numero negativo");
        }
        else if(valor>0)
        {
            WriteLine("numero positivo");
        }
        else
        {
        WriteLine("Nulo");
        }
        if ((valor %2) ==0 )
        {
            WriteLine("par");
        }
        
            else if((valor %2) !=0 )
        {
            WriteLine("impar");

        


    
        }
    }
}
catch (Exception ex)

{
    WriteLine("valores invalidos, erro = ", ex.Message);

}
