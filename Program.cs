using System;
using System.Collections.Generic;
using System.Text;
using Atividade2Fiap1106.Model;



namespace Atividade2Fiap1106
{
     class Program
    {
        static void Main(string[] args)
        {
            //Ler dados do imput do usuário
            Console.WriteLine("Digite o Id");
            var id = (Console.ReadLine());

            Console.WriteLine("Nome do produto");
            string nome =(Console.ReadLine());

            Console.WriteLine("Digite o Preço");
            decimal preco = decimal.Parse(Console.ReadLine());

           Console.WriteLine("Digite o estoque");
            int stoque =int.Parse(Console.ReadLine());

            Console.WriteLine("Digite amarca");
            string marca = Console.ReadLine();
            Console.Clear();

             //Criando o objeto
            Produto produto = new Produto();
            produto.Idproduto = id;
            produto.Nome = nome;
            produto.Preco = preco;
            produto.Estoque = stoque;
            produto.Marca = marca;

            //Chamar o metodo
            produto.Exibirdados();

            //Chamando o metodo com desconto
            Console.WriteLine("Digite o desconto");
            decimal Valordedesconto1 = decimal.Parse(Console.ReadLine());
            decimal valor = produto.CalculadoraValordedesconto(Valordedesconto1);
            Console.WriteLine($"Valor do desconto {valor}");
            Console.ReadKey();
     


            




        }
    }
}
