

namespace ProjetoImposto.Entities
{
    public class PessoaFisica : Contribuinte
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude)
            : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalcularImposto()
        {
            double imposto;

            if (RendaAnual < 20000.0)
                imposto = RendaAnual * 0.15;
            else
                imposto = RendaAnual * 0.25;

            imposto -= GastosSaude * 0.5;

            return imposto < 0 ? 0 : imposto;
        }
    }
}