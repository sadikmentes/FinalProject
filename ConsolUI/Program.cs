using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsolUI
{
    class Program
    {
      //  private static object product;

        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(5,10))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
