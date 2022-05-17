using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Ürünü Sepete Eklendi");
        }
    }
}
