namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pedido> pedidos = new List<Pedido>();
            Produto hamburguer = new Produto();
            hamburguer.Nome = "Hambúrguer";
            hamburguer.Preco = 25.00;
            Produto batataFrita = new Produto();
            batataFrita.Nome = "Batata-Frita";
            batataFrita.Preco = 8.00;
            Produto refrigerante = new Produto();
            refrigerante.Nome = "Refrigerante";
            refrigerante.Preco = 6.50;

            Pedido pedido1 = new Pedido();
            pedido1.Numero = 1;
            pedido1.Produtos = new List<Produto>();
            pedido1.Produtos.Add(hamburguer);
            pedido1.Produtos.Add(batataFrita);
            pedidos.Add(pedido1);

            Pedido pedido2 = new Pedido();
            pedido2.Numero = 2;
            pedido2.Produtos = new List<Produto>();
            pedido2.Produtos.Add(refrigerante);
            pedido2.Produtos.Add(hamburguer);
            pedidos.Add(pedido2);

            foreach (Pedido pedido in pedidos)
            {
                pedido.ExibirPedido();
            }


        }

    }
}