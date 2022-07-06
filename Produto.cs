using System.Globalization;
namespace Exercicio___produtos
{
    public class Produto
    {
        public string Name;
        public double Price;
        public int Quantity;
        
        private double total;

        public double ValorTotalEmEstoque()
        {
            return total = Price * Quantity;    
        }   
        public void AdicionarProdutos(int quantity)
        {            
            Quantity += quantity;   
        }
        public void Removerprodutos(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            +" unidades, Total: $ "
            +ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}