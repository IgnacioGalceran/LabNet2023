using Lab2023.Ej3.EF.Entities;
using Lab2023.Ej3.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2023.Ej3.EF.UI
{
    public class SuppliersLogic : BaseLogic, IABMLogic<Suppliers, string>
    {
        public void Add(Suppliers suppliers)
        {
            throw new NotImplementedException();
        }
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }

        public void Update(Suppliers suppliers, string id)
        {
            throw new NotImplementedException();
        }
    }
}
