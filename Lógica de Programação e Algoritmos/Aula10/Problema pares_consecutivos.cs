using static System.Console;
//declaração de variaveis
int x ,resultado;
while(true){
    Write("Digite um número inteiro ou zero para sair: ");
    x = int.Parse(ReadLine());
    if(x == 0)
    {
        WriteLine("Programa encerrado.");
        break;
    }

    if((x%2) == 0)
    {
        //numero par
        WriteLine("O número é par.");
       resultado = x+ (x+2) + (x+4) + (x+6) + (x+8);
    }
    else
    {
        //numero impar
        WriteLine("O número é ímpar.");
        resultado = (x+2) + (x+4) + (x+6) + (x+8);
    }
    WriteLine($"A soma : {resultado}");
}

