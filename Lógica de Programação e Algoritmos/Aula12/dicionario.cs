using static System.Console;
//declaração de um dicionario
Dictionary<string, int> pesssoas = new Dictionary<string, int>()
// adicionando dados ao dicionario
{
    {"João",20},
    {"Maria",30},
    {"Pedro",40},
};
pesssoas.Add("Clodoaldo", 54);
WriteLine($"Tamanho = {pesssoas.Count()}");
WriteLine(pesssoas["Clodoaldo"]);
WriteLine($"Tamanho ={pesssoas.Count()}");
pesssoas.Remove("Clodoaldo");
WriteLine($"Tamanho = {pesssoas.Count()}");

