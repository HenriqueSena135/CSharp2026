using static System.Console;
Dictionary<int, double> produtos = new Dictionary<int, double>()
{
    {1,5.00},
    {2,3.50},
    {3,4.80},
    {4,8.90},
    {5,7.32}

};
try
{ 
    WriteLine("Digite o Código ");
    int codigo = int.Parse(ReadLine());

    WriteLine("Digite a quantidade ");
    int quantidade = int.Parse(ReadLine());

    double valor = produtos [codigo]* quantidade;

        WriteLine($"o valor total é de R${valor:F2}");
}catch(Exception ex)
{
    WriteLine($"Digite valores validos, {ex.Message}");

}


