using static System.Console;
Write("Digite a ordem da matriz(maximo =10)");
int n = int.Parse(ReadLine());
int [,] matriz = new int [n,n];

//entrada de dados,inserir vlores na matriz
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write($"Digite o valor para a posição[{i},{j}]: ");
        matriz[i , j] = int.Parse(ReadLine());
    }
}
WriteLine("Matriz Preenchida ");
for (int i =0 ;i< n; i++)
{
    for (int j = 0; j <n ; j++)
    {
        Write(matriz[i,j]+ "\t");
    }
    WriteLine();
}
for (int i = 0; i < n; i++)
{
    Write("Diagonal principal : " + matriz [i,i] + "\t");
    for (int j = 0; j <n ; j++)

    
{
    if(i==j)
        {
            Write(matriz)
        }

    WriteLine("Negativo Encontrado : {negativo}");
}
}


