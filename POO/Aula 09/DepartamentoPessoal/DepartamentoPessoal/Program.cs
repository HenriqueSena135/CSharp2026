
using DepartamentoPessoal.Classes.entidades;
using static System.Console;

List<Funcionario> colaboradores = new();

Write("Quantos Funcionaros serão registrados? ");
int n = int.Parse(ReadLine());

for (int i = 0; i < n; i++)
{
    WriteLine($"Colaborador N° {i + 1} ");
    Write("O funcionario é Terceiro? (s/n) ");
    char e = char.Parse(ReadLine().ToLower());
    if (e == 'n')
    {
        Write("Nome: ");
        string nome = ReadLine();
        Write("Jornada de trabalho: ");
        int h = int.Parse(ReadLine());
        Write("Valor por hora: ");
        double v = double.Parse(ReadLine());
        colaboradores.Add(new Funcionario(nome, h, v));

    }
    else
    {
        Write("Nome: ");
        string nome = ReadLine();
        Write("Jornada de trabalho: ");
        int h = int.Parse(ReadLine());
        Write("Valor por hora: ");
        double v = double.Parse(ReadLine());
        Write("Despesa adicional:R$ ");
        double d = double.Parse(ReadLine());
        colaboradores.Add(new Terceiro(nome, h, v, d));
    }
}



    WriteLine("-Pagamentos-");
    foreach (var colab in colaboradores)
    {
        WriteLine(colab.ToString());

    }