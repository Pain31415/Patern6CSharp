using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    class Pizza : CookingTemplate
    {
        protected override void PrepareIngredients()
        {
            Console.WriteLine("Preparing dough, cheese, and toppings for pizza.");
        }

        protected override void CookIngredients()
        {
            Console.WriteLine("Baking pizza in the oven.");
        }
    }
}
