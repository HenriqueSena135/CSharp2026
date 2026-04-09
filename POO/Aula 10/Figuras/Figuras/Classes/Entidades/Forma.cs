
using Figuras.Classes.Contratos;
using Figuras.Classes.Enumeracoes;
namespace Figuras.Classes.Entidades
{
     abstract internal class Forma : IArea
    {
        /// <summary>
        ///   Cores disponiveis vermelho,Azul,Amarelo e Rosa                      
        /// </summary>
        ///
        
        //Campo
        private Cor  cor;


        //Propriedades
        protected Cor CorDaForma
        {
            get { return cor; }
            set { cor = value; }
        }
        //Construtor
        public Forma(Cor corDaForma)
        {
            CorDaForma = corDaForma;
        }

        //Metodo
        abstract public double Area();
       
    }
}
