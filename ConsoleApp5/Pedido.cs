using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Pedido
    {
        public int Numero;
        public List<Produto> Produtos = new List<Produto>();

        public double totalPedido()
        {
            double total = 0;
            foreach (Produto produto in Produtos)
            {
                total += produto.Preco;
            }
            return total;
        }
        public void ExibirPedido()
        {
            Console.WriteLine($"Pedido nº {Numero}");
            Console.WriteLine("Itens: ");
            foreach (Produto produto in Produtos)
            {
                Console.WriteLine($"Produto: {produto.Nome}");
                Console.WriteLine($"Preço: R${produto.Preco}");
                Console.WriteLine();
            }
            Console.WriteLine($"total: R${totalPedido()}\n");
        }
    }
}
