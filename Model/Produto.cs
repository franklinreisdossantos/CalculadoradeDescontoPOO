using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade2Fiap1106.Model
{
     class Produto
    {
        //Propiedades informaçoes que o objeto armazena
        public string Idproduto { get; set; }
        public  string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Pneu { get; set; }

        public int Estoque { get; set; }

        public string Marca { get; set; }

        //acões queobjeto pode executar
        public void Exibirdados()
        {
            Console.WriteLine($"***Id do produto:{Idproduto}***\n***  Nome:{Nome}***\n*** Preço: {Preco}***\n *** Estoque: {Estoque}***\n ***Marca:{Marca}***");
        }

        public decimal CalculadoraValordedesconto( decimal  Valordedesconto)
        {
            decimal valorfinal = Preco - Valordedesconto;
            return valorfinal;
        }
    }
}
