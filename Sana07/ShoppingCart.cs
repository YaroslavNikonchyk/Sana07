using Sana07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoductLibrary
{
    public class ShoppingCart
    {
        List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            {
                if (product != null)
                {
                    products.Add(product);
                }
                else throw new Exception("Неправильно заданий продукт");
            }
        }
        public string ProductsInfo()
        {
            string info = "Список продуктів доданих до кошику:\n";
            for (int i = 0; i < products.Count; i++)
                info += $"{i + 1}.\n{products[i].Display()}\n";
            return info;
        }
        public string AllProductsSum()
        {
            int sum = 0;
            for (int i = 0; i < products.Count; i++)
            {
                sum += products[i].Price;
            }
            return $"Cума всiх продуктiв у кошику: {sum} UAH";
        }
    }
}
