using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            // Sample products which simulates the RDBMS
            _products = new List<Product> { 
                new Product{ProdcutId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInSTock=15},
                new Product{ProdcutId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInSTock=3},
                new Product{ProdcutId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInSTock=2},
                new Product{ProdcutId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInSTock=65},
                new Product{ProdcutId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInSTock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            Product productToDelete = null;
            foreach (var p in _products)
            {
                if (product.ProdcutId == p.ProdcutId)
                {
                    productToDelete = p;
                }
            }
            //Same with for each loop but if there two match then it will fail
            //productToDelete = _products.SingleOrDefault(p=>p.ProdcutId == product.ProdcutId);


            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            // Find the product that is going be updated
            Product productToUpdate = _products.SingleOrDefault(p => p.ProdcutId == product.ProdcutId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInSTock = product.UnitsInSTock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //Finds the products according to the category ID
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
