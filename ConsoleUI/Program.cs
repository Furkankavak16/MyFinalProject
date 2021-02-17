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
            //ProductTest();
            // CategoryTest();
            //DTO:Data Transformation  object
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine("Ürün Adı:{0} \n\t\f\b Kategori Adı:{1}", product.ProductName, product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

          

        }

        /// <summary>
        /// CategoryTEst
        /// </summary>
        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine("Kategori Adı:{0} \n\t Kategori Numarası:{1} ", category.CategoryName, category.CategoryId);
            }
        }

        /// <summary>
        /// ProductTest
        /// </summary>
        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll().Data)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadLine();
        }
    }
}
