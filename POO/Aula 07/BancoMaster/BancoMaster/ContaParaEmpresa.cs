

namespace BancoMaster;

  
    
         internal class ContaParaEmpresa : Conta
        {
            private double limiteDeEmprestimo;

            public double LimiteDeEmprestimo
            {
                get { return limiteDeEmprestimo; }
                set { limiteDeEmprestimo = value; }
            }

            public ContaParaEmpresa(int numero, string titular, double saldoInicial, double limite)
                : base(numero, titular, saldoInicial)
            {
                limiteDeEmprestimo = limite;
            }

            public void Emprestimo(double quantia)
            {
                if (quantia <= limiteDeEmprestimo)
                {
                    Saldo += quantia;
                }
                else
                {
                    Console.WriteLine("Limite excedido!");
                }
            }
        }
    

