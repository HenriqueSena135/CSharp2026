using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace exemplo1
{
    internal class Produto
    {
        // campos
        public string nome;
        public double preco;
        public int quantidade;

        //construtor
        public Produto (string nome, double preco, int quantidade)

        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;

        }


        //metodos

        public double Valor_Total_em_estoque()
        {
            return preco * quantidade;
        }

        public void Adicionar_Produtos(int qtd)
        {
            quantidade += qtd;
        }
        public void Remover_Produtos(int qtd)
        {
            quantidade -= qtd;

        }
        public string Dados_do_Produto()
        {
            return $"nome : {nome} , preço : {preco} ,  quantidade : {quantidade}"  + 
                $"Total: {Valor_Total_em_estoque()}";
        }


    }
}
