using System.Globalization;
namespace Exercicio___produtos
{
    public class Produto
    {
        private string _name;
        public double Price{get; private set;}
        public int Quantity{get; private set;}
        
        public Produto(){}
        public Produto(string name, double price, int quantity)
        {
            _name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name{
            get{ return _name;}
            set{
                if(value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Price * Quantity;    
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
            return _name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            +" unidades, Total: $ "
            +ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}