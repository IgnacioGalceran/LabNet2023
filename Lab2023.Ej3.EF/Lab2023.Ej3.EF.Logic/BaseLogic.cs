using Lab2023.Ej3.EF.Data;

namespace Lab2023.Ej3.EF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
