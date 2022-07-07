using System.Globalization;
namespace Exercicio___produtos
{
    public class Program
    {
        static void Main()
        {
        
            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Name : ");
            string Name = Console.ReadLine();
            Console.Write("Price : ");
            double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque : ");
            int Quantity = int.Parse(Console.ReadLine());
            
            Produto prod = new Produto(Name, Price, Quantity);
            
            prod.Name = "TV 4k";
        
            System.Console.WriteLine();

            System.Console.WriteLine("Dados do produto :" + prod);
            
            System.Console.WriteLine();
            
            System.Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque : ");
            int qtd = int.Parse(Console.ReadLine());
            prod.AdicionarProdutos(qtd);
            
            System.Console.WriteLine();

            System.Console.Write("Dados atualizados :" + prod);
            
            System.Console.WriteLine();
            
            System.Console.Write("Digite o número de produtos a ser removido do estoque :");
            int qtd2 = int.Parse(Console.ReadLine());
            prod.Removerprodutos(qtd2);

            System.Console.WriteLine();

            System.Console.Write("Dados atualizados :" + prod);

        }
    }
}
