using Lab.Ejercicio4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Ejercicio4.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public IEnumerable<Categories> Ejercicio11()
        {
            var categoriesEj11 = from categories in context.Categories
                                 join product in context.Products
                                 on categories.CategoryID equals product.CategoryID
                                 select categories;
       // Dejé la consulta con las categorías duplicadas
       // porque cuando agregaba el Distinct(), por alguna razón no devolvía nada
            return categoriesEj11.ToList();
        }
    }
}
