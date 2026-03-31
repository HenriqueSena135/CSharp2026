

namespace Heranca
{
    internal class PessoaJuridica : PessoaFisica
    {
        //Campos
        private double limite;

        //Propriedades

        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        public PessoaJuridica(int numeroConta, string titularConta,double LimiteConta) : base(numeroConta, titularConta)
        {
            LimiteEmprestimo = LimiteConta;
        }

        public PessoaJuridica(int numeroConta, string titularConta, double saldoConta , double LimiteConta) : base(numeroConta, titularConta, saldoConta)
        {
            LimiteEmprestimo = LimiteConta;
        }
        //Metodos
        public void Limite(double quantia)
        {
            SaldoConta += quantia;
        }
       


    }
}
