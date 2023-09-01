using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2023.Ej3.EF.Entities;

namespace Lab2023.Ej3.EF.Logic
{
    interface IABMLogic<T, H>
    {
        List<T> GetAll();
        void Add(T Objeto);
        void Delete(H id);
        void Update(T Objeto, H id);
    }
}
