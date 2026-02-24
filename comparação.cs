using static System.Console;
//Declaração de variáveis
int primeirovalor,segundovalor,terceirovalor;
//entrada de dados
WriteLine("Digite o primeirovalor: ");
primeirovalor = int.Parse(ReadLine());
WriteLine("Digite o segundovalor: ");
segundovalor = int.Parse(ReadLine());
WriteLine("Digite o terceirovalor: ");
terceirovalor = int.Parse(ReadLine());
//processamento de dados
bool valor1 = primeirovalor == terceirovalor;
bool valor2 = segundovalor != primeirovalor;
bool valor3 = segundovalor > terceirovalor;
bool valor4 = primeirovalor <= terceirovalor;

WriteLine($"O primeirovalor é = terceirovalor ? {primeirovalor == terceirovalorvalor}");
WriteLine($"O segundovalor é diferente do primeirovalor ? {segundovalor != primeirovalor}");
WriteLine($"O segundovalor é > que o terceirovalor ? {segundovalor > terceirovalor}");
WriteLine($"O primeirovalor é <= o terceirovalor ? {primeirovalor <= terceirovalor}");
bool perg1 = primeirovalor & terceirovalor;
WriteLine($"O resultado da comparação é {perg1}");
bool perg2 = segundovalor | 




