using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    class Soup : CookingTemplate
    {
        protected override void PrepareIngredients()
        {
            Console.WriteLine("Chopping vegetables and preparing broth for soup.");
        }

        protected override void CookIngredients()
        {
            Console.WriteLine("Simmering ingredients to make soup.");
        }

        protected override void Serve()
        {
            Console.WriteLine("Soup served in a bowl.");
        }
    }
}
