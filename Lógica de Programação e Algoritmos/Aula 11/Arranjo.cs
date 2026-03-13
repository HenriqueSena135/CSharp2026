using static System.Console;
using static System.Linq.Enumerable;
//declaração
int n;
//entrada
Write("Quantos números você vai digitar ? ");
n = int.Parse(ReadLine());
if (n<0)
{
    WriteLine("Valor invalido,digite somente números positivos");
}
else if (n>10)
{
    WriteLine("Maximo de valores para digitar igual a 10");
    WriteLine("Tente novamente!");
}
else
{
    //declaração
    int [] numeros = new int [n];
    for (int i = 0; i <numeros.Length ; i++)
    {
        Write($"Digite  o {i+1}° números: ");
        numeros[i]=int.Parse(ReadLine());
    }
    WriteLine("NÚMERO NEGATIVO : ");
    foreach (int item in Range(0,numeros.Length))
    {
        if (numeros[item]<0);
        {
            WriteLine(numeros[item]);
        }
    }
}


