using System.Collections.Generic;

namespace Lab2023.Ej3.EF.Logic
{
    interface IABMLogic<T, H>
    {
        List<T> GetAll();
        void Add(T Objeto);
        bool Delete(H id);
        void Update(T Objeto, H id);
    }
}
