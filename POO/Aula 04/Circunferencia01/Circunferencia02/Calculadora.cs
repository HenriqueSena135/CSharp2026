

namespace Circunferencia02
{
    internal class Calculadora
    {
        //campo
        public const double PI = 3.14;
        public double raio;

        public Calculadora(double raio)
        {
            this.raio = raio;
        }
        // metodos
        public double Circunferencia()
        {
            return 2 * PI * raio;
        }
        public double Volume()
        {
            return (4 / 3) * Math.Pow(raio,3);
        }
        public string Pi()
        {
            return $"{PI}";
        }
    }
}
