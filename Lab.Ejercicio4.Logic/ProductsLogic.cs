using Lab.Ejercicio4.Entities;
using System.Collections.Generic;
using System.Linq;


namespace Lab.Ejercicio4.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public IEnumerable<Products> Ejercicio2()
        {
            IEnumerable<Products> productsEj2 = context.Products
                .Where(p => p.UnitsInStock == 0)
                .ToList();

            return productsEj2;
        }
        public IEnumerable<Products> Ejercicio3()
        {
            IEnumerable<Products> productsEj3 = from product in context.Products
                                                where product.UnitsInStock > 0 && product.UnitPrice > 3
                                                select product;
            return productsEj3;
        }
        public Products Ejercicio5()
        {
            int IDProducto = 789;
            Products productEj5 = context.Products
                .FirstOrDefault(p => p.ProductID == IDProducto);

            return productEj5;
        }
        public IEnumerable<Products> Ejercicio9()
        {
            var productsEj9 = from product in context.Products
                              orderby product.ProductName
                              select product;

            return productsEj9;
        }
        public IEnumerable<Products> Ejercicio10()
        {
            var productsEj10 = from product in context.Products
                              orderby product.UnitsInStock descending
                              select product;

            return productsEj10;
        }
        public Products Ejercicio12()
        {
            var productsEj12 = context.Products.FirstOrDefault();

            return productsEj12;
        }
    }
}
