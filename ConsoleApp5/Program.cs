namespace ConsoleApp5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                string op;
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
                do
                {
                 
                    Pedido pedido = new Pedido();
                    


                    string op2 = "";
                    while(op2!= "0"){
                    int produto = FazerPedido();
                        
                        switch (produto)
                        {
                            case 1:
                                pedido.Produtos.Add(hamburguer);
                                break;
                            case 2:
                                pedido.Produtos.Add(batataFrita);
                                break;
                            case 3:
                                pedido.Produtos.Add(refrigerante);
                                break;
                            default:
                                throw new Exception("Insira um pedido válido.");

                        }
                        Console.WriteLine("Digite qualquer valor para adicionar mais produtos ao pedido ou 0 para um novo pedido.");
                        op2 = Console.ReadLine();
                    }

                    pedidos.Add(pedido);
                    pedido.Numero = pedidos.Count();

                    Console.Clear();
                    Console.WriteLine("Insira 0 para parar ou qualquer valor para continuar");
                    op = Console.ReadLine();
                } while (op != "0");

                Console.Clear();
                foreach (Pedido pedido in pedidos)
                {
                    pedido.ExibirPedido();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
        static int FazerPedido() 
        {
            Console.WriteLine("Quais produtos que você deseja no seu pedido?");
            Console.WriteLine("1-Hambúrguer\n2-Batata-Frita\n3-Refrigerante");
            return int.Parse(Console.ReadLine());
        }

    }
}