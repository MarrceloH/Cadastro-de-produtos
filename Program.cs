
class Produto
{
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public int Quantidade { get; set; }

    public double Preço { get; set; }
}

class Program
{
    static Dictionary<string, Produto> estoque = new Dictionary<string, Produto>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Remover Produto");
            Console.WriteLine("3 - Consultar Estoque");
            Console.WriteLine("4 - Sair");

            Console.WriteLine();

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarProduto();
                    break;
                case "2":
                    RemoverProduto();
                    break;
                case "3":
                    ConsultarEstoque();
                    break;
                case "4":
                    Console.WriteLine("Saindo do programa. Obrigado!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
                  
            }
        }
    }
    

    static void AdicionarProduto()
    {Console.Clear();
        Console.Write("Digite o código do produto: ");
        string codigo = Console.ReadLine();

        if (estoque.ContainsKey(codigo))
        {
            Console.WriteLine("Produto já existente. Utilize a opção de alterar quantidade.");
            return;
        }

        Produto novoProduto = new Produto();

        Console.Write("Digite o nome do produto: ");
        novoProduto.Nome = Console.ReadLine();

        Console.Write("Digite a categoria do produto: ");
        novoProduto.Categoria = Console.ReadLine();

        Console.Write("Digite a quantidade a ser adicionada: ");
        novoProduto.Quantidade = int.Parse(Console.ReadLine());

        Console.Write("Digite o preço do produto: ");
        novoProduto.Preço = double.Parse(Console.ReadLine());

        estoque.Add(codigo, novoProduto);

        Console.WriteLine();

        Console.WriteLine($"Produto {codigo} adicionado com sucesso!");

        Console.WriteLine();
    
    }


    static void RemoverProduto()
    {Console.Clear();
        Console.Write("Digite o código do produto: ");
        string codigo = Console.ReadLine();

        if (estoque.ContainsKey(codigo))
        {
            Console.Write($"Remover {estoque[codigo].Nome} ({estoque[codigo].Categoria}) ({estoque[codigo].Preço}) - Quantidade atual: {estoque[codigo].Quantidade}. Digite a quantidade a ser removida: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (quantidade <= estoque[codigo].Quantidade)
            {
                estoque[codigo].Quantidade -= quantidade;
                Console.WriteLine($"Produto {codigo} removido com sucesso! Quantidade restante: {estoque[codigo].Quantidade}");
            
            Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque.");
            }
        
        Console.WriteLine();
        
        }
        else
        {
            Console.WriteLine("Produto não encontrado no estoque.");
        }
    
    Console.WriteLine();
    
    }


    static void ConsultarEstoque()
    {Console.Clear();
        Console.WriteLine("Estoque Atual:");

        foreach (var produto in estoque)
        {
            Console.WriteLine($"Código: {produto.Key}, Nome: {produto.Value.Nome}, Categoria: {produto.Value.Categoria}, Preço: {produto.Value.Preço}, Quantidade: {produto.Value.Quantidade}   unidades");
        }
    Console.WriteLine();
   
    }

}