using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    public class Programmer : IProjectVisitor
    {
        public void Visit(Task task)
        {
            Console.WriteLine("Programmer is working on a task.");
        }

        public void Visit(Bug bug)
        {
            Console.WriteLine("Programmer is fixing a bug.");
        }
    }
}
