using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //Gives variable type (List<Product>)
            //Console.WriteLine(productManager.GetAll());


            //foreach(var product in productManager.GetAllByCategoryId(2))
            //foreach (var product in productManager.GetAll())
            foreach (var product in productManager.GetByUnitPrice(5,20))
            {
                Console.WriteLine(product.ProductName);
            }

            
        }
    }
}
