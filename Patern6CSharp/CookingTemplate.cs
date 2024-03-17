using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    abstract class CookingTemplate
    {
        public void Cook()
        {
            PrepareIngredients();
            CookIngredients();
            Serve();
        }

        protected abstract void PrepareIngredients();
        protected abstract void CookIngredients();

        protected virtual void Serve()
        {
            Console.WriteLine("Dish served.");
        }
    }
}
