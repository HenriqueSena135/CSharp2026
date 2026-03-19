using System;
using System.Collections.Generic;
using System.Text;

namespace terreno
{
    internal class Terreno
    {
        // campos
        public double largura, comprimento, valor;

        //construtor

        public Terreno(double largura, double comprimento, double valor)

        {
            this.largura = largura;
            this.comprimento = comprimento;
            this.valor = valor;
        }

        //metodos
        public double Area()
        {
            return largura * comprimento; 
        }
        public double Preco()
        {
            return Area() * valor;
        }
        public void Saida()
        {
            Console.WriteLine($"Area do terreno = {Area()}");
            Console.WriteLine($"Preço do terreno = R$ {Preco()}");
        }
    }
}
