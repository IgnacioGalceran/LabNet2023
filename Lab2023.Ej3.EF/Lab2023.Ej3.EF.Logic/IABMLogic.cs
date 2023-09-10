using System.Collections.Generic;

namespace Lab2023.Ej3.EF.Logic
{
    interface IABMLogic<T, H>
    {
        List<T> GetAll();
        bool Add(T Objeto);
        bool Delete(H id);
        bool Update(T Objeto, H id);
    }
}
