using ProjetoImposto.Interfaces;

namespace ProjetoImposto.Entities
{
    public abstract class Contribuinte : IImposto
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalcularImposto();
    }
}
