using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Metotlar;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BasketManager basketManager = new BasketManager();

            Product product = new Product();
            product.ProductName = "İphone";

            basketManager.Add(product);



        }
    }
}