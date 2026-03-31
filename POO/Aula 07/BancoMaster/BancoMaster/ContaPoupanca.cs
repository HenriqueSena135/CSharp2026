

namespace BancoMaster
{

    class ContaPoupanca : Conta
    {
        private double taxaDeJuros;

        public double TaxaDeJuros
        {
            get { return taxaDeJuros; }
            set { taxaDeJuros = value; }
        }

        public ContaPoupanca(int numero, string titular, double saldoInicial, double taxa)
            : base(numero, titular, saldoInicial)
        {
            taxaDeJuros = taxa;
        }

        public void AtualizacaoDeSaldo()
        {
            Saldo += Saldo * taxaDeJuros;
        }

        public override void Saque(double quantia)
        {
            Saldo -= quantia; // sem taxa
        }
    }

}
