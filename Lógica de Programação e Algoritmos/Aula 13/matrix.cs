using static System.Console;

int [,] matriz = new int [3,3];

//entrada de dados,inserir vlores na matriz
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Write($"Digite o valor para a posição[{i},{j}]: ");
        matriz[i , j] = int.Parse(ReadLine());
    }
}
WriteLine("Matriz Preenchida ");
for (int i =0 ;i< 3; i++)
{
    for (int j = 0; j <3 ; j++)
    {
        Write(matriz[i,j]+ "\t");
    }
    WriteLine();
}

