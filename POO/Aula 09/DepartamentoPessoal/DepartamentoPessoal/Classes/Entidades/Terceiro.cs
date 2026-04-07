

namespace DepartamentoPessoal.Classes.entidades
{
    internal class Terceiro : Funcionario

    {
		//Campos
		private double despesa;


        //propriedade

        public double DespesaAdicional
		{
			get { return despesa; }
			set { despesa = value; }
		}
        //contrutor
        public Terceiro(string nomeColoborador, int jornada, double valorHora,double despesa) : base(nomeColoborador, jornada, valorHora)
        {
            DespesaAdicional = despesa;
        }
        //metodo
        public override double Pagamento()
        {
            return base.Pagamento() + (DespesaAdicional * 0.2);
        }

    }
}
