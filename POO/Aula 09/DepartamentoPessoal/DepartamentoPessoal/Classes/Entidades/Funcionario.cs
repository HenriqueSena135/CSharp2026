
namespace DepartamentoPessoal.Classes.entidades
{
    internal class Funcionario
    {
		//Campos
		private string nome;
		private int jornada;
		private double valor;



        //Propriedades

        protected string NomeColoborador
		{
			get { return nome; }
			set { nome = value; }
		}
		protected int Jornada
		{
			get { return jornada; }
			set { jornada = value; }
		}

		protected double ValorHora
		{
			get { return valor; }
			set { valor = value; }
		}

		//contrutores
        public Funcionario(string nomeColoborador, int jornada, double valorHora)
        {
            NomeColoborador = nomeColoborador;
            Jornada = jornada;
            ValorHora = valorHora;
        }
		//metodos
		public  virtual double Pagamento()
		{
			return Jornada * ValorHora;
        }
		public override string ToString()
		{
			return $"{NomeColoborador} - {Pagamento():C}";
        }


    }
}
