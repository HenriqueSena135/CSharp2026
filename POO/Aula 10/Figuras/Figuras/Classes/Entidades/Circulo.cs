

using Figuras.Classes.Enumeracoes;

namespace Figuras.Classes.Entidades
{
    internal class Circulo : Forma
    {
		//campo
		private double raio;


        //Propriedades
        public double   Raio
		{
			get { return raio; }
			set { raio = value; }
		}

        //Costrutor
        public Circulo(Cor corDaForma ,double raio) : base(corDaForma)
        {
            Raio = raio;
        }
        //Metodo
        public override double Area()
        {
            return Raio * Raio * 3.14;
        }

    }
}
