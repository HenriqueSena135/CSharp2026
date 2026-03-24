using System;

namespace ExercicioConversor
{
    class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double Converter(double cotacao, double dolares)
        {
            double valorSemIOF = cotacao * dolares;
            double valorComIOF = valorSemIOF + (valorSemIOF * IOF);
            return valorComIOF;
        }
    }
}
