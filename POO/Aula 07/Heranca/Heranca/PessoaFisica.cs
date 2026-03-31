

namespace Heranca
{
    internal class PessoaFisica
    {
		//Campo
		private int numero;
		private string titular;
		private double saldo;


        //Propriedades
        public int NumeroConta
		{
			get { return numero; }
			set { numero = value; }
		}
		public string TitularConta
		{
			get { return titular; }
			set { titular = value; }
		}

		public double SaldoConta
		{
			get { return saldo; }
			set { saldo = value; }
		}
		//Construtores
        public PessoaFisica(int numeroConta, string titularConta, double saldoConta)
        {
            TitularConta = titularConta;
            NumeroConta = numeroConta;
            SaldoConta = saldoConta;
        }

		public PessoaFisica(int numeroConta, string titularConta):this(numeroConta, titularConta,0)
        {
            
			SaldoConta = 0;
        }

		public void Saque(double quantia)
		{
			SaldoConta -= quantia;
		}
		public void Deposito(double quantia)
		{
			SaldoConta += quantia;
		}
        public override string ToString()
        {
			 return $"Dados do Cliente:" +
			$"\n\t Numero da Conta: {NumeroConta}" +
			$"\n\t Titular da Conta: {TitularConta}" +
			$"\n\t Saldo da Conta: {SaldoConta:C}";


        }

    }
}
